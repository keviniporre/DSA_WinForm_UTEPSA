namespace Learnify_Spanish
{
    public partial class Form1 : Form
    {
        //Creamos una instancia de la clase ProgramAction
        ProgramActions instanciaValores = new ProgramActions();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            //Verificamos que el numero sea mayor que cero
            if (instanciaValores.esMayorQueCero(txtNumeroDeCursos.Text))
            {
                instanciaValores.setNumeroDeCursos(txtNumeroDeCursos.Text);
                txtNumeroDeCursos.Text = string.Empty;
                Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                form2 = null;
                Show();
            }
            else
            {
                MessageBox.Show("Por favor escriba un numero valido de cursos", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumeroDeCursos.Text = string.Empty;
                txtNumeroDeCursos.Focus();
            }
        }

        private void btnCerrarF1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizarF1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarF1_MouseHover(object sender, EventArgs e)
        {
            btnCerrarF1.ForeColor = Color.Red;
        }

        private void btnCerrarF1_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarF1.ForeColor = Color.Snow;
        }

        private void btnMinimizarF1_MouseHover(object sender, EventArgs e)
        {
            btnMinimizarF1.ForeColor = Color.DarkGray;
        }

        private void btnMinimizarF1_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizarF1.ForeColor = Color.Snow;
        }
    }
}