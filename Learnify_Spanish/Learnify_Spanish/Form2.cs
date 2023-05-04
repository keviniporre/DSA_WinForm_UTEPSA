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
                    //clear focus
                }
            }
        }

        private void btnEliminarDeLibreria_Click(object sender, EventArgs e)
        {
            Learnify.eliminarFilaEnGridView(dtgvLibreria);
            Learnify.eliminarFilaEnMatriz();
        }
    }
}
