using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEntregable.Views.Edit
{
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private Producto _producto;
         public EditProduct(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
        }


        private void EditProduct_Load(object sender, EventArgs e)
        {
            this.IdUser.Text = _producto.IdUsuario.ToString();
            this.Description.Text = _producto.Descripcion;
            this.cost.Value = _producto.Costo;
            this.salesPrice.Value = _producto.PrecioVenta;
            this.stock.Value = _producto.Stock;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            _producto.Descripcion = Description.Text;
            _producto.Costo = cost.Value;
            _producto.PrecioVenta = salesPrice.Value;
            _producto.Stock = stock.Value;
            _producto.IdUsuario = int.Parse(IdUser.Text);

            ProductContext.ModificarProducto(_producto);
            MessageBox.Show("Se grabo Correctamente");
        }
    }
}
