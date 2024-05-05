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
    public partial class FormListadoCategoria : Form
    {
        private List<Categoria> listaCategorias;
        public FormListadoCategoria()
        {
            InitializeComponent();
        }

        private void btnAtrasListaCat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListadoCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            listaCategorias = negocio.listar();
            dataGridViewCategorias.DataSource = listaCategorias;
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormModificarCategoria))

                    return;
            }
            FormModificarCategoria modificarCategoria = new FormModificarCategoria();
            //Muestra la ventana y no se va a cerrar hasta que se finalice de usar
            modificarCategoria.ShowDialog();
        }

        private void btnBorrarCategoria_Click(object sender, EventArgs e)
        {
            //int indice = listadoCategorias.SelectedIndex;
            //if (indice == -1)
            //{
            //    listadoCategorias.Items.RemoveAt(indice);
            //}
            foreach(var item in Application.OpenForms)
            {
                if(item.GetType() == typeof(FormEliminarCategoria))
                {
                    return;
                }
            }
            FormEliminarCategoria formEliminarCategoria = new FormEliminarCategoria();
            formEliminarCategoria.Show();
        }

        private void txtBusquedaCategorias_TextChanged_1(object sender, EventArgs e)
        {
            List<Categoria> listaFiltrada = new List<Categoria>();
            string filtro = txtBusquedaCategorias.Text;
            listaFiltrada = listaCategorias.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            dataGridViewCategorias.DataSource = null;
            dataGridViewCategorias.DataSource = listaFiltrada;
        }
    }
}
