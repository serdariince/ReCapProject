using System.Collections.Generic;
using Core.DataAccess.EntitiyFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntitiyFramework<Car>
    {
        List<CarDetails> CarDetaList();
    }
}