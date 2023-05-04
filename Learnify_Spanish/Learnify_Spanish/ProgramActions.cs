using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learnify_Spanish
{
    public class ProgramActions:ProgramValues
    {
        public void setTodosLosValores(TextBox tbId, TextBox tbNombre, TextBox tbInstructor, TextBox tbCategoria, TextBox tbDuracion, TextBox tbPrecio)
        {
            setId(tbId);
            setNombre(tbNombre.Text);
            setInstructor(tbInstructor.Text);
            setCategoria(tbCategoria.Text);
            setDuracion(tbDuracion.Text);
            setPrecio(tbPrecio.Text);
        }
        public void setValoresEnContenedor()
        {
            contenedor[0] = getId();
            contenedor[1] = getNombre();
            contenedor[2] = getInstructor();
            contenedor[3] = getCategoria();
            contenedor[4] = getDuracion();
            contenedor[5] = getPrecio();
        }
        public bool estaMatrizVacia()
        {
            if (ultimaFila < primerFila) { return true; }
            else { return false; }
        }
        public bool estaMatrizLlena()
        {
            if (ultimaFila == maximoDeFilas -1) { return true; } 
            else { return false; }
        }

        public void insertarContenedorEnMatriz()
        {
            ultimaFila++;
            for (int i = 0; i < cantidadColumnas; i++)
            {
                matriz[i, ultimaFila] = contenedor[i];
            }
        }

        public void eliminarFilaEnGridView(DataGridView gridView)
        {
            gridView.Rows.RemoveAt(getIndiceFilaSeleccionada());
        }
        public void eliminarFilaEnMatriz()
        {
            for (int i = 0; i < cantidadColumnas; i++)
            {
                for (int j = getIndiceFilaSeleccionada() ; j < ultimaFila ; j++)
                {
                    matriz[i, j] = matriz[i, j + 1];
                }
            }
            //Vacia los valores de la ultima fila de la matriz
            for (int i = 0; i < cantidadColumnas ; i++)
            {
                matriz[i, ultimaFila] = string.Empty;
            }
            ultimaFila--;
        }
        public void agregarEnGridView(DataGridView gridView)
        {
            gridView.Rows.Add();
            for (int i = 0; i < cantidadColumnas; i++)
            {
                gridView.Rows[ultimaFila].Cells[i].Value = matriz[i, ultimaFila];
            }
        }
        public void limpiarTexboxes(params TextBox[] textboxes)
        {
            foreach (var textbox in textboxes)
            {
                textbox.Text = string.Empty;
            }
        }
        public void vaciarMatriz()
        {
            for (int i = 0; i < cantidadColumnas; i++)
            {
                for (int j = 0; j <= ultimaFila; j++)
                {
                    matriz[i, j] = string.Empty;
                }
            }
            ultimaFila = -1;
        }
        public void buscarIndiceDelCurso()
        {
            setIndiceFilaBuscar(-1);

            for (int i = 0; i <= ultimaFila; i++)
            {
                if (matriz[0, i] == getId()) { setIndiceFilaBuscar(i); }
            }
        }
        public void mostrarEnGridView(DataGridView gridView)
        {
            gridView.Rows.Clear();
            gridView.Rows.Add();

            if (getIndiceFilaBuscar() == -1) { MessageBox.Show("Lo siento, ese ID de curso no existe", "Learnify - Cursos Online", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            else
            {
                for (int i = 0; i < cantidadColumnas; i++)
                {
                    gridView.Rows[0].Cells[i].Value = matriz[i, getIndiceFilaBuscar()];
                }
            }
        }
    }
}
