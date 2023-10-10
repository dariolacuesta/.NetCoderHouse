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
    public partial class DeleteSoldProduct : Form
    {
        public DeleteSoldProduct()
        {
            InitializeComponent();
        }
        private ProductoVendido _soldProduct;
        public DeleteSoldProduct(ProductoVendido soldProduct)
        {
            InitializeComponent();
            _soldProduct = soldProduct;
        }
        private void DeleteSoldProduct_Load(object sender, EventArgs e)
        {
            this.Id.Text = _soldProduct.Id.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            _soldProduct.Id = int.Parse(Id.Text);

            ProductoVendidoContext.EliminarProductoVendido(_soldProduct);
            MessageBox.Show("Se elimino Correctamente");
        }
    }
}
