using Core.DataAccess;
using Core.Entities;
using Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailDTO> GetCarDetails();
    }
}
