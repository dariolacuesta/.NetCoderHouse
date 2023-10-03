using ProyectoEntregable.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyectoEntregable.Views
{
    public partial class ListadoProductos : Form
    {
        public ListadoProductos()
        {
            InitializeComponent();
        }

        private void ListadoProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

 

        private void ListProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CargarProductos()
        {
            List<Producto> lista = Context.ProductContext.ListarProductos();
            ListProducts.AutoGenerateColumns = false;
            ListProducts.DataSource = lista;
        }
    }
}
