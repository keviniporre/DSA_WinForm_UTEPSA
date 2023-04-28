namespace FinalProject_DSA_UTEPSA_v1
{
    public partial class Form1 : Form
    {
        queueClass masterQueue;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                masterQueue.setId(txtId.Text);
                masterQueue.setName(txtName.Text);
                masterQueue.setInstructor(txtInstructor.Text);
                masterQueue.setCategory(txtCategory.Text);
                masterQueue.setLength(txtLength.Text);
                masterQueue.setPrice(txtPrice.Text);

                string[] container = masterQueue.createQueue();
                masterQueue.insertItem(container);
                masterQueue.showOnGrid(dtgvAll);

                masterQueue.clearTextbox(txtId);
                masterQueue.clearTextbox(txtName);
                masterQueue.clearTextbox(txtInstructor);
                masterQueue.clearTextbox(txtCategory);
                masterQueue.clearTextbox(txtLength);
                masterQueue.clearTextbox(txtPrice);

                txtId.Focus();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            masterQueue = new queueClass(Convert.ToInt16(txtRegister.Text));
            MessageBox.Show("Courses to Register: " + txtRegister.Text);
            txtId.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                masterQueue.deleteRow(dtgvAll);
        }

        private void dtgvAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            masterQueue.setSelectedIndex(e.RowIndex);
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {

                masterQueue.emptyMatrix(dtgvAll);
                txtId.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dtgvFiltered.Rows.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int rowIndex = masterQueue.rowIndexOfItem(txtId.Text);
            masterQueue.showFilteredMatrix(dtgvFiltered, rowIndex);

        }
    }
}