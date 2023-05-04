using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnify_Spanish
{
    public class ProgramValues
    {
        //Declaracion de variable Global
        public static int numeroDeCursos = 0;
        //Declaracion de atributos frontend
        private string idCurso, nombreCurso, instructorCurso, categoriaCurso, duracionCurso, precioCurso;
        private int indiceFilaSeleccionada, indiceFilaBuscar;
        //Declaracion de atributos backend
        private int primerFila, ultimaFila, maximoDeFilas, cantidadColumnas;
        private string[] contenedor;
        private string[,] matriz;
        private bool estaMatrizLlena;

        //Declaracion del Constructor
        public ProgramValues()
        {
            //Set atributos Frontend
            idCurso = nombreCurso = instructorCurso = categoriaCurso = duracionCurso = precioCurso = string.Empty;
            indiceFilaSeleccionada = indiceFilaBuscar = -1;
            //Set atributos Backend
            cantidadColumnas = 6;
            primerFila = 0;
            ultimaFila = -1;
            maximoDeFilas = getNumeroDeCursos();
            contenedor = new string[cantidadColumnas];
            matriz = new string[cantidadColumnas, maximoDeFilas];
            estaMatrizLlena = false;
        }
        //Declaracion Metodos SET
        public void setNumeroDeCursos(string txtNumeroDeCursos) { numeroDeCursos = Convert.ToInt32(txtNumeroDeCursos); }
        public void setId(TextBox txtId) { idCurso = txtId.Text; }
        public void setNombre(string name) { nombreCurso = name; }
        public void setInstructor(string instructor) { instructorCurso = instructor; }
        public void setCategoria(string category) { categoriaCurso = category; }
        public void setDuracion(string length) { duracionCurso = length; }
        public void setPrecio(string price) { precioCurso = price; }
        public void setIndiceFilaSeleccionada(int selectedRowIndex) { indiceFilaSeleccionada = selectedRowIndex; }
        public void setIndiceFilaBuscar(int rowIndex) { indiceFilaBuscar = rowIndex; }

        //Declaracion Metodos GET
        public int getNumeroDeCursos() { return numeroDeCursos; }
        public string getId() { return idCurso; }
        public string getNombre() { return nombreCurso; }
        public string getInstructor() { return instructorCurso; }
        public string getCategoria() { return categoriaCurso; }
        public string getDuracion() { return duracionCurso; }
        public string getPrecio() { return precioCurso; }
        public int getIndiceFilaSeleccionada() { return indiceFilaSeleccionada; }
        public int getIndiceFilaBuscar() { return indiceFilaBuscar; }

        //Metodos de Validacion
        //Verifica si puede convertir a entero, de no poderse devuelve null.
        public int? intentaConvertirEntero(string numeroIntentarConvertir)
        {
            int resultado;
            if (int.TryParse(numeroIntentarConvertir, out resultado)) { return resultado; }
            else { return null; }
        }
        //Verifica si el numero es mayor que cero.
        public bool esMayorQueCero(string numeroParaEvaluar)
        {
            int? numeroConvertido = intentaConvertirEntero(numeroParaEvaluar);
            if (numeroConvertido.HasValue)
            {
                if (numeroConvertido > 0) { return true; }
            }
            return false;
        }
        //Verifica si un Texbox esta vacio
        public bool estaTextboxVacio(TextBox txtParaEvaluar)
        {
            if (string.IsNullOrEmpty(txtParaEvaluar.Text) || string.IsNullOrWhiteSpace(txtParaEvaluar.Text)) { return true; }
            else { return false; }
        }
        //Verifica si algun textbox esta vacio o lleno de espacios
        public bool estaAlgunTextboxVacio(params TextBox[] textboxes)
        {
            foreach (var txtbox in textboxes)
            {
                if (estaTextboxVacio(txtbox)) { return true; }
            }
            return false;
        }
        //Devuelve el textbox que esta vacio de estar todos llenos devuelve null
        public TextBox? getNombreTextboxVacio(params TextBox[] textBoxes)
        {
            foreach (var textbox in textBoxes)
            {
                if (estaTextboxVacio(textbox)) { return textbox; }
            }
            return null;
        }
    }
}
