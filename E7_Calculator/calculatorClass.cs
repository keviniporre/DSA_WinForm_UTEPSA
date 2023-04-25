using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_Calculator
{
    public class calculatorClass:valueClass
    {
        //Declaracion Variables/Atributos
        private double answer;

        //Declaracion Metodos
        public double addition()
        {
            answer = this.getValueN1() + this.getValueN2();
            return answer;
        }
        public double subtraction()
        {
            answer = this.getValueN1() - this.getValueN2();
            return answer;
        }
        public double multiplication()
        {
            answer = this.getValueN1() * this.getValueN2();
            return answer;
        }
        public double division()
        {
            answer = this.getValueN1() / this.getValueN2();
            return answer;
        }

    }
}
