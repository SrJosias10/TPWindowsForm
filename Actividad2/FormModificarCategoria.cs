using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Negocios;
namespace WindowsForms
{
    public partial class FormModificarCategoria : Form
    {
        public FormModificarCategoria()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormModificarCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            comboBoxCategoriaMod.DataSource = negocio.listar();
            comboBoxCategoriaMod.DisplayMember = "Descripcion";
            comboBoxCategoriaMod.Refresh();
        }
    }
}
