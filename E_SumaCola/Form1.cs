namespace E_SumaCola
{
    public partial class Form1 : Form
    {
        valueClass valuesObj = new valueClass();
        queueClass queueObj;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valuesObj.setMaxLength(int.Parse(textBox1.Text));
            queueObj = new queueClass(valuesObj.getMaxLength());
            MessageBox.Show("The Queue Max Length is now: " + valuesObj.getMaxLength());
            textBox2.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            queueObj.emptyQueue();
            queueObj.showItemsOnList(listBox1);
            queueObj.clearLabel(label5);
            textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            queueObj.deleteItem();
            queueObj.showItemsOnList(listBox1);
            queueObj.clearLabel(label5);
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            queueObj.insertItem(int.Parse(textBox2.Text));
            queueObj.showItemsOnList(listBox1);
            queueObj.clearBoxes(textBox2);
            textBox2.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            queueObj.sumOfQueue(label5);
            textBox2.Focus();
        }
    }
}