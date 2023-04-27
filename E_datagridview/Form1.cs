namespace E_datagridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n = dtgvProductos.Rows.Add();

            dtgvProductos.Rows[n].Cells[0].Value = txtId.Text;
            dtgvProductos.Rows[n].Cells[1].Value = txtName.Text;
            dtgvProductos.Rows[n].Cells[2].Value = txtInstructor.Text;
            dtgvProductos.Rows[n].Cells[3].Value = txtCategory.Text;
            dtgvProductos.Rows[n].Cells[4].Value = txtPrice.Text;

            txtId.Text = "";
            txtName.Text = "";
            txtInstructor.Text = "";
            txtCategory.Text = "";
            txtPrice.Text = "";
        }

        private void dtgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n = e.RowIndex;

            if (n != -1)
            {
                lblInformation.Text = (string)dtgvProductos.Rows[n].Cells[1].Value;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(n != -1)
            {
                dtgvProductos.Rows.RemoveAt(n);
            }
        }
    }
}