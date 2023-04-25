namespace E6_Temperature_Converter
{
    public partial class Form1 : Form
    {
        converterClass converter = new converterClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Set valores
            converter.setValue(double.Parse(textBox1.Text));

            //Asignar respuesta a labels
            label6.Text = Convert.ToString(converter.ToFahrenheit());
            label7.Text = Convert.ToString(converter.ToKelvin());
            label8.Text = Convert.ToString(converter.ToRankine());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label6.Text = "0";
            label7.Text = "0";
            label8.Text = "0";
            textBox1.Focus();
        }
    }
}