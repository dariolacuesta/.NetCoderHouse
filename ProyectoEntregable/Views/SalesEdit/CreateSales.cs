using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using System;
using System.Windows.Forms;

namespace ProyectoEntregable.Views.SaleView
{
    public partial class CreateSales : Form
    {
        public CreateSales()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Venta sales = new Venta();

            sales.Comentarios = txt_comentarios.ToString();
            sales.IdUsuario = int.Parse(txt_IdUser.Text);


            VentaContext.CrearVenta(sales);
            MessageBox.Show("Se creo Correctamente");
        }
    }
}
