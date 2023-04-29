namespace FinalProject_DSA_v2
{
    public partial class Form1 : Form
    {
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
            Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            form2 = null;
            Show();
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
            btnMinimize.ForeColor= Color.Snow;
        }
    }
}