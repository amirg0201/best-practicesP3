using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.ModelBuilders
{
    public class CarBuilder
    {
        private string Brand = "Ford";
        private string Model = "Mustang";
        private string Color = "Red";
        private int _year = DateTime.Now.Year;

        public CarBuilder SetBrand(string brand)
        {
            Brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            Model = model;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            Color = color;
            return this;
        }
        
        public Car Build()
        {
            return new Car(Color, Brand, Model);
        }
    }
}
