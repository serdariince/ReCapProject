using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntitiyFramework
{
   public class EntityFrameworkBase<Tentitiy,Tcontext>: IEntitiyFramework<Tentitiy> where Tentitiy: class,IEntity,new()
    where Tcontext:DbContext,new()
    {
        public List<Tentitiy> GetAll(Expression<Func<Tentitiy, bool>> filter = null)
        {
            using (var _context=new Tcontext())
            {
                return filter == null
                    ? _context.Set<Tentitiy>().ToList()
                    : _context.Set<Tentitiy>().Where(filter).ToList();
            }
        }

        public Tentitiy Get(Expression<Func<Tentitiy, bool>> filter)
        {
            using (var _context = new Tcontext())
            {
                return  _context.Set<Tentitiy>().SingleOrDefault(filter);
            }
        }

        public void Add(Tentitiy entity)
        {
            using (var _context = new Tcontext())
            {
                var result = _context.Entry(entity);
                result.State = EntityState.Added;
                _context.SaveChanges();
            }
        }

        public void Update(Tentitiy entity)
        {
            using (var _context = new Tcontext())
            {
                var result = _context.Entry(entity);
                result.State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        public void Delete(Tentitiy entity)
        {
            using (var _context = new Tcontext())
            {
                var result = _context.Entry(entity);
                result.State = EntityState.Deleted;
                _context.SaveChanges();
            }
        }
    }
}
