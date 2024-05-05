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
using Dominios;
namespace WindowsForms
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormAgregarArticulo))
                    return;
            }

            FormAgregarArticulo ventanaAA = new FormAgregarArticulo();
            ventanaAA.MdiParent = this;
            ventanaAA.Show();
            ventanaAA.Dock = DockStyle.Fill;
            ventanaAA.TopLevel = false;
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuListaMarca_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormListadoMarca))
                    return;
            }

            FormListadoMarca VentanaListadoMarca = new FormListadoMarca();
            VentanaListadoMarca.MdiParent = this;
            VentanaListadoMarca.Show();
            VentanaListadoMarca.Dock = DockStyle.Fill;
            VentanaListadoMarca.TopLevel = false;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormMenuArticulo menuArticulo = new FormMenuArticulo();
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(FormMenuArticulo))
                    return;
            }

           // FormMenuArticulo menuArticulo = new FormMenuArticulo();
            menuArticulo.MdiParent = this;
            menuArticulo.Show();
            menuArticulo.Dock = DockStyle.Fill;
            menuArticulo.TopLevel = false;
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormAgregarCategoria VentanaAgregarCategoria = new FormAgregarCategoria();
            VentanaAgregarCategoria.MdiParent = this;
            VentanaAgregarCategoria.Show();
            VentanaAgregarCategoria.Dock = DockStyle.Fill;
            VentanaAgregarCategoria.TopLevel = false;
        }
            private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                foreach (var item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(FormAgregarMarca))
                        return;
                }

                FormAgregarMarca VentanaAgregarMarca = new FormAgregarMarca();
                VentanaAgregarMarca.MdiParent = this;
                VentanaAgregarMarca.Show();
                VentanaAgregarMarca.Dock = DockStyle.Fill;
                VentanaAgregarMarca.TopLevel = false;
            }

            private void mostrarToolStripMenuItem2_Click(object sender, EventArgs e)
            {
                foreach (var item in Application.OpenForms)
                {
                    if (item.GetType() == typeof(FormListadoCategoria))
                        return;
                }

                FormListadoCategoria VentanaListadoCategoria = new FormListadoCategoria();
                VentanaListadoCategoria.MdiParent = this;
                VentanaListadoCategoria.Show();
                VentanaListadoCategoria.Dock = DockStyle.Fill;
                VentanaListadoCategoria.TopLevel = false;
            }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
