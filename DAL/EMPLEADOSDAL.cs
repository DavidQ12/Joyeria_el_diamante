using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Joyeria_el_diamante.Properties;
using System.Data;
using Joyeria_el_diamante.BLL;

namespace Joyeria_el_diamante.DAL
{
    public class EMPLEADOSDAL
    {
        
        private DATABASE db;
        public EMPLEADOSDAL()
        {
            db = new DATABASE();

        }
        public DataTable getAllEMPLEADOS()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection con = db.getConnection();
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Empleados";
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

        public bool createEmpleados(EMPLEADOSBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "INSERT INTO Empleados (nombres, apellidos, email, Id, id_sede, telefono) VALUES  (@nom, @ap, @email, @id, @id_sede, @tel);";
                    cmd.Parameters.AddWithValue("@nom", emp.Nombres_empleados);
                    cmd.Parameters.AddWithValue("@ap", emp.Apellidos);
                    cmd.Parameters.AddWithValue("@email", emp.Email);
                    cmd.Parameters.AddWithValue("@id", emp.Id);
                    cmd.Parameters.AddWithValue("id_sede", emp.Id_sede);
                    cmd.Parameters.AddWithValue("@tel", emp.Telefono);
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

        public bool deleteEmpleados(EMPLEADOSBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "DELETE FROM Empleados WHERE id = @Id;";
                    cmd.Parameters.AddWithValue("@Id", emp.Id);
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

