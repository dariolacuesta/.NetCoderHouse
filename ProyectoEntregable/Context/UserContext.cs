using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Constants;
using ProyectoEntregable.Models;

namespace ProyectoEntregable.Context
{
    public class UsuarioContext
    {
        static readonly string connection = ConnectionString.connString;

        public static List<Usuario> ListarUsuarios()
        {
            List<Usuario> lista = new List<Usuario>();
            string query = UserQuerys.querySelect;

            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Usuario usuario = new Usuario
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Nombre = reader["Nombre"].ToString(),
                                    Apellido = reader["Nombre"].ToString(),
                                    NombreUsuario = reader["Nombre"].ToString(),
                                    Contraseña = reader["Nombre"].ToString(),
                                    Mail = reader["Nombre"].ToString(),
                                };
                                lista.Add(usuario);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return lista;
        }

        public static Usuario ObtenerUsuario(int IdUsuario)
        {
            Usuario usuario = new Usuario();
            string query = UserQuerys.querySelectWhereId;

            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = IdUsuario });
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    usuario.Id = Convert.ToInt32(reader["Id"].ToString());
                                    usuario.Nombre = reader["Nombre"].ToString();
                                    usuario.Apellido = reader["Apellido"].ToString(); 
                                    usuario.NombreUsuario = reader["NombreUsuario"].ToString(); 
                                    usuario.Contraseña = reader["Contraseña"].ToString(); 
                                    usuario.Mail = reader["Mail"].ToString(); 
                                }
                            }
                        }
                    }
                    conexion.Close();
                }
                return usuario;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void CrearUsuario(Usuario usuario)
        {
            string query = UserQuerys.queryCreate;
            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        cmd.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        cmd.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        cmd.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        cmd.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                        cmd.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void EliminarUsuario(Usuario usuario)
        {
            string query = UserQuerys.queryDelete;

            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
                        cmd.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            var query = UserQuerys.queryModify;
            try
            {

                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = usuario.Id });
                        cmd.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        cmd.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        cmd.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        cmd.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                        cmd.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                        cmd.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
