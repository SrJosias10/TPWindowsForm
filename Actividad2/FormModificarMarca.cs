using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
namespace WindowsForms
{
    public partial class FormModificarMarca : Form
    {
        public FormModificarMarca()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModificarMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            comboBoxMarca.DataSource = negocio.listar();
            comboBoxMarca.DisplayMember = "Descripcion";
            comboBoxMarca.Refresh();
        }
    }
}
