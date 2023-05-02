using System.Resources;

namespace FinalProject_DSA_v2
{
    public partial class Form1 : Form
    {
        //Creamos una instancia (Obj) de la clase: matrixClass
        matrixClass Obj = new matrixClass();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose1_MouseHover(object sender, EventArgs e)
        {
            btnClose1.ForeColor = Color.DarkGray;
        }

        private void btnClose1_MouseLeave(object sender, EventArgs e)
        {
            btnClose1.ForeColor = Color.Snow;
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            //Cierra el Form
            this.Close();
        }

        private void btnGetStarted_MouseHover(object sender, EventArgs e)
        {
            btnGetStarted.ForeColor = Color.DarkGray;
        }

        private void btnGetStarted_MouseLeave(object sender, EventArgs e)
        {
            btnGetStarted.ForeColor = Color.Snow;
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            //Asigna a una variable el numero de cursos ingresado por el usuario
            Obj.setNumberOfCourses(txtNumberOfCourses.Text);
            //Verifica que el numero sea mayor a cero
            if (Obj.isGreaterThanZero(txtNumberOfCourses.Text))
            {
                txtNumberOfCourses.Text = string.Empty;
                Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                form2 = null;
                Show();
            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.DarkGray;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.Snow;
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {

        }
    }
}