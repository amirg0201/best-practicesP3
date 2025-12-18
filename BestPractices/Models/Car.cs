using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.Models
{
    public class Car : Vehicle
    {
        public override int Tires { get => 4; }

        public Car(string color, string brand, string model, int year) 
        : base(color, brand, model, 10, year)
        {

        }
    }
}
