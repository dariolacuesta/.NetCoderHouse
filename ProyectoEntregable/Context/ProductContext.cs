using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constants;
using ProyectoEntregable.Models;

namespace ProyectoEntregable.Context
{
    public class ProductContext
    {

        static readonly string connection = ConnectionString.connString;

        public static List<Producto> ListarProductos()
        {
            List<Producto> lista = new List<Producto>();
            string query = ProductQuerys.querySelect;

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
                                Producto producto = new Producto
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Descripcion = reader["Descripcion"].ToString(),
                                    Costo = Convert.ToDecimal(reader["Costo"]),
                                    PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]),
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    IdUsuario = Convert.ToInt32(reader["IdUsuario"])
                                };
                                lista.Add(producto);
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

        public static Producto ObtenerProducto(int IdProducto)
        {
            Producto producto = new Producto();
            string query = ProductQuerys.querySelectWhereId;

            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = IdProducto });
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    producto.Id = Convert.ToInt32(reader["Id"].ToString());
                                    producto.Descripcion = reader["Descripcion"].ToString();
                                    producto.Costo = Convert.ToDecimal(reader["Costo"]);
                                    producto.PrecioVenta = Convert.ToDecimal(reader["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(reader["Stock"]);
                                    producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);
                                }
                            }
                        }
                    }
                    conexion.Close();
                }
                return producto;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void CrearProducto(Producto producto)
        {
            string query = ProductQuerys.queryCreate;
            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                        cmd.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        cmd.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        cmd.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });
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

        public static void EliminarProducto(Producto producto)
        {
            string query = ProductQuerys.queryDelete;

            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                    }
                    conexion.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void ModificarProducto(Producto producto)
        {
            var query = ProductQuerys.queryModify;
            try
            {

                using (SqlConnection conexion = new SqlConnection())
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });
                        cmd.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.VarChar) { Value = producto.Descripcion });
                        cmd.Parameters.Add(new SqlParameter("Costo", SqlDbType.Decimal) { Value = producto.Costo });
                        cmd.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Decimal) { Value = producto.PrecioVenta });
                        cmd.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });
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
    }
}
