using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_DSA_v2
{
    public partial class Form2 : Form
    {
        //Creamos una instancia (library) de la clase: matrixClass
        matrixClass library = new matrixClass();
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
            //Llamada al metodo que elimina una fila, recibe un DataGridView como argumento.
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
            //Cierra el Form
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
            //Verifica si algun Textbox esta vacio
            if (library.isAnyTextboxEmpty(txtId, txtName, txtInstructor, txtCategory, txtLength, txtPrice))
            {
                //En caso de estar vacio algun Texbox vamos a obtener su nombre y enfocar el cursor ahi
                TextBox emptyTextbox = library.getEmptyTextboxName(txtId, txtName, txtInstructor, txtCategory, txtLength, txtPrice);
                if (emptyTextbox != null)
                {
                    emptyTextbox.Focus();
                }
                MessageBox.Show("Por favor llene todos campos.", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //En caso que ningun textbox este vacio se asignan los valores a las variables
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
            //Limpiamos el DataGridView de las busquedas
            dtgvFiltered.Rows.Clear();
        }

        private void dtgvAll_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento que asigna el valor del indice de una celda clickeada
            library.setselectedRowIndex(e.RowIndex);
        }

        private void btnEmptyLibrary_Click(object sender, EventArgs e)
        {
            //Limpia el DataGridView y la matriz donde guardamos los datos
            library.emptyMatrix(dtgvAll);
            txtId.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Verifica si el campo del ID a buscar esta vacio
            if (library.isTextboxEmpty(txtId) || library.isTextboxSpaces(txtId))
            {
                //De estar vacio manda mensaje de rellenar
                MessageBox.Show("Por favor llene el campo del ID a buscar", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //De tener un valor lo asigna, realiza la busqueda y lo muestra en el DataGridView de busqueda
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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Muestra en un Label la cantidad de cursos que se pueden agregar
            lblRegisterCourses.Text = "Listo para registrar " + valueClass.numberOfCourses + " nuevos cursos";
            //Carga el icono del Form al momento de carga
            using (var ICON = Assembly.GetExecutingAssembly().GetManifestResourceStream("FinalProject_DSA_v2.learnify.ico"))
            {
                if (ICON != null) { this.Icon = new Icon(ICON); }
            }
        }
    }
}
