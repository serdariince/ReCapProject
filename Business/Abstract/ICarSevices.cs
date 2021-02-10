using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarSevices
    {
       IDataResult <List<Car>> GetList();
       IDataResult<List<Car>> GetCarsByBrandId(int brandId);
       IDataResult<List<Car>> GetCarsByColorId(int colorId);

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}