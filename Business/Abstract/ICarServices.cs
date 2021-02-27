using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarServices
    {
       IDataResult <List<Car>> GetList();
       IDataResult<List<Car>> GetCarsByBrandId(int brandId);
       IDataResult<List<Car>> GetCarsByColorId(int colorId);
       IDataResult<Car> GetById(int id);
       IDataResult<List<CarDetails>> GetDetails();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}