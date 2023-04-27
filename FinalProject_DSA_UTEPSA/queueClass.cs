using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            else { }
        }
        public void clearBoxes(TextBox textBox)
        {
            textBox.Text = "";
        }

    }
}
