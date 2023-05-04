using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnify_Spanish
{
    public class ProgramActions
    {
        //Declaracion de variables/atributos
        private int firstRow, lastRow, maxRows;
        private string[] container;
        private string[,] matrix;
        private bool matrixFull;

        //Declaracion del Constructor
        public matrixClass()
        {
            firstRow = 0;
            lastRow = -1;
            maxRows = getNumberOfCourses();
            container = new string[6];
            matrix = new string[6, maxRows];
            matrixFull = false;
        }
        //Asigna todos los valores a las variables correspondientes
        public void setAllValues(TextBox txtId, TextBox txtName, TextBox txtInstructor, TextBox txtCategory, TextBox txtLength, TextBox txtPrice)
        {
            setId(txtId);
            setName(txtName.Text);
            setInstructor(txtInstructor.Text);
            setCategory(txtCategory.Text);
            setLength(txtLength.Text);
            setPrice(txtPrice.Text);
        }
        //Asigna los valores de las variables a un contenedor Array
        public void setValuesToContainer()
        {
            container[0] = getId();
            container[1] = getName();
            container[2] = getInstructor();
            container[3] = getCategory();
            container[4] = getLength();
            container[5] = getPrice();
        }
        //Verifica si la matriz esta vacia
        public bool isMatrixEmpty()
        {
            if (lastRow < firstRow) { return true; }
            else { return false; }
        }
        //Verifica si la matriz esta llena
        public bool isMatrixFull()
        {
            if (lastRow == maxRows - 1) { return true; }
            else { return false; }
        }
        //Inserta los valores del contenedor en la matriz
        public void insertContainerToMatrix()
        {
            //Verifica primero se la matriz esta llena
            if (isMatrixFull())
            {
                MessageBox.Show("La matriz esta llena", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                matrixFull = true;
            }
            else
            {
                //De no estar llena la matriz, agrega el contenedor array a la matriz
                lastRow++;
                for (int i = 0; i < 6; i++)
                {
                    matrix[i, lastRow] = container[i];
                }
            }
        }
        //Elimina una fila de la matriz y del DataGridView
        public void deleteRow(DataGridView grid)
        {
            //Verifica si la matriz esta vacia o se selecciono un indice invalido
            if (isMatrixEmpty() || getselectedRowIndex() == -1)
            {
                MessageBox.Show("La matriz esta vacia o seleccionaste una celda invalida", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //Elimina la fila del DataGridView que se clickeo
                grid.Rows.RemoveAt(getselectedRowIndex());

                //Elimina de la matriz la fila correspondiente
                for (int i = 0; i < 6; i++)
                {
                    for (int j = getselectedRowIndex(); j < lastRow; j++)
                    {
                        matrix[i, j] = matrix[i, j + 1];
                    }
                }
                //Vacia o asigna a ceros el valor de la ultima fila de la matriz
                for (int i = 0; i < 6; i++)
                {
                    matrix[i, lastRow] = string.Empty;
                }

                matrixFull = false;
                lastRow--;
            }
        }
        //Muestra en el DataGridView el contenido de la matriz
        public void showOnGrid(DataGridView grid)
        {
            if (!matrixFull)
            {
                grid.Rows.Add();

                for (int i = 0; i < 6; i++)
                {
                    grid.Rows[lastRow].Cells[i].Value = matrix[i, lastRow];
                }
            }
        }
        //Vacia el contenido de la matriz y limpia el DataGridView
        public void emptyMatrix(DataGridView grid)
        {
            grid.Rows.Clear();
            matrixFull = false;
            lastRow = -1;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < lastRow; j++)
                {
                    matrix[i, j] = string.Empty;
                }
            }
        }
        //Busca el Indice de la fila que se busca
        public void searchItemRowIndex()
        {
            setSearchRowIndex(-1);

            for (int i = 0; i <= lastRow; i++)
            {
                if (matrix[0, i] == getId()) { setSearchRowIndex(i); }
            }
        }
        //Muestra en un DataGridView el resultado de la busqueda
        public void showSearchMatrix(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Rows.Add();

            if (getSearchRowIndex() == -1) { MessageBox.Show("Lo siento, ese ID de curso no existe", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    grid.Rows[0].Cells[i].Value = matrix[i, getSearchRowIndex()];
                    //Change sometime
                }
            }
        }
        //Limpia todos los Texbox
        public void clearAllTextbox(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6)
        {
            txt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = txt6.Text = string.Empty;
        }
    }
}
