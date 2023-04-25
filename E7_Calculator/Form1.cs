namespace E7_Calculator
{
    public partial class Form1 : Form
    {
        calculatorClass calculate = new calculatorClass();
        public Form1()
        {
            InitializeComponent();
        }
        public void setValues()
        {
            calculate.setValueN1(double.Parse(textBox1.Text));
            calculate.setValueN2(double.Parse(textBox2.Text));
        }
        public bool isN1biggerThanN2()
        {
            if (calculate.getValueN1() > calculate.getValueN2()) { return true; }
            else { return false; }
        }
        public void setLabelToNotBigger()
        {
            label6.Text = "N1 is NOT bigger than N2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setValues();
            if (isN1biggerThanN2()) { label6.Text = Convert.ToString(calculate.addition()); }
            else { setLabelToNotBigger(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            setValues();
            if (isN1biggerThanN2()) { label6.Text = Convert.ToString(calculate.subtraction()); }
            else { setLabelToNotBigger(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            setValues();
            if (isN1biggerThanN2()) { label6.Text = Convert.ToString(calculate.multiplication()); }
            else { setLabelToNotBigger(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setValues();
            if (isN1biggerThanN2()) { label6.Text = Convert.ToString(calculate.division()); }
            else { setLabelToNotBigger(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label6.Text = "0";
            textBox1.Focus();
        }
    }
}