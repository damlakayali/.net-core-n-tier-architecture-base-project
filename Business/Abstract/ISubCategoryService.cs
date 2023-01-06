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
        List<SubCategory> GetAll();
        List<SubCategory> GetAllByCategory(int id);
        List<SubCategoryDetailDto> GetAllDetail();
    }
}
