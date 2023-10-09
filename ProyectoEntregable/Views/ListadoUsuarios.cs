using ProyectoEntregable.Context;
using ProyectoEntregable.Models;
using ProyectoEntregable.Views.Edit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProyectoEntregable.Views
{
    public partial class ListadoUsuarios : Form
    {
        public ListadoUsuarios()
        {
            InitializeComponent();
        }

        private void ListadoUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }


        private void CargarUsuarios()
        {
            List<Usuario> listaUsuarios = UsuarioContext.ListarUsuarios();
            ListUsers.AutoGenerateColumns = false;
            ListUsers.DataSource = listaUsuarios;
        }
 
        private void ListUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;

            int Id = (int)this.ListUsers.Rows[e.RowIndex].Cells["Id"].Value;
            Usuario usuario = UsuarioContext.ListarUsuarios().Where(x => x.Id == Id).FirstOrDefault();


            if (this.ListUsers.Columns[e.ColumnIndex].Name == "btnEditar")
            {
                EditeUser modificar = new EditeUser(usuario);
                modificar.FormClosed += ListadoUsuarios_Load;
                modificar.ShowDialog();
            }
            else if (this.ListUsers.Columns[e.ColumnIndex].Name == "btnEliminar")
            {
                DeleteUser eliminar = new DeleteUser(usuario);
                eliminar.FormClosed += ListadoUsuarios_Load;
                eliminar.ShowDialog();
            }
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            CreateUser createUser = new CreateUser();
            createUser.FormClosed += ListadoUsuarios_Load;
            createUser.ShowDialog();
        }
    }
}
