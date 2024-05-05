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
    public partial class FormAgregarMarca : Form
    {
        public FormAgregarMarca()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAgregarMarca_Load(object sender, EventArgs e)
        {

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Marca nuevo = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                nuevo.Descripcion = textBoxDescripcion.Text;

                negocio.agregar(nuevo);
                MessageBox.Show("agregado exitosamente");

                textBoxDescripcion.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
