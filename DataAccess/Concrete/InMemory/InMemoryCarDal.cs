using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private readonly List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 100, ModelYear = 2010, Description = "Toyota Corolla"
                },
                new Car
                {
                    Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 150, ModelYear = 2015, Description = "Renault Clio"
                },
                new Car
                {
                    Id = 3, BrandId = 1, ColorId = 2, DailyPrice = 200, ModelYear = 2015, Description = "BMW 320 "
                },
                new Car
                {
                    Id = 4, BrandId = 3, ColorId = 1, DailyPrice = 200, ModelYear = 2020, Description = "Honda Civic"
                },
                new Car
                {
                    Id = 5, BrandId = 3, ColorId = 1, DailyPrice = 125, ModelYear = 2019,
                    Description = "Volkswagen Passat"
                }
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            var updateCar = _cars.SingleOrDefault(x => x.Id == car.Id);
            updateCar.Id = car.Id;
            updateCar.ColorId = car.ColorId;
            updateCar.ModelYear = car.ModelYear;
            updateCar.DailyPrice = car.DailyPrice;
            updateCar.BrandId = car.BrandId;
            updateCar.Description = car.Description;
        }

        public void Delete(Car car)
        {
            var deleteCar = _cars.FirstOrDefault(x => x.Id == car.Id);

            _cars.Remove(deleteCar);
        }
    }
}