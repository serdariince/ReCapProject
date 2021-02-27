using Core.DataAccess.EntitiyFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarImageDal:EntityFrameworkBase<CarImage,ReCapProjectContext>,ICarImageDal
    {
        
    }
}