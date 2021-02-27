using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public    class BrandManager:IBrandServices
    {
        private IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetList()
        {
            return new SuccesDataResult<List<Brand>>(_brandDal.GetAll());

        }

        public IDataResult<Brand> GetCarsByBrandId(int brandId)
        {
            return new SuccesDataResult<Brand>(_brandDal.Get(x=>x.Id==brandId));
        }

        public IResult Add(Brand entity)
        {
            _brandDal.Add(entity);
            return new SuccesResult();
        }

        public IResult Update(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccesResult();
        }

        public IResult Delete(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccesResult();
        }
    }
}
