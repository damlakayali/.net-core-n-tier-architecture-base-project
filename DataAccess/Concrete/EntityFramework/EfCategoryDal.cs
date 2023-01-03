using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {

       
      
        public void Add(Category entity)
        {
            using (ProjectDbContext context = new ProjectDbContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State=EntityState.Added;
                context.SaveChanges();  
            }
        }

        public void Delete(Category entity)
        {
            using (ProjectDbContext context = new ProjectDbContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            using(ProjectDbContext context = new ProjectDbContext())
            {
                return filter==null ? context.Set<Category>().ToList() : context.Set<Category>().Where(filter).ToList();
            }
        }

        public void Update(Category entity)
        {
            using (ProjectDbContext context = new ProjectDbContext())
            {
                var updatededEntity = context.Entry(entity);
                updatededEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
