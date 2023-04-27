using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_DSA_UTEPSA
{
    public class valueClass
    {
        //Declaracion variables/atributos
        private string id, name, instructor, category, length, language;

        //Declaracion Metodos SET
        private void setId(string id) { this.id = id; }
        private void setName(string name) { this.name = name; }
        private void setInstructor(string instructor) { this.instructor = instructor; }
        private void setCategory(string category) {  this.category = category; }
        private void setLength(string length) {  this.length = length; }
        private void setLanguage(string language) {  this.language = language; }
        
        //Declaracion Metodos GET
        public string getId() { return this.id; }
        public string getName() { return this.name; }
        public string getInstructor() { return this.instructor; }
        public string getCategory() { return this.category; }
        public string getLength() { return this.length; }  
        public string getLanguage() { return this.language; }

        //Declaracion Constructor
        public valueClass()
        {
            id = "";
            name = "";
            instructor = "";
            category = "";
            length = "";
            language = "";
        }

    }
}
