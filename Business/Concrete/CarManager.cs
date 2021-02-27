using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRıles.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Business.Concrete
{
    public class CarManager : ICarServices
    {
        private readonly ICarDal _carDal;
        private ICarServices _carServices;

        public CarManager(ICarDal carDal, ICarServices carServices)
        {
            _carDal = carDal;
            _carServices = carServices;
        }

        public IDataResult<List<Car>> GetList()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }

            return new SuccesDataResult<List<Car>>(_carDal.GetAll(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            if (brandId<=0)
            {
                return new ErrorDataResult<List<Car>>(Messages.ErrorId);
            }
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(x => x.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccesDataResult<List<Car>>(_carDal.GetAll(x => x.ColorId == colorId)); 
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccesDataResult<Car>(_carDal.Get(x=>x.Id==id));
        }

        public IDataResult<List<CarDetails>> GetDetails()
        {
            return new SuccesDataResult<List<CarDetails>>(_carDal.CarDetaList());
        }

   //     [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            _carDal.Add(car);
            return new SuccesResult(Messages.CarAdded);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccesResult(Messages.CarAdded);

        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car); 
            return  new SuccesResult(Messages.CarAdded);

        }

    }
}