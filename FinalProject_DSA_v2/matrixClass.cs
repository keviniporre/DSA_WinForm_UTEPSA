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
        public matrixClass(int maxRows)
        {
            firstRow = 0;
            lastRow = -1;
            this.maxRows = maxRows;
            container = new string[6];
            matrix = new string[6, maxRows];
            matrixFull = false;
        }
        public void setAllValues(TextBox txtId, TextBox txtName, TextBox txtInstructor, TextBox txtCategory, TextBox txtLength, TextBox txtPrice)
        {
            setId(txtId.Text);
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
        public void deleteRow(DataGridView grid)
        {
            if (isMatrixEmpty() || getselectedRowIndex() == -1)
            {
                MessageBox.Show("The Matrix is Empty or Invalid cell selected");
            }
            else
            {
                grid.Rows.RemoveAt(getselectedRowIndex());
                matrixFull = false;
                lastRow--;
            }
        }
        public void showOnGrid(DataGridView grid)
        {
            if (isMatrixFull())
            {
                MessageBox.Show("The Matrix is Full", "Learnify Alert");
            }
            else
            {
                lastRow++;
                grid.Rows.Add();
                for (int i = 0;i < 6;i++)
                {
                    grid.Rows[lastRow].Cells[i].Value = container[i];
                }
            }
        }
        public void emptyMatrix(DataGridView grid)
        {
            grid.Rows.Clear();
            matrixFull = false;
            for (int i = 0; i<6;i++)
            {
                container[i] = string.Empty;
            }
            lastRow = -1;
        }
        public void clearAllTextbox(TextBox txt1, TextBox txt2, TextBox txt3, TextBox txt4, TextBox txt5, TextBox txt6)
        {
            txt1.Text = txt2.Text = txt3.Text = txt4.Text = txt5.Text = txt6.Text = string.Empty;
        }
    }
}
