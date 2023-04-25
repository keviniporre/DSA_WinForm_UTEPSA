using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_Calculator
{
    public class valueClass
    {
        //Declaracion Variable/Atributos
        private double n1, n2;

        //Declaracion Metodos SET
        public void setValueN1(double value) { n1 = value; }
        public void setValueN2(double value) { n2 = value; }

        //Declaracion Metodos GET
        public double getValueN1() { return n1; }
        public double getValueN2() { return n2; }

    }
}
