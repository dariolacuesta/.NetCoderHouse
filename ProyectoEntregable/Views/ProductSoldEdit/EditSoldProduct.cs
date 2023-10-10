using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using System;
using System.Windows.Forms;

namespace ProyectoEntregable.Views.ProductSoldEdit
{
    public partial class EditSoldProduct : Form
    {
        public EditSoldProduct()
        {
            InitializeComponent();
        }
        private ProductoVendido _soldProduct;
        public EditSoldProduct(ProductoVendido soldProduct)
        {
            InitializeComponent();
            _soldProduct = soldProduct;
        }
        private void EditSoldProduct_Load(object sender, EventArgs e)
        {
            this.txt_product.Text = _soldProduct.IdProducto.ToString();
            this.txt_idSold.Text = _soldProduct.IdVenta.ToString();
            this.num_stock.Value = _soldProduct.Stock;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            _soldProduct.Stock = (int)num_stock.Value;
            _soldProduct.IdVenta = int.Parse(txt_idSold.Text);
            _soldProduct.IdProducto = int.Parse(txt_product.Text);

            ProductoVendidoContext.ModificarProductoVendido(_soldProduct);
            MessageBox.Show("Se grabo Correctamente");
        }
    }
}
