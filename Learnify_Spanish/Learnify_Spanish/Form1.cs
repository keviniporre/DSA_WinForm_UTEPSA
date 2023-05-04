namespace Learnify_Spanish
{
    public partial class Form1 : Form
    {
        ProgramActions instanciaValores = new ProgramActions();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            if (instanciaValores.isGreaterThanZero(txtNumeroDeCursos.Text))
            {
                instanciaValores.setNumeroDeCursos(txtNumeroDeCursos.Text);
                txtNumeroDeCursos.Text = string.Empty;
                Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
                form2 = null;
                Show();
            }
            else { MessageBox.Show("Por favor escriba un numero valido de cursos", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}