using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrate.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carDals;

        public InMemoryCarDal()
        {
            _carDals = new List<Car>
            {
                new Car{BrandId=1,Id=10,ColorId=78,DailyPrice=120.500,Description="Sahibinden satlık 0 ayarında",ModelYear=2018},
            new Car{BrandId=2,Id=20,ColorId=79,DailyPrice=100.000,Description="Sahibinden satlık 0 ayarında",ModelYear=2018},
            new Car{BrandId=3,Id=30,ColorId=80,DailyPrice=120.000,Description="Sahibinden satlık 0 ayarında",ModelYear=2018},
            new Car{BrandId=4,Id=40,ColorId=81,DailyPrice=180.500,Description="Sahibinden satlık 0 ayarında",ModelYear=2018},
            new Car{BrandId=5,Id=50,ColorId=82,DailyPrice=99.000,Description="Sahibinden satlık 0 ayarında",ModelYear=2018},
            new Car{BrandId=6,Id=60,ColorId=83,DailyPrice=100.750,Description="Sahibinden satlık 0 ayarında",ModelYear=2018},
            new Car{BrandId=7,Id=70,ColorId=84,DailyPrice=168.500,Description="Sahibinden satlık 0 ayarında",ModelYear=2018},
            new Car{BrandId=8,Id=80,ColorId=85,DailyPrice=125.000,Description="Sahibinden satlık 0 ayarında",ModelYear=2018},
            new Car{BrandId=9,Id=90,ColorId=86,DailyPrice=150.000,Description="Sahibinden satlık 0 ayarında",ModelYear=2018},
            new Car{BrandId=10,Id=100,ColorId=87,DailyPrice=128.500,Description="Sahibinden satlık 0 ayarında",ModelYear=2018}
            };
        }

        public void Add(Car car)
        {
            _carDals.Add(car);
        }

        public void Delete(Car car)
        {
            Car deletedToCar = _carDals.SingleOrDefault(c => c == car);

            _carDals.Remove(deletedToCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _carDals;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            return _carDals.SingleOrDefault(p => p.Id == Id);
        }

        public void Update(Car car)
        {
            Car updatedToCar = _carDals.SingleOrDefault(c => c == car);
            updatedToCar.Id = car.Id;
            updatedToCar.BrandId = car.BrandId;
            updatedToCar.ColorId = car.ColorId;
            updatedToCar.ModelYear = car.ModelYear;
            updatedToCar.DailyPrice = car.DailyPrice;
            updatedToCar.Description = car.Description;
        }
    }
}
