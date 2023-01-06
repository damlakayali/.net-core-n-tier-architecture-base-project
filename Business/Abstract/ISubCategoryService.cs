using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISubCategoryService
    {
        IDataResult<List<SubCategory>> GetAll();
        IDataResult<List<SubCategory>> GetAllByCategory(int id);
        IDataResult<List<SubCategoryDetailDto>> GetAllDetail();
        IDataResult<SubCategory>  GetById(int id);
        IResult Add(SubCategory subCategory);  
    }
}
