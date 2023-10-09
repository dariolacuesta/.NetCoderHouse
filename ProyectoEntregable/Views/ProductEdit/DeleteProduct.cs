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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private Producto _producto;
         public DeleteProduct(Producto producto)
        {
            InitializeComponent();
            _producto = producto;
        }


        private void DeleteProduct_Load(object sender, EventArgs e)
        {
            this.Id.Text = _producto.Id.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            _producto.Id = int.Parse(Id.Text);

            ProductContext.EliminarProducto(_producto);
            MessageBox.Show("Se elimino Correctamente");
        }
    }
}
