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
    public partial class FormEliminarMarca : Form
    {
        public FormEliminarMarca()
        {
            InitializeComponent();
        }
        private void FormEliminarMarca_Load(object sender, EventArgs e)
        {
            {
                //Funcionalidad listado combobox
                MarcaNegocio negocio = new MarcaNegocio();

                try
                {
                    comboboxMarca.DataSource = negocio.listar();

                    comboboxMarca.SelectedIndex = -1;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado;
            //Baja Fisica Marca
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Marca)comboboxMarca.SelectedItem;
                    negocio.eliminar(seleccionado.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Se ha eliminado Correctamente");
        }

        private void btnAtrasListaMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
