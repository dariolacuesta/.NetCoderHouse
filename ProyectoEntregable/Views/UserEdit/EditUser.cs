using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using System;
using System.Windows.Forms;

namespace ProyectoEntregable.Views.Edit
{
    public partial class EditeUser : Form
    {
        public EditeUser()
        {
            InitializeComponent();
        }

        private Usuario _usuario;

        public EditeUser(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;
        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            _usuario.Nombre = txt_name.Text;
            _usuario.Apellido = txt_lastname.Text;
            _usuario.NombreUsuario = txt_nameUser.Text;
            _usuario.Contraseña = txt_password.Text;
            _usuario.Mail=txt_mail.Text;

            UsuarioContext.ModificarUsuario(_usuario);
            MessageBox.Show("Se elimino Correctamente");
        }

        private void EditeUser_Load(object sender, EventArgs e)
        {
          
            this.txt_name.Text = _usuario.Nombre;
            this.txt_lastname.Text = _usuario.Apellido;
            this.txt_nameUser.Text = _usuario.NombreUsuario;
            this.txt_mail.Text = _usuario.Mail;
            this.txt_password.Text = _usuario.Contraseña;

        }
    }
}
