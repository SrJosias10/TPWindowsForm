using Dominios;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms 
{
    public partial class FormEliminarArticulo : Form
    {
        public FormEliminarArticulo()
        {
            InitializeComponent();
        }

        private void btnAtrasListaMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void btneliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado;
            //Baja Fisica Marca
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)comboboxArticulo.SelectedItem;
                    negocio.eliminar(seleccionado.codigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Se ha eliminado Correctamente");
        }*/
        private void btneliminarArticulo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            // Baja Fisica Marca
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    // Verifica si el SelectedItem es un objeto Articulo
                    if (comboboxArticulo.SelectedItem != null && comboboxArticulo.SelectedItem is Articulo)
                    {
                        Articulo seleccionado = (Articulo)comboboxArticulo.SelectedItem;
                        negocio.eliminar(seleccionado.codigo);
                        MessageBox.Show("Se ha eliminado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecciona un artículo válido para eliminar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar el artículo: " + ex.Message);
            }
        }

        private void comboboxArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormEliminarArticulo_Load_1(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {

                comboboxArticulo.DataSource = negocio.listarNombres();
                comboboxArticulo.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}

