using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntitiyFramework;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserServices
    {
        IDataResult<List<User>> GetList();
        IDataResult<User> GetById(int id);

        IResult Add(User entity);
        IResult Update(User entity);
        IResult Delete(User entity);
    }
}
