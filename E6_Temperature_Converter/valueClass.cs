using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E6_Temperature_Converter
{
    public class valueClass
    {
        //Declaracion de variables/atributos
        private double celsiusValue;
        //Declaracion Metodo SET
        public void setValue(double value) { this.celsiusValue = value; }
        //Declaracion Metodo GET
        public double getValue() { return this.celsiusValue; }
    }
}
