using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_SumaCola
{
    public class valueClass
    {
        private int value;
        private int maxLength;

        public void setMaxLength(int maxLength) { this.maxLength = maxLength; }
        public void setValue(int value) { this.value = value; }

        public int getMaxLength() { return this.maxLength; }
        public int getValue() { return this.value; }

        public valueClass() 
        {
            maxLength = 0;
            value = 0;
        }
    }
}
