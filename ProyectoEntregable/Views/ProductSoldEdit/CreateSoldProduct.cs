using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEntregable.Views.ProductSoldEdit
{
    public partial class CreateSoldProduct : Form
    {
        public CreateSoldProduct()
        {
            InitializeComponent();
        }

        private void CreateSoldProduct_Load(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            ProductoVendido producto = new ProductoVendido();

            producto.IdProducto = int.Parse(txt_product.Text);
            producto.Stock = (int)num_stock.Value;
            producto.IdVenta = int.Parse(txt_idSold.Text);

            ProductoVendidoContext.CrearProductoVendido(producto);
            MessageBox.Show("Se grabo Correctamente");
        }
    }
}
