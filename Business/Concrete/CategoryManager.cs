using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        [LogAspect(typeof(DatabaseLogger))]
        [SecuredOperation("admin")]
        [ValidationAspect(typeof(CategoryValidator))]
        [CacheRemoveAspect("ICategoryService.Get")]
        public IResult Add(Category category)
        {
            IResult result = BusinessRules.Run(CheckCategoryNameExist(category.nameTr, category.nameEng));

            if (result!=null)
            {
                return new ErrorResult(result.Message);
            }
            _categoryDal.Add(category);

            return new SuccessResult(Messages.CategoryAdded);
         
        }

        [CacheAspect]
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), "All categories.");
        }

        public IDataResult<List<Category>> GetAllByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Category> GetById(int id)
        {
            throw new NotImplementedException();
        }

        private IResult CheckCategoryNameExist(string nameTr,string nameEng)
        {
            var result = _categoryDal.GetAll(c => c.nameTr == nameTr || c.nameEng == nameEng).Any();
            if(result)
            {
                return new ErrorResult("Category name already exist.");
            }

            return new SuccessResult();
        }

        [TransactionScopeAspect]
        public IResult TransactionalOperation(Category category)
        {
            _categoryDal.Update(category);
            _categoryDal.Add(category);
            return new SuccessResult("Success");
        }
    }
}
