using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_DSA_UTEPSA_v1
{
    public class valueClass
    {
        //Declaracion variables/atributos
        private string idVal, nameVal, instructorVal, categoryVal, lengthVal, priceVal;

        //Declaracion Metodos SET
        public void setId(string id) { this.idVal = id; }
        public void setName(string name) { this.nameVal = name; }
        public void setInstructor(string instructor) { this.instructorVal = instructor; }
        public void setCategory(string category) { this.categoryVal = category; }
        public void setLength(string length) { this.lengthVal = length; }
        public void setPrice(string language) { this.priceVal = language; }

        //Declaracion Metodos GET
        public string getId() { return this.idVal; }
        public string getName() { return this.nameVal; }
        public string getInstructor() { return this.instructorVal; }
        public string getCategory() { return this.categoryVal; }
        public string getLength() { return this.lengthVal; }
        public string getPrice() { return this.priceVal; }

        //Declaracion Constructor
        public valueClass()
        {
            idVal = "";
            nameVal = "";
            instructorVal = "";
            categoryVal = "";
            lengthVal = "";
            priceVal = "";
        }
    }
}
