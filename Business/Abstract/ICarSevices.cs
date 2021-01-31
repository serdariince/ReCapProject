﻿using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarSevices
    {
        List<Car> GetList();
        List<Car> GetById(int carId);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}