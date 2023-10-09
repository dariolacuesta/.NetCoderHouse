using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using System;
using System.Windows.Forms;

namespace ProyectoEntregable.Views.SaleView
{
    public partial class DeleteSales : Form
    {
        public DeleteSales()
        {
            InitializeComponent();
        }

        private Venta _sales;
        public DeleteSales(Venta sales)
        {
            InitializeComponent();
            _sales = sales;
        }


        private void DeleteSales_Load(object sender, EventArgs e)
        {
            this.Id.Text = _sales.Id.ToString();
        }


    
        private void btn_save_Click_1(object sender, EventArgs e)
        {
            _sales.Id = int.Parse(Id.Text);

            VentaContext.EliminarVenta(_sales);
            MessageBox.Show("Se elimino Correctamente");
        }
    }
}
