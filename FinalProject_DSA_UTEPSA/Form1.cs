using static System.Net.Mime.MediaTypeNames;

namespace FinalProject_DSA_UTEPSA
{
    public partial class Form1 : Form
    {
        queueClass queueObj = new queueClass(6);
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            queueObj.clearBoxes(txtId);
            queueObj.clearBoxes(txtName);
            queueObj.clearBoxes(txtInstructor);
            queueObj.clearBoxes(txtCategory);
            queueObj.clearBoxes(txtLength);
            queueObj.clearBoxes(txtLanguage);
            txtId.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            queueObj.showQueueItems(dataGridView1);
        }
    }
}