using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using System;
using System.Windows.Forms;

namespace ProyectoEntregable.Views.SaleView
{
    public partial class SalesEdit : Form
    {
        public SalesEdit()
        {
            InitializeComponent();
        }

        private Venta _venta;
        public SalesEdit(Venta sales)
        {
            InitializeComponent();
            _venta = sales;
        }

        private void SalesEdit_Load(object sender, EventArgs e)
        {
            this.txt_IdUser.Text = _venta.Comentarios.ToString();
            this.txt_comentarios.Text = _venta.Comentarios;
        
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            _venta.Comentarios = txt_comentarios.Text;
            _venta.IdUsuario = int.Parse(txt_IdUser.Text);


            VentaContext.ModificarVenta(_venta);
            MessageBox.Show("Se edito Correctamente");
        }
    }
}
