using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using ProyectoEntregable.Views.Edit;
using ProyectoEntregable.Views.SaleView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoEntregable.Views
{
    public partial class ListadoVentas : Form
    {
        public ListadoVentas()
        {
            InitializeComponent();
        }

        private void CargarVentas()
        {
            List<Venta> lista = VentaContext.ListarVenta();
            ListVentas.AutoGenerateColumns = false;
            ListVentas.DataSource = lista;
        }
        private void ListadoVentas_Load(object sender, EventArgs e)
        {
            CargarVentas();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.ListVentas.Rows[e.RowIndex].Cells["Id"].Value;
            Venta venta = VentaContext.ListarVenta().Where(x => x.Id == Id).FirstOrDefault();


            if (this.ListVentas.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                SalesEdit modificar = new SalesEdit(venta);
                modificar.FormClosed += ListadoVentas_Load;
                modificar.ShowDialog();
            }
            else if (this.ListVentas.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DeleteSales eliminar = new DeleteSales(venta);
                eliminar.FormClosed += ListadoVentas_Load;
                eliminar.ShowDialog();
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            CreateSales createSale = new CreateSales();
            createSale.FormClosed += ListadoVentas_Load;
            createSale.ShowDialog();
        }
    }
}
