using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Joyeria_el_diamante.Properties;
using Joyeria_el_diamante.BLL;
using System.Data;

namespace Joyeria_el_diamante.DAL
{
    public class COMPRASDAL
    {
        private readonly DATABASE db;
        public COMPRASDAL()
        {
            db = new DATABASE();
        }
        public DataTable getAllCOMPRAS()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                        cmd.CommandText = "SELECT * FROM COMPRAS";
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
        public bool CreateCOMPRAS(COMPRASBLL emp)
        CreateCOMPRAS(COMPRASBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO COMPRAS(id_compra, id_producto, codigo_producto, precio, id_proveedor) VALUES (@id_compra, @id_producto, @code_producto, @precio, @id_proveedo);";
                    cmd.Parameters.AddWithValue("id_compra", emp.Id_compra);
                    cmd.Parameters.AddWithValue("@id_producto", emp.Id_Producto);
                    cmd.Parameters.AddWithValue("@code_producto", emp.Codigo_producto);
                    cmd.Parameters.AddWithValue("@precio", emp.Precio);
                    cmd.Parameters.AddWithValue("@id_proveedor", emp.Id_proveedor);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    return true;
                }
            }
            catch (Exception e)
            { 
             Console.WriteLine("ERROR: " + e.GetBaseException());
                return false;
            
                Console.WriteLine("ERROR: " + e.GetBaseException());
                return false;
                return false;
            }
        }
        public bool updateCOMPRAS(COMPRASBLL emp)
            {
                try
                {
                    SqlConnection Con = db.getConnection();
                    using (SqlCommand cmd = Con.CreateCommand())
                    {

                        Con.Open();
                        cmd.CommandText = "UPDATE COMPRAS SET id_compra = @id_compra, id_producto = @id_producto, codigo_producto = @code_producto, precio = @precio, id_proveedor = @id_proveedor WHERE id_compras = @id_compras);";
                        cmd.Parameters.AddWithValue("@id_compra", Id_compra);
                        cmd.Parameters.AddWithValue("@code_producto", Codigo_producto);
                        cmd.Parameters.AddWithValue("@precio", Precio);
                        cmd.Parameters.AddWithValue("@id_proveedor", Id_proveedor);
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
            public bool deleteCOMPRAS(COMPRASBLL emp)
            {
                try
                {
                    SqlConnection Con = db.getConnection();
                    using (SqlCommand cmd = Con.CreateCommand())
                    {
                        Con.Open();
                        cmd.CommandText = "DELETE FROM COMPRAS WHERE id_compra = @id_compra;";
                    cmd.Parameters.AddWithValue("@id_compra", emp.id_compra);
                        
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
                }
}