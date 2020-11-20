using System;
using System.Collections;
using System.Data;
using System.Linq;
using MySqlConnector;
namespace ConexionMysql
{
    public class clsConexion
    {
        MySqlConnection con;
        public string MensajeError { get; set; }
        public bool isError { get; set; }
        public clsConexion()
        {
            this.isError = false;
            try
            {
                con = new MySqlConnection("server=localhost;userid=root;password=;database=restaurante");
            }
            catch (Exception e)
            {
                this.isError = true;
                this.MensajeError = e.Message;
            }
        }

        public DataTable Ejecutar(string sp, ArrayList parametros, ArrayList valores)
        {
            try
            {
                using (con)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sp, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    for (int n = 0; n < parametros.Count; n++)
                        cmd.Parameters.AddWithValue(parametros[n].ToString(), valores[n].ToString());

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    return dt;
                }
            }
            catch (Exception e)
            {
                this.isError = true;
                this.MensajeError = e.Message;
                return null;
            }

        }
    }
}

