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
    public partial class FormModificarArticulo : Form
    {
        private Articulo articulo = null;
        public FormModificarArticulo(Articulo art)
        {
            InitializeComponent();
            this.articulo = art;
        }

        private void FormModificarArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocioArt = new ArticuloNegocio();
            try
            {
                CategoriaNegocio negocioCat = new CategoriaNegocio();
                cbxCategoria.DataSource = negocioCat.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";
                cbxCategoria.Refresh();

                MarcaNegocio negocioMarca = new MarcaNegocio();
                cbxMarca.DataSource = negocioMarca.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxMarca.Refresh();

                tbxCodigo.Text = articulo.codigo;
                tbxNombre.Text = articulo.nombre;
                tbxDescripcion.Text = articulo.descripcion;
                tbxUrl.Text = articulo.imagen.Url;
                CargarImagen(tbxUrl.Text);
                tbxPrecio.Text = articulo.precio.ToString();
                cbxCategoria.SelectedValue = articulo.categoria.Id;
                cbxMarca.SelectedValue = articulo.marca.Id;
                


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://cdn.icon-icons.com/icons2/3001/PNG/512/default_filetype_file_empty_document_icon_187718.png");
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            ImagenNegocio ImaNegocio = new ImagenNegocio();
            try
            {
                articulo.codigo = tbxCodigo.Text;
                articulo.nombre = tbxNombre.Text;
                articulo.descripcion = tbxDescripcion.Text;
                articulo.imagen.Url = tbxUrl.Text;
                articulo.precio = int.Parse(tbxPrecio.Text);
                articulo.marca = (Marca)cbxMarca.SelectedItem;
                articulo.categoria = (Categoria)cbxCategoria.SelectedItem;

                artNegocio.modificar(articulo);
                ImaNegocio.modificar(articulo);

                Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
