using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.CrossCuttingConcerns.Validation;
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

        public IResult Add(Category category)
        {
            ValidationTool.Validate(new CategoryValidator(), category);

            _categoryDal.Add(category);

            return new SuccessResult(Messages.CategoryAdded);
        }

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
    }
}
