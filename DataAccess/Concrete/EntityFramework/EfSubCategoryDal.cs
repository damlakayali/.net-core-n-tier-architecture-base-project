using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSubCategoryDal : EfEntityRepositoryBase<SubCategory, ProjectDbContext>, ISubCategoryDal
    {
        public List<SubCategoryDetailDto> GetSubCategoryDetails()
        {
            using (ProjectDbContext context= new ProjectDbContext())
            {
                var result = from sc in context.SubCategories
                             join c in context.Categories
                             on sc.categoryId equals c.id
                             select new SubCategoryDetailDto
                             {
                                 id = sc.id,
                                 name = sc.name,
                                 category = c.name,
                                 categoryId = c.id,
                                 createdById = sc.createdById,
                                 createdTime = sc.createdTime,
                                 lastUpdatedById = sc.lastUpdatedById,
                                 lastUpdatedTime = sc.lastUpdatedTime,
                             };

                return result.ToList();
            }

            
        }
    }
}
