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

        //Declaracion Constructor
        public queueClass(int maxLength)
        {
            this.first = 0;
            this.last = -1;
            this.maxLength = maxLength;
            this.queueContainer = new string[6,maxLength];
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
                int n = grid.Rows.Add();

                for (int i = 0; i < 6; i++)
                {
                    grid.Rows[n].Cells[i].Value = this.queueContainer[i, n];
                }
            }
        }

        public void clearTextbox(TextBox box) { box.Text = ""; }
    }
}
