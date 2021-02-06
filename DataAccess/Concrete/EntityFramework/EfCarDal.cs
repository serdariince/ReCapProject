using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (var context = new ReCapProjectContext())
            {

                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public void Add(Car entity)
        {
            using (var context = new ReCapProjectContext())
            {
                var addentity = context.Entry(entity);
                addentity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(Car entity)
        {
            using (var context = new ReCapProjectContext())
            {
                var updatEntry = context.Entry(entity);
                updatEntry.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (var context = new ReCapProjectContext())
            {
                var deletEntry = context.Entry(entity);
                deletEntry.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
