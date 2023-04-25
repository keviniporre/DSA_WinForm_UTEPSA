using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_Temperature_Converter
{
    public class converterClass:valueClass
    {
        //Declaracion variables/atributos
        double Fahrenheit, Kelvin, Rankine;
        //Declaracion Metodos
        public double ToFahrenheit()
        {
            Fahrenheit = this.getValue() * 1.8 + 32;
            return Fahrenheit;
        }
        public double ToKelvin()
        {
            Kelvin = this.getValue() + 273.15;
            return Kelvin;
        }
        public double ToRankine()
        {
            Rankine = ToKelvin() * 1.8;
            return Rankine;
        }
    }
}
