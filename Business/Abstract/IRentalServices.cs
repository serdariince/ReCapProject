using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalServices
    {
        IDataResult<List<Rental>> GetAllDataResult();
        IDataResult<Rental> GetById(int id);
        IDataResult<List<Rental>> GetCarById(int carId);
        IDataResult<List<Rental>> GetCustomerById(int customerId);

        IDataResult<List<Rental>> GetDatetimeDataResult(DateTime tarih);
        IResult Add(Rental entity);
        IResult Update(Rental entity);
        IResult Delete(Rental entity);


    }
}
