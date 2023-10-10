using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using ProyectoEntregable.Views.Edit;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

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
        private void CargarProductos()
        {
            List<Producto> lista = ProductContext.ListarProductos();
            ListProducts.AutoGenerateColumns = false;
            ListProducts.DataSource = lista;
        }

        private void ListProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.ListProducts.Rows[e.RowIndex].Cells["Id"].Value;
            Producto producto = ProductContext.ListarProductos().Where(x => x.Id == Id).FirstOrDefault();


            if (this.ListProducts.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                EditProduct modificar = new EditProduct(producto);
                modificar.FormClosed += ListadoProductos_Load;
                modificar.ShowDialog();
            }
            else if (this.ListProducts.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DeleteProduct eliminar = new DeleteProduct(producto);
                eliminar.FormClosed += ListadoProductos_Load;
                eliminar.ShowDialog();
            }
        }

        private void createProduct_Click(object sender, EventArgs e)
        {
            CreateProduct createProduct = new CreateProduct();
            createProduct.FormClosed += ListadoProductos_Load;
            createProduct.ShowDialog();
        }
    }
}
