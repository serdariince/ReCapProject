using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var carManager = new CarManager(new InMemoryCarDal());

            Console.WriteLine("---------------------------------GetAll---------------------------------------");

            foreach (var car in carManager.GetList())
                Console.WriteLine(car.Id + " Araç bilgisi " + car.Description + " günlük fiyatı :" + car.DailyPrice);

            Console.WriteLine("---------------------------------GetById---------------------------------------");
            foreach (var car in carManager.GetById(1))
                Console.WriteLine(car.Id + " Araç bilgisi " + car.Description + " günlük fiyatı :" + car.DailyPrice);

            Console.WriteLine("---------------------------------Add---------------------------------------");
            var newCar = new Car
                {Id = 10, BrandId = 3, ColorId = 2, DailyPrice = 250, ModelYear = 2020, Description = "Mercedes C180"};
            carManager.Add(newCar);
            foreach (var car in carManager.GetList())
                Console.WriteLine(car.Id + " Araç bilgisi " + car.Description + " günlük fiyatı :" + car.DailyPrice);

            Console.WriteLine("---------------------------------Update---------------------------------------");
            var updateCar = new Car
                {Id = 10, BrandId = 3, ColorId = 2, DailyPrice = 350, ModelYear = 2020, Description = "Mercedes C180"};
            carManager.Update(updateCar);
            foreach (var car in carManager.GetList())
                Console.WriteLine(car.Id + " Araç bilgisi " + car.Description + " günlük fiyatı :" + car.DailyPrice);

            Console.WriteLine("---------------------------------Delete---------------------------------------");
            var deleteCar = new Car
                {Id = 10, BrandId = 3, ColorId = 2, DailyPrice = 350, ModelYear = 2020, Description = "Mercedes C180"};
            carManager.Delete(deleteCar);
            foreach (var car in carManager.GetList())
                Console.WriteLine(car.Id + " Araç bilgisi " + car.Description + " günlük fiyatı :" + car.DailyPrice);
        }
    }
}