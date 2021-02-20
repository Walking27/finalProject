using Business.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrate
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll(); 
        }

        public List<Car> GetByCarId(int id)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int Id)
        {
            return _carDal.Get(c => c.Id == Id);
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> Insert(decimal min, decimal max)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
