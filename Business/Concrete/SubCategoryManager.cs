using Business.Abstract;
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
        public List<SubCategory> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubCategoryDetailDto> GetAllDetail()
        {
           return _subCategoryDal.GetSubCategoryDetails();
        }

        List<SubCategory> ISubCategoryService.GetAllByCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
