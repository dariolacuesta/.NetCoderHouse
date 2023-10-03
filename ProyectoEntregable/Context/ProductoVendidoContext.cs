using Constants;
using ProyectoEntregable.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEntregable.Context
{
    public class ProductoVendidoContext
    {
        static readonly string connection = ConnectionString.connString;

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            List<ProductoVendido> lista = new List<ProductoVendido>();
            string query = ProductSalesQuerys.querySelect;

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
                                ProductoVendido producto = new ProductoVendido
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    IdProducto = Convert.ToInt32(reader["Id"]),          
                                    Stock = Convert.ToInt32(reader["Stock"]),
                                    IdVenta = Convert.ToInt32(reader["IdVenta"])
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

        public static ProductoVendido ObtenerProductoVendido(int IdProducto)
        {
            ProductoVendido producto = new ProductoVendido();
            string query = ProductSalesQuerys.querySelectWhereId;

            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("IdProductoVendido", SqlDbType.Int) { Value = IdProducto });
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    producto.Id = Convert.ToInt32(reader["Id"].ToString());
                                    producto.IdProducto = Convert.ToInt32(reader["IdProducto"]);       
                                    producto.Stock = Convert.ToInt32(reader["Stock"]);
                                    producto.IdVenta = Convert.ToInt32(reader["IdVenta"]);

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

        public static void CrearProductoVendido(ProductoVendido producto)
        {
            string query = ProductSalesQuerys.queryCreate;
            try
            {
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.VarChar) { Value = producto.IdProducto });
                        cmd.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });
                        cmd.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = producto.IdVenta });

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

        public static void EliminarProductoVendido(ProductoVendido producto)
        {
            string query = ProductSalesQuerys.queryDelete;

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

        public static void ModificarProductoVendido(ProductoVendido producto)
        {
            var query = ProductSalesQuerys.queryModify;
            try
            {

                using (SqlConnection conexion = new SqlConnection())
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.Add(new SqlParameter("Id", SqlDbType.VarChar) { Value = producto.Id });
                        cmd.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = producto.IdProducto });
                        cmd.Parameters.Add(new SqlParameter("Stock", SqlDbType.Decimal) { Value = producto.Stock });
                        cmd.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = producto.IdVenta });

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
