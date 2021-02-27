using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager:IRentalServices
    {
        private IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IDataResult<List<Rental>> GetAllDataResult()
        {
           return new SuccesDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccesDataResult<Rental>(_rentalDal.Get(rental =>rental.Id==id));
        }

        public IDataResult<List<Rental>> GetCarById(int carId)
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Rental>>(Messages.ErrorId);
            }

            var result = _rentalDal.GetAll(x => x.CarId == carId);
            return new SuccesDataResult<List<Rental>>(result);
        }

        public IDataResult<List<Rental>> GetCustomerById(int customerId)
        {
            return new SuccesDataResult<List<Rental>>(_rentalDal.GetAll(x=>x.CustomerId==customerId));
        }

        public IDataResult<List<Rental>> GetDatetimeDataResult(DateTime tarih)
        {
            return new SuccesDataResult<List<Rental>>(_rentalDal.GetAll(x=>x.RentDate==tarih));
        }

        public IResult Add(Rental entity)
        {
            _rentalDal.Add(entity);
            return new SuccesResult();
        }

        public IResult Update(Rental entity)
        {
            _rentalDal.Add(entity);
            return new SuccesResult();
        }

        public IResult Delete(Rental entity)
        {
            _rentalDal.Add(entity);
            return new SuccesResult();
        }
    }
}
