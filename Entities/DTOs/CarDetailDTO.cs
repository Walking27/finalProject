using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class CarDetailDTO:IDto
    {
        public int BrandId { get; set; }
        public string ModelYear { get; set; }
        public string Description { get; set; }
        public double DailyPrice { get; set; }
    }
}
