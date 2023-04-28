using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FinalProject_DSA_UTEPSA_v1
{
    public class queueClass:valueClass
    {
        //Declaracion de variable/atributos
        private int first, last, maxLength;
        private string[,] queueContainer;
        private bool queueFull = false;
        public bool isLengthSet = false;

        //Declaracion Constructor
        public queueClass(int maxLength)
        {
            this.first = 0;
            this.last = -1;
            this.maxLength = maxLength;
            this.queueContainer = new string[6,maxLength];
            this.isLengthSet = true;
        }

        //Declaracion Metodos Verificadores - True/False
        public bool isQueueEmpty()
        {
            if (this.last < this.first) { return true; }
            else { return false; }
        }
        public bool isQueueFull()
        {
            if (this.last == (maxLength - 1) && (this.first == 0)) { return true; }
            else { return false; }
        }

        //Declaracion Metodos Ejecucion en Cola
        public string[] createQueue()
        {
            string[] queue = new string[6];
            queue[0] = this.getId();
            queue[1] = this.getName();
            queue[2] = this.getInstructor();
            queue[3] = this.getCategory();
            queue[4] = this.getLength();
            queue[5] = this.getPrice();
            return queue;
        }
        public void insertItem(string[] item)
        {
            if (this.isQueueFull()) 
            { 
                MessageBox.Show("The Queue is Full!");
                this.queueFull = true;
            }
            else
            {
                this.last++;
                for (int i = 0; i < 6; i++)
                {
                    this.queueContainer[i, this.last] = item[i];
                }
                MessageBox.Show("The Items were inserted to the Matrix");
            }
        }

        public void showOnGrid(DataGridView grid)
        {
            if (!this.queueFull)
            {
                grid.Rows.Add();

                for (int i = 0; i < 6; i++)
                {
                    grid.Rows[this.last].Cells[i].Value = this.queueContainer[i, this.last];
                }
            }
        }

        public void deleteRow(DataGridView grid)
        {
            if (this.getSelectedIndex() != -1) 
            { 
                grid.Rows.RemoveAt(this.getSelectedIndex()); 
                this.queueFull=false;
                this.last--;
            }
            else { MessageBox.Show("Select a Row to delete");  }
        }

        public void emptyMatrix(DataGridView grid)
        {
            this.queueFull=false;
            grid.Rows.Clear();

            //for (int i = 0; i <= this.last; i++)
            //{
            //    grid.Rows.RemoveAt(i);
            //}

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < this.last; j++)
                {
                    this.queueContainer[i,j] = "";
                }
            }
                

            this.last = -1;
        }

        public int rowIndexOfItem(string idVal)
        {
            int rowIndex = -1;
            for (int i=0; i <= this.last; i++)
            {
                if (this.queueContainer[0,i] == idVal) { rowIndex = i; }
            }
            return rowIndex;
        }

        public void showFilteredMatrix(DataGridView grid, int indexOfItem)
        {
            grid.Rows.Clear();
            grid.Rows.Add();

            if (indexOfItem != -1)
            {
                for (int i = 0; i < 6; i++)
                {
                    grid.Rows[0].Cells[i].Value = this.queueContainer[i, indexOfItem];
                }
            }
            else { MessageBox.Show("The Items is not in the matrix"); }
            
        }

        public void clearTextbox(TextBox box) { box.Text = ""; }
    }
}
