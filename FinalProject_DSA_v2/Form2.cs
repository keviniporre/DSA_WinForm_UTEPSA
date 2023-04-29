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
        public Form2()
        {
            InitializeComponent();
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
    }
}
