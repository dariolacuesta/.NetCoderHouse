using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using System;
using System.Windows.Forms;

namespace ProyectoEntregable.Views.Edit
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private Usuario _usuario;

        public DeleteUser(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            _usuario.Id = int.Parse(Id.Text);

            UsuarioContext.EliminarUsuario(_usuario);
            MessageBox.Show("Se elimino Correctamente");
        }

        private void DeleteUser_Load(object sender, EventArgs e)
        {
            this.Id.Text = _usuario.Id.ToString();
        }
    }
}
