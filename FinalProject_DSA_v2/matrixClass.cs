using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_DSA_v2
{
    public class matrixClass:valueClass
    {
        //Declaracion de variables/atributos
        private int firstRow, lastRow, maxRows;
        private string[] container;
        private string[,] matrix;
        private bool matrixFull;

        //Declaracion de Constructor
        public matrixClass()
        {
            firstRow = 0;
            lastRow = -1;
            maxRows = getNumberOfCourses();
            container = new string[6];
            matrix = new string[6, maxRows];
            matrixFull = false;
        }
        public void setAllValues(TextBox txtId, TextBox txtName, TextBox txtInstructor, TextBox txtCategory, TextBox txtLength, TextBox txtPrice)
        {
            setId(txtId);
            setName(txtName.Text);
            setInstructor(txtInstructor.Text);
            setCategory(txtCategory.Text);
            setLength(txtLength.Text);
            setPrice(txtPrice.Text);
        }
        public void setValuesToContainer()
        {
            container[0] = getId();
            container[1] = getName();
            container[2] = getInstructor();
            container[3] = getCategory();
            container[4] = getLength();
            container[5] = getPrice();
        }
        public bool isMatrixEmpty()
        {
            if (lastRow < firstRow) { return true; }
            else { return false; }
        }
        public bool isMatrixFull()
        {
            if (lastRow == maxRows - 1) { return true; }
            else { return false; }
        }
        public void insertContainerToMatrix()
        {
            if (isMatrixFull())
            {
                MessageBox.Show("The matrix is full", "Learnify - Online Courses", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                matrixFull = true;
            }
            else
            {
                lastRow++;
                for (int i = 0; i < 6; i++)
                {
                    matrix[i, lastRow] = container[i];
                }
            }
        }
        //Need to Move Items According to deleted cell
        public void deleteRow(DataGridView grid)
        {
            if (isMatrixEmpty() || getselectedRowIndex() == -1)
            {
                MessageBox.Show("The Matrix is Empty or Invalid cell selected", "Learnify - Online Courses", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                grid.Rows.RemoveAt(getselectedRowIndex());

                //Deletes on Matrix
                for (int i = 0; i < 6; i++)
                {
                    for (int j = getselectedRowIndex(); j < lastRow; j++)
                    {
                        matrix[i, j] = matrix[i, j+1];
                    }
                }
                //Empty last row
                for (int i = 0; i<6; i++)
                {
                    matrix[i,lastRow] = string.Empty;
                }

                matrixFull = false;
                lastRow--;
            }
        }
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
        public void searchItemRowIndex()
        {
            setSearchRowIndex(-1);

            for (int i =0; i<=lastRow ;i++)
            {
                if (matrix[0,i] == getId()) { setSearchRowIndex(i); }
            }
        }
        public void showSearchMatrix(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.Rows.Add();

            if (getSearchRowIndex() == -1) { MessageBox.Show("Sorry, course not found.", "Learnify - Online Courses", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    grid.Rows[0].Cells[i].Value = matrix[i, getSearchRowIndex()];
                }
            }
        }
        public void clearAllTextbox(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6)
        {
            txt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = txt6.Text = string.Empty;
        }

    }
}
