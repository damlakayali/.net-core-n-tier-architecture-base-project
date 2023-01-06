using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public IResult Add(SubCategory subCategory)
        {
            _subCategoryDal.Add(subCategory);

            return new SuccessResult(Messages.CategoryAdded);
        }

        public IDataResult<List<SubCategory>> GetAll()
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategoryDal.GetAll(), "All sub categories.");
        }

        public IDataResult<List<SubCategoryDetailDto>> GetAllDetail()
        {
            return new SuccessDataResult<List<SubCategoryDetailDto>>(_subCategoryDal.GetSubCategoryDetails(), "All sub categories.");
        }

        public IDataResult<SubCategory> GetById(int id)
        {
            return new SuccessDataResult<SubCategory>(_subCategoryDal.Get(i => id == id), "sub category.");
        }

        public IDataResult<List<SubCategory>> GetAllByCategory(int id)
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategoryDal.GetAll(i=>i.categoryId==id), "All sub categories.");
        }

    }
}
