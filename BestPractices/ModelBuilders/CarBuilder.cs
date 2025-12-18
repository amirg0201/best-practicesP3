using Best_Practices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Practices.ModelBuilders
{
    public class CarBuilder
    {
        // DOC: Valores por defecto para facilitar la creación
        private string _brand = "Ford";
        private string _model = "Mustang";
        private string _color = "Red";
        private int _year = DateTime.Now.Year; // DOC: Cumple el requerimiento de "Año Actual"

        public CarBuilder SetBrand(string brand)
        {
            _brand = brand;
            return this;
        }

        public CarBuilder SetModel(string model)
        {
            _model = model;
            return this;
        }

        public CarBuilder SetColor(string color)
        {
            _color = color;
            return this;
        }

        // DOC: Método para soportar la nueva propiedad
        public CarBuilder SetYear(int year)
        {
            _year = year;
            return this;
        }

        // DOC: Si en el futuro agregan "Sunroof", solo agregamos SetSunroof() aquí
        // sin romper el constructor de Car.
        public Car Build()
        {
            return new Car(_color, _brand, _model, _year);
        }
    }
}
