using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joyeria_el_diamante.Properties;
using Joyeria_el_diamante.BLL;
using System.Data;
using System.Data.SqlClient;

namespace Joyeria_el_diamante.DAL
{
    public class PRODUCTOSDAL

    {
        private readonly DATABASE db;
        public PRODUCTOSDAL()
        {
            db = new DATABASE();
        }
        public DataTable GetAllProductos()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "Select * FROM PRODUCTOS";
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                    con.Close();
                    return dt;

                }
            }
            catch
            {
                return dt;
            }
        }
        public bool CreateProductos(PRODUCTOSBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())

                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Productos SET id_producto, nomb_producto, code_producto, precio) VALUES (@id_producto, @nom_producto, @code_producto, @precio);";
                    cmd.Parameters.AddWithValue("@id_producto", emp.Id_producto);
                    cmd.Parameters.AddWithValue("@nom_producto", emp.Nombre_producto);
                    cmd.Parameters.AddWithValue("@code_producto", emp.Codigo_producto);
                    cmd.Parameters.AddWithValue("@precio", emp.Precio);
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.GetBaseException());
                return false;
            }
        }
        public bool UpdateProductos(PRODUCTOSBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())

                {
                    Con.Open();
                    cmd.CommandText = "UPDATE Productos SET id_producto = @id_producto, codigo_producto = @code_producto,nombre_producto = @nomb_producto ,precio = @precio WHERE id_producto = @id_producto);";
                    cmd.Parameters.AddWithValue("@id_producto", emp.Id_producto);
                    cmd.Parameters.AddWithValue("@code_producto", emp.Codigo_producto);
                    cmd.Parameters.AddWithValue("@nomb_producto", emp.Nombre_producto);
                    cmd.Parameters.AddWithValue("@precio", emp.Precio);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteProductos(PRODUCTOSBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                { 
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Productos WHERE id_producto = @id_producto;";
                    cmd.CommandText = "DELETE FROM Productos WHERE id_producto = @id_producto;";
                    cmd.Parameters.AddWithValue("@id_producto", emp.Id_producto);
                    Con.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
        
    















