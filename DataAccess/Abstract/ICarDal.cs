using System.Collections.Generic;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntitiyFramework<Car>
    {
        }
}