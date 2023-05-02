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
        private int selectedRowIndex, searchRowIndex;
        //Declaracion de variable Global
        public static int numberOfCourses = 0;

        //Declaracion del Constructor
        public valueClass()
        {
            idValue = nameValue = instructorValue = categoryValue = lengthValue = priceValue = string.Empty;
            selectedRowIndex = searchRowIndex = -1;
        }
        //Declaracion Metodos SET Form 1
        //Para asignar el numero de cursos verifica que sea un numero y mayor que cero.
        public void setNumberOfCourses(string txtNumberCourses) 
        { 
            if (isGreaterThanZero(txtNumberCourses))
            {
                numberOfCourses = Convert.ToInt16(txtNumberCourses);
            }
            else { MessageBox.Show("Por favor escriba un numero valido de cursos", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        //Metodo Get que retorna el numero de cursos.
        public int getNumberOfCourses() {  return numberOfCourses; }


        //Declaracion Metodos SET Form 2
        public void setId(TextBox txtId) { this.idValue = txtId.Text; }
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

        //Metodos de Validacion
        //Verifica si se puede convertir a un entero, de no poderse devuelve null.
        public int? ParseInt(string str)
        {
            int result;
            if (int.TryParse(str, out result)) { return result; }
            else { return null; }
        }
        //Verifica si es un numero, retorna verdadero/falso
        public bool isNumber(string number)
        {
            int? parsedInt = ParseInt(number);
            if (parsedInt.HasValue) { return true; }
            else { return false; }
        }
        //Verifica si el numero es mayor que cero
        public bool isGreaterThanZero(string number)
        {
            if (isNumber(number))
            {
                if (Convert.ToInt16(number) > 0) { return true; }
                else { return false; }
            }
            return false;
        }
        //Verifica si el Texbox esta vacio
        public bool isTextboxEmpty(TextBox txtEmpty) { return string.IsNullOrEmpty(txtEmpty.Text); }
        //Verifica si el Texbox esta lleno de espacios
        public bool isTextboxSpaces(TextBox txtSpaces) { return string.IsNullOrWhiteSpace(txtSpaces.Text); }
        //Verifica si algun textbox esta vacio o lleno de espacios
        public bool isAnyTextboxEmpty(params TextBox[] textboxes)
        {
            foreach (var txtbox in textboxes)
            {
                if (isTextboxEmpty(txtbox) || isTextboxSpaces(txtbox)) { return true; }
            }
            return false;
        }
        //Devuelve el textbox que esta vacio de estar todos llenos devuelve null
        public TextBox getEmptyTextboxName(params TextBox[] textBoxes)
        {
            foreach (var textbox in textBoxes)
            {
                if (isTextboxEmpty(textbox) || isTextboxSpaces(textbox))
                {
                    return textbox;
                }
            }
            return null;
        }

    }
}
