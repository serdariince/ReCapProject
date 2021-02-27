using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageServices
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetCarById(int carId);
        IDataResult<CarImage> GetById(int id);
        IResult Add(IFormFile file ,CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);
    }
}