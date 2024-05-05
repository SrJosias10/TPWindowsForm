using Dominios;
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
    public partial class FormAgregarArticulo : Form
    {
        public FormAgregarArticulo()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            nuevo.imagen = new Imagen();
            ArticuloNegocio negocioArt = new ArticuloNegocio();
            ImagenNegocio negocioIma = new Negocios.ImagenNegocio();

            try
            {
                nuevo.nombre = textBoxNombre.Text;
                nuevo.codigo = textBoxCodigo.Text;
                nuevo.descripcion = textBoxDescripcion.Text;
                nuevo.imagen.Url = textBoxURL.Text;
                /*if (!string.IsNullOrEmpty(textBoxURL.Text))
                {
                    nuevo.imagen = new Imagen(); // Inicializa el objeto Imagen si aún no está inicializado
                    nuevo.imagen.Url = textBoxURL.Text;
                }*/
                try
                {
                   nuevo.precio = Decimal.Parse(textBoxPrecio.Text);
                }
                catch
                {

                    nuevo.precio = 0;
                }         
                nuevo.marca = (Marca)comboBoxMarca.SelectedItem;
                nuevo.categoria = (Categoria)comboBoxCat.SelectedItem;

                negocioArt.agregar(nuevo);
                nuevo.imagen.Id = negocioArt.UltimoId();
                negocioIma.agregar(nuevo.imagen);
                MessageBox.Show("agregado exitosamente");

                comboBoxMarca.SelectedIndex = -1;
                comboBoxCat.SelectedIndex = -1;
                textBoxNombre.Text = null;
                textBoxCodigo .Text = null;
                textBoxDescripcion .Text = null;
                textBoxPrecio .Text = null;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCat = new CategoriaNegocio();
            try
            {
                comboBoxMarca.DataSource = negocioMarca.listar();
                comboBoxCat.DataSource = negocioCat.listar();
                comboBoxMarca.SelectedIndex = -1;
                comboBoxCat.SelectedIndex = -1;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void comboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void textBoxURL_Leave(object sender, EventArgs e)
        {
            CargarImagen(textBoxURL.Text);
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


    }
}
