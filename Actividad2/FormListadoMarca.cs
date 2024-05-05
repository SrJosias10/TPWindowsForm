using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominios;
using Negocios;
namespace WindowsForms
{
    public partial class FormListadoMarca : Form
    {
        private List<Marca> listaMarca;
        public FormListadoMarca()
        {
            InitializeComponent();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            //toma lo que haya en el textbox de su izquierda y lo busca
        }

        private void FormListadoMarca_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            listaMarca = negocio.listar();
            dgvMarca.DataSource = listaMarca;
        }

        private void btnCancelarListaMarca_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrarMarca_Click(object sender, EventArgs e)
        {
            //Llamado ventana Eliminar Marca
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormEliminarMarca))

                    return;
            }
            FormEliminarMarca eliminarMarca = new FormEliminarMarca();
            
            eliminarMarca.ShowDialog();
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormModificarMarca))

                    return;
            }
            FormModificarMarca modificarMarca = new FormModificarMarca();
            //Muestra la ventana y no se va a cerrar hasta que se finalice de usar
            modificarMarca.ShowDialog();
        }

        private void txtBusquedaMarca_TextChanged_1(object sender, EventArgs e)
        {
            List<Marca> listaFiltrada = new List<Marca>();
            string filtro = txtBusquedaMarca.Text;
            listaFiltrada = listaMarca.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            dgvMarca.DataSource = null;
            dgvMarca.DataSource = listaFiltrada;
        }
    }
}
