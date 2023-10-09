using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using System;
using System.Windows.Forms;

namespace ProyectoEntregable.Views.Edit
{
    public partial class CreateProduct : Form
    {
        public CreateProduct()
        {
            InitializeComponent();
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Descripcion = txt_description.Text;
            producto.Costo = num_cost.Value;
            producto.PrecioVenta = num_salescost.Value;
            producto.Stock = num_stock.Value;
            producto.IdUsuario = int.Parse(txt_idUser.Text);

            ProductContext.CrearProducto(producto);
            MessageBox.Show("Se grabo Correctamente");

        }
    }
}
