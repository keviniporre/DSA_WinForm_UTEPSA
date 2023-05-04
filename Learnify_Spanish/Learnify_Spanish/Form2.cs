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

namespace Learnify_Spanish
{
    public partial class Form2 : Form
    {
        //Creamos una instancia de la clase ProgramAction
        ProgramActions Learnify = new ProgramActions();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Muestra en Label la cantidad de cursos a agregar.
            lblRegisterCourses.Text = "Listo para registrar " + ProgramValues.numeroDeCursos + " nuevos cursos";

            //Carga el icono del Form al momento de carga
            using (var ICON = Assembly.GetExecutingAssembly().GetManifestResourceStream("Learnify_Spanish.images.learnify.ico"))
            {
                if (ICON != null) { this.Icon = new Icon(ICON); }
            }
        }

        private void btnAgregarEnLibreria_Click(object sender, EventArgs e)
        {
            if (Learnify.estaAlgunTextboxVacio(txtId, txtNombre, txtInstructor, txtCategoria, txtDuracion, txtPrecio))
            {
                TextBox? textBoxVacio = Learnify.getNombreTextboxVacio(txtId, txtNombre, txtInstructor, txtCategoria, txtDuracion, txtPrecio);
                if (textBoxVacio != null) { textBoxVacio.Focus(); }
                MessageBox.Show("Por favor llene todos campos.", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Learnify.estaMatrizLlena()) { MessageBox.Show("La matriz esta llena", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    Learnify.setTodosLosValores(txtId, txtNombre, txtInstructor, txtCategoria, txtDuracion, txtPrecio);
                    Learnify.setValoresEnContenedor();
                    Learnify.insertarContenedorEnMatriz();
                    Learnify.agregarEnGridView(dtgvLibreria);
                    Learnify.limpiarTexboxes(txtId, txtNombre, txtInstructor, txtCategoria, txtDuracion, txtPrecio);
                    txtId.Focus();
                }
            }
        }

        private void btnEliminarDeLibreria_Click(object sender, EventArgs e)
        {
            if (Learnify.estaMatrizVacia() || Learnify.getIndiceFilaSeleccionada() == Learnify.ultimaFila + 1 || Learnify.getIndiceFilaSeleccionada() == -1)
            {
                MessageBox.Show("La matriz esta vacia o seleccionaste una celda invalida", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Learnify.eliminarFilaEnGridView(dtgvLibreria);
                Learnify.eliminarFilaEnMatriz();
                dtgvBusqueda.Rows.Clear();
                txtId.Focus();
            }
        }

        private void dtgvLibreria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Learnify.setIndiceFilaSeleccionada(e.RowIndex);
        }

        private void btnVaciarLibreria_Click(object sender, EventArgs e)
        {
            dtgvLibreria.Rows.Clear();
            Learnify.vaciarMatriz();
            dtgvBusqueda.Rows.Clear();
            txtId.Focus();
        }

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            dtgvBusqueda.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (Learnify.estaTextboxVacio(txtId)) { MessageBox.Show("Por favor llene el campo del ID a buscar", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                Learnify.setId(txtId);
                Learnify.buscarIndiceDelCurso();
                Learnify.mostrarEnGridView(dtgvBusqueda);
                Learnify.limpiarTexboxes(txtNombre, txtInstructor, txtCategoria, txtDuracion, txtPrecio);
                txtId.Focus();
            }
        }

        private void btnMinimizarF2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrarF2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrarF2_MouseHover(object sender, EventArgs e)
        {
            btnCerrarF2.ForeColor = Color.Red;
        }

        private void btnCerrarF2_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarF2.ForeColor = Color.Snow;
        }
    }
}
