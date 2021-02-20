using Core.Entities;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByCarId(int id);
        List<Car> Insert(decimal min, decimal max);
        List<CarDetailDTO> GetCarDetails();
    }
}
