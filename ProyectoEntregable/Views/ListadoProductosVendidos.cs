using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using ProyectoEntregable.Views.Edit;
using ProyectoEntregable.Views.ProductSoldEdit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoEntregable.Views
{
    public partial class ListadoProductosVendidos : Form
    {
        public ListadoProductosVendidos()
        {
            InitializeComponent();
        }
        private void CargarProductosVendidos()
        {
            List<ProductoVendido> lista = ProductoVendidoContext.ListarProductosVendidos();
            ListProducts.AutoGenerateColumns = false;
            ListProducts.DataSource = lista;
        }

        private void ListadoProductosVendidos_Load(object sender, EventArgs e)
        {
            CargarProductosVendidos();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.ListProducts.Rows[e.RowIndex].Cells["Id"].Value;
            ProductoVendido producto = ProductoVendidoContext.ListarProductosVendidos().Where(x => x.Id == Id).FirstOrDefault();


            if (this.ListProducts.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                EditSoldProduct modificar = new EditSoldProduct(producto);
                modificar.FormClosed += ListadoProductosVendidos_Load;
                modificar.ShowDialog();
            }
            else if (this.ListProducts.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DeleteSoldProduct eliminar = new DeleteSoldProduct(producto);
                eliminar.FormClosed += ListadoProductosVendidos_Load;
                eliminar.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateSoldProduct createProductSold = new CreateSoldProduct();
            createProductSold.FormClosed += ListadoProductosVendidos_Load;
            createProductSold.ShowDialog();
        }
    }
}
