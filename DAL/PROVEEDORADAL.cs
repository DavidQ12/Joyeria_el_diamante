using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Joyeria_el_diamante.BLL;
using System.Data;
using System.Data.SqlClient;

namespace Joyeria_el_diamante.DAL
{
    public class PROVEEDORADAL
    {
        private DATABASE db;
        public PROVEEDORADAL()
        {
            db = new DATABASE();
        }
        public DataTable getAllPROVEEDORA()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM PROVEEDORA";
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

        public bool createProveedora(PROVEEDORABLL emp)
            {
                try
                {
                    SqlConnection Con = db.getConnection();
                    using (SqlCommand cmd = Con.CreateCommand())
                    {
                        Con.Open();
                        cmd.CommandText = "INSERT INTO PROVEEDORA(id_proveedor, nombre_proveedor, producto_proveedor, nombres_repartidor, apellidos_repartidor, telefono_proveedor, direccion_proveedor) VALUES (@id_proveedor, @nom_proveedor, @producto_proveedor, @nom_repartidor, @apellidos_repartidor, @tel_repartidor, @direc_repartido);";
                        cmd.Parameters.AddWithValue("@id_proveedor", Id_proveedor);
                        cmd.Parameters.AddWithValue("@nom_proveedor", Nombre_proveedor);
                        cmd.Parameters.AddWithValue("@producto_proveedor", Producto_proveedor);
                        cmd.Parameters.AddWithValue("@nom_repartidor", Nombre_repartidor);
                        cmd.Parameters.AddWithValue("@apellidos_repartidor", Apellidos_repartidor);
                        cmd.Parameters.AddWithValue("@tel_repartidor", Telefono_repartidor);
                        cmd.Parameters.AddWithValue("@direc_repartidor", Direccion_repartidor);
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
        public bool updateProveedora(PROVEEDORABLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "UPDATE PROVEEDORA SET id_proveedor = @id_proveedor, nombre_proveedor = @nom_proveedor, productos_proveedor = @producto_proveedor, nombre_repartidor = nom_repartidor, apellidos_repartidor = @apellidos_repartidor, telefono_proveedor = @tel_proveedor, direccion_proveedor = direc_proveedor);";
                    cmd.Parameters.AddWithValue("@id_proveedor", Id_proveedor);
                    cmd.Parameters.AddWithValue("@nom_proveedor", Nombre_proveedor);
                    cmd.Parameters.AddWithValue("@producto_proveedor", Producto_proveedor);
                    cmd.Parameters.AddWithValue("@nom_repartidor", Nombre_repartidor);
                    cmd.Parameters.AddWithValue("@apellidos_repartidor", Apellidos_repartidor);
                    cmd.Parameters.AddWithValue("@tel_repartidor", Telefono_repartidor);
                    cmd.Parameters.AddWithValue("@direc_repartidor", Direccion_repartidor);
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
        public bool PROVEEDORA(PROVEEDORABLL emp)
                {
                    try
                    {
                        SqlConnection Con = db.getConnection();
                        using (SqlCommand cmd = Con.CreateCommand())
                    {
                        Con.Open();
                        cmd.CommandText = "DELETE FROM PROVEEDORA WHERE id_proveedor = id_proveedor;";
                        cmd.Parameters.AddWithValue("@id_proveedor", emp.Id_proveedor);
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

                

    

            



            
