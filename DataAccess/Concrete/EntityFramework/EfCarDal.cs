using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EntityFrameworkBase<Car,ReCapProjectContext>,ICarDal
    {
        public List<CarDetails> CarDetaList()
        {
            using (var context =new ReCapProjectContext())
            {
                var result = from c in context.Cars
                    join cor in context.Colors
                        on c.ColorId equals cor.Id
                    join br in context.Brands
                        on c.BrandId equals br.Id
                    join ci in context.CarImages
                        on c.Id equals ci.CarId
                             select new CarDetails
                    {
                        CarName = c.Description, ColorName = cor.Name,
                        BroundName = br.Name
                    };
                return result.ToList();
            }
        }
    }
}
