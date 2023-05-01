using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_DSA_v2
{
    public partial class Form2 : Form
    {
        matrixClass library = new matrixClass();
        public Form2()
        {
            InitializeComponent();
            lblRegisterCourses.Text = "Ready to register " + valueClass.numberOfCourses + " new courses.";
        }

        private void btnAddToLibrary_MouseHover(object sender, EventArgs e)
        {
            btnAddToLibrary.BackColor = Color.Indigo;
        }

        private void btnAddToLibrary_MouseLeave(object sender, EventArgs e)
        {
            btnAddToLibrary.BackColor = Color.DarkSlateBlue;
        }

        private void btnDeleteFromLibrary_Click(object sender, EventArgs e)
        {
            library.deleteRow(dtgvAll);
        }

        private void btnDeleteFromLibrary_MouseHover(object sender, EventArgs e)
        {
            btnDeleteFromLibrary.BackColor = Color.Indigo;
        }

        private void btnDeleteFromLibrary_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteFromLibrary.BackColor = Color.DarkSlateBlue;
        }

        private void btnEmptyLibrary_MouseHover(object sender, EventArgs e)
        {
            btnEmptyLibrary.BackColor = Color.Indigo;
        }

        private void btnEmptyLibrary_MouseLeave(object sender, EventArgs e)
        {
            btnEmptyLibrary.BackColor = Color.DarkSlateBlue;
        }

        private void btnClearSearch_MouseHover(object sender, EventArgs e)
        {
            btnClearSearch.BackColor = Color.Indigo;
        }

        private void btnClearSearch_MouseLeave(object sender, EventArgs e)
        {
            btnClearSearch.BackColor = Color.DarkSlateBlue;
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Indigo;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.DarkSlateBlue;
        }

        private void btnMinimizeF2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose1_MouseHover(object sender, EventArgs e)
        {
            btnClose1.ForeColor = Color.DarkGray;
        }

        private void btnClose1_MouseLeave(object sender, EventArgs e)
        {
            btnClose1.ForeColor = Color.Snow;
        }

        private void btnMinimizeF2_MouseHover(object sender, EventArgs e)
        {
            btnMinimizeF2.ForeColor = Color.DarkGray;
        }

        private void btnMinimizeF2_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizeF2.ForeColor = Color.Snow;
        }

        private void btnAddToLibrary_Click(object sender, EventArgs e)
        {
            if (library.isAnyTextboxEmpty(txtId, txtName, txtInstructor, txtCategory, txtLength, txtPrice))
            {
                TextBox emptyTextbox = library.getEmptyTextboxName(txtId, txtName, txtInstructor, txtCategory, txtLength, txtPrice);
                if (emptyTextbox != null)
                {
                    emptyTextbox.Focus();
                }
                MessageBox.Show("Please fill in all fields.", "Learnify - Online Courses", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                library.setAllValues(txtId, txtName, txtInstructor, txtCategory, txtLength, txtPrice);
                library.setValuesToContainer();
                library.insertContainerToMatrix();
                library.showOnGrid(dtgvAll);
                library.clearAllTextbox(txtId, txtName, txtInstructor, txtCategory, txtLength, txtPrice);
                txtId.Focus();
            }
        }


        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            dtgvFiltered.Rows.Clear();
        }

        private void dtgvAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            library.setselectedRowIndex(e.RowIndex);
        }

        private void btnEmptyLibrary_Click(object sender, EventArgs e)
        {
            library.emptyMatrix(dtgvAll);
            txtId.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (library.isTextboxEmpty(txtId) || library.isTextboxSpaces(txtId))
            {
                MessageBox.Show("Please fill in the ID field.", "Learnify - Online Courses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                library.setId(txtId);
                library.searchItemRowIndex();
                library.showSearchMatrix(dtgvFiltered);
                library.clearAllTextbox(txtId, txtName, txtInstructor, txtCategory, txtLength, txtPrice);
                txtId.Text = library.getId();
                txtId.Focus();
            }
        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            string defaultText = " Bs.";

            // Check if the textbox already contains the default text.
            if (!txtPrice.Text.EndsWith(defaultText))
            {
                // Append the default text to the end of the textbox text.
                txtPrice.Text += defaultText;

                // Set the cursor position to the end of the textbox text.
                txtPrice.SelectionStart = txtPrice.Text.Length - 4;
                txtPrice.SelectionLength = 0;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Icon myIcon = new Icon("C:\\Users\\kevin\\OneDrive\\Pictures\\Logos\\learnify.ico");
            this.Icon = myIcon;
        }
    }
}
