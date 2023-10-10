using Constants;
using ProyectoEntregable.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoEntregable.Context
{
    public class VentaContext
    {
        static readonly string connection = ConnectionString.connString;

        public static List<Venta> ListarVenta()
        {
            List<Venta> lista = new List<Venta>();
            string query = SalesQuerys.querySelect;

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
                                Venta venta = new Venta
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Comentarios = reader["Comentarios"].ToString(),
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"])
                                };
                                lista.Add(venta);
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

        public static Venta ObtenerVenta(int IdUsuario)
        {
            Venta venta = new Venta();
            string query = SalesQuerys.querySelectWhereId;

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
                                    venta.Id = Convert.ToInt32(reader["Id"].ToString());
                                    venta.Comentarios = reader["Comentarios"].ToString();
                                    venta.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                                }
                            }
                        }
                    }
                    conexion.Close();
                }
                return venta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void CrearVenta(Venta producto)
        {
            string query = SalesQuerys.queryCreate;
            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = producto.Comentarios });
                        cmd.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = producto.IdUsuario });

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

        public static void EliminarVenta(Venta producto)
        {
            string query = SalesQuerys.queryDelete;

            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
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

        public static void ModificarVenta(Venta venta)
        {
            var query = SalesQuerys.queryModify;
            try
            {

                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = venta.Id });
                        cmd.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        cmd.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = venta.IdUsuario });

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
