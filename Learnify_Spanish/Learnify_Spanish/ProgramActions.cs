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
            //Vacia o asigna a ceros el valor de la ultima fila de la matriz
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
    }
}
