using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_DSA_v2
{
    
    public class valueClass
    {
        //Declaracion de variables/atributos vacios
        private string idValue, nameValue, instructorValue, categoryValue, lengthValue, priceValue;
        private int numberOfCourses, selectedRowIndex, searchRowIndex;
        public static int MyVariable = 0;

        //Declaracion Constructor
        public valueClass()
        {
            idValue = nameValue = instructorValue = categoryValue = lengthValue = priceValue = string.Empty;
            numberOfCourses = selectedRowIndex = searchRowIndex = -1;
        }
        //Declaracion Metodos SET Form 1
        public void setNummberOfCourses(int nummberOfCourses) { this.numberOfCourses = nummberOfCourses; }
        public int getNummberOfCourses() {  return this.numberOfCourses; }

        public void isNumber(int numberOfCourses)
        {
            //
        }

        //Declaracion Metodos SET Form 2
        public void setId(string id) { this.idValue = id; }
        public void setName(string name) { this.nameValue = name; }
        public void setInstructor(string instructor) { this.instructorValue = instructor; }
        public void setCategory(string category) {  this.categoryValue = category; }
        public void setLength(string length) { this.lengthValue = length; }
        public void setPrice(string price) {  this.priceValue = price; }
        public void setselectedRowIndex(int selectedRowIndex) { this.selectedRowIndex = selectedRowIndex; }
        public void setSearchRowIndex(int rowIndex) { this.searchRowIndex = rowIndex; }

        public string getId() { return idValue; }
        public string getName() { return nameValue; }
        public string getInstructor() { return instructorValue; }
        public string getCategory() { return categoryValue; }
        public string getLength() { return lengthValue; }
        public string getPrice() { return priceValue; }
        public int getselectedRowIndex() { return selectedRowIndex; }
        public int getSearchRowIndex() {  return searchRowIndex; }


    }
}
