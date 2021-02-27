using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Entities.Concrete;

namespace Entities.DTOs
{
   public  class CarDetails:IDTOs
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string BroundName { get; set; }
        public string ColorName { get; set; }
    }
}
