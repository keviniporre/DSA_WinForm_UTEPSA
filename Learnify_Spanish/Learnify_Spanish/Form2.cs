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
    }
}
