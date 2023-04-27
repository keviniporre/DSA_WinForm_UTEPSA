using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_DSA_UTEPSA
{
    public class queueClass:valueClass
    {
        //Declaracion de variable/atributos
        private int first, last, maxLength;
        private int[] queueContainer;

        //Declaracion Constructor
        public queueClass (int maxLength)
        {
            this.first = 0;
            this.last = -1;
            this.maxLength = maxLength;
            this.queueContainer = new int[maxLength];
        }
        //Declaracion Metodos Verificadores - True/False
        public bool isQueueEmpty()
        {
            if (this.last < this.first) { return true; }
            else { return false; }
        }
        public bool isQueueFull()
        {
            if (this.last == (maxLength - 1) && (this.first == 0) ) { return true; }
            else { return false; }
        }
        //Declaracion Metodos Ejecucion en Cola
        public void insertItem(int item)
        {
            if (this.isQueueFull()) { MessageBox.Show("The Queue is Full!"); }
            else
            {
                this.last++;
                this.queueContainer[last] = item;
                MessageBox.Show("The Item was inserted to the Queue");
            }
        }
        public void deleteItem()
        {
            if (this.isQueueEmpty()) { MessageBox.Show("The Queue is Empty!"); }
            else
            {
                //Move Items position in the Queue
                for (int i = 0; i < this.last; i++) { this.queueContainer[i] = this.queueContainer[i + 1];}
                this.queueContainer[this.last] = 0;
                this.last--;
                //MessageBox Item Deleted
                MessageBox.Show("Item successfully deleted");
            }
        }
        public void emptyQueue()
        {
            if (this.isQueueEmpty()) { MessageBox.Show("The Queue is Empty!"); }
            else
            {
                //Goes through the Queue and sets to 0
                for (int i = 0; i <= this.last;i++) { this.queueContainer[i] = 0; }
                //Set default values
                this.first = 0;
                this.last = -1;
            }
        }
        //Declaracion Metodo GET de la cola
        public int[] getQueue() { return this.queueContainer; }
        //Declaracion Metodo Show de la Data
        public void showQueueItems(DataGridView grid)
        {
            //Clear/Empty the DataGridView
            grid.Rows.Clear();
            grid.Columns.Clear();


            //Verify if Queue is Empty
            if (this.isQueueEmpty()) { MessageBox.Show("The Queue is Empty!"); }
            else
            {
                //Goes through the Queue and fills the cells
                for (int i = 0; i <= this.last; ++i) { grid.}
            }
        }
        //Declaracion Metodo que limpia TextBox
        public void clearBoxes(TextBox textBox)
        {
            textBox.Text = "";
        }

    }
}
