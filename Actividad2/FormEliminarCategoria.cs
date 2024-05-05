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
    public partial class FormEliminarCategoria : Form
    {
        public FormEliminarCategoria()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void FormEliminarCategoria_Load(object sender, EventArgs e)
        {
            {
                //Funcionalidad listado combobox
                CategoriaNegocio negocio = new CategoriaNegocio();

                try
                {
                    comboxcategoria.DataSource = negocio.listar();

                    comboxcategoria.SelectedIndex = -1;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado;
            //Baja Fisica Categoria
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Categoria)comboxcategoria.SelectedItem;
                        negocio.eliminar(seleccionado.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Se ha eliminado Correctamente");
        }
    }
}
