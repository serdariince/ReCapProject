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
   public  class UserManager:IUserServices
   {
       private IUserDal _user;
       public UserManager(IUserDal user)
       {
           _user = user;
       }
        public IDataResult<List<User>> GetList()
        {
            return new SuccesDataResult<List<User>>(_user.GetAll());
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccesDataResult<User>(_user.Get(x=>x.Id==id));
        }

        public IResult Add(User entity)
        {
            _user.Add(entity);
            return new SuccesResult();
        }

        public IResult Update(User entity)
        {
            _user.Update(entity);
            return new SuccesResult();
        }

        public IResult Delete(User entity)
        {
            _user.Delete(entity);
            return new SuccesResult();
        }
    }
}
