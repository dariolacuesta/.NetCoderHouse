using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using ProyectoEntregable.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEntregable
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #region ButtonsShow

        private void btn_listProducts(object sender, EventArgs e)
        {
            ListadoProductos lstProducts  = new ListadoProductos();
           lstProducts.ShowDialog(this);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
           ListadoUsuarios lstUsers = new ListadoUsuarios();
            lstUsers.ShowDialog(this);
        }
        private void btnProductSales_Click(object sender, EventArgs e)
        {
           ListadoProductosVendidos lstProductSales = new ListadoProductosVendidos();
            lstProductSales.ShowDialog(this);
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            ListadoVentas lstSales = new ListadoVentas();
            lstSales.ShowDialog(this);
        }

        #endregion

        #region PrivateMethods
        #endregion

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
