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
    public class SEDESDAL
    {
        private DATABASE db;
        public SEDESDAL()
        {
            db = new DATABASE();
        }
        public DataTable getAllSEDES()
        {
        DataTable dt = new DataTable();
        try
        {
        SqlConnection con = db.getConnection();
        con.Open();
                using (SqlCommand cmd = con.CreateCommand())
            {
             cmd.CommandText = "SELECT * FROM  SEDES";
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
public bool createSedes(SEDESBLL emp)
{
    try
    {
        SqlConnection Con = db.getConnection();
        using (SqlCommand cmd = Con.CreateCommand())
    
        {
            Con.Open();
            cmd.CommandText = "INSERT INTO  SEDES ( id_sede, nombre_sede, ubicacion, telefono) VALUES (@id_sede, @nomb_sede, @ubi, @tel);";
            cmd.Parameters.AddWithValue("@id_sede", emp.Id_sede);
            cmd.Parameters.AddWithValue("@nomb_sede", emp.Nombre_sede);
            cmd.Parameters.AddWithValue("@ubi", emp.Ubicacion);
            cmd.Parameters.AddWithValue("@tel", emp.Telefono);
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
        public bool updateSEDES(SEDESBLL emp)
        {
            try
            {
                SqlConnection Con = db.getConnection();
                using (SqlCommand cmd = Con.CreateCommand())
                {
                    Con.Open();
                    cmd.CommandText = "Update SEDES SET id_sede = @id_sede, nombre_sede = @nom_sede, ubicacion = @ubi, telefono = @tel  WHERE id = @id);";
                    cmd.Parameters.AddWithValue("@id_sede", emp.Id_sede);
                    cmd.Parameters.AddWithValue("@nom_sede", emp.Nombre_sede);
                    cmd.Parameters.AddWithValue("@ubi", emp.Ubicacion);
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
    public bool deleteSEDES(SEDESBLL emp)
    {
        try
        {
            SqlConnection Con = db.getConnection();
            using (SqlCommand cmd = Con.CreateCommand())
            {
                Con.Open();
                cmd.CommandText = "DELETE FROM SEDES WHERE id_sede = @id_sede;";
                cmd.Parameters.AddWithValue("@id_sede", emp.Id_sede);
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
