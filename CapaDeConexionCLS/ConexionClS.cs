using System;
using System.Collections;
using System.Data;
using MySqlConnector;

namespace CapaDeConexionCLS
{

    public class ConexionClS
    {
        MySqlConnection con;

        public string mensajeError { get; set; }
        public bool isError { get; set; }


        public ConexionClS()
        {
            this.isError = false;

            try
            {
                con = new MySqlConnection("server=localhost;userid=root;password=;database=restaurante");
            }
            catch (Exception e)
            {
                this.isError = true;
                this.mensajeError = e.Message;
            }
        }

        public DataTable Ejecutar(string sp, ArrayList parametros, ArrayList valor)
        {
            try
            {
                using (con)
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(sp, con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    for (int n = 0; n < parametros.Count; n++)
                    {
                        cmd.Parameters.AddWithValue(parametros[n].ToString(), valor[n].ToString());
                    }

                    MySqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    return dt;

                }

            }
            catch (Exception e)
            {
                this.isError = true;
                this.mensajeError = e.Message;

                return null;
            }
        }
    }
}




