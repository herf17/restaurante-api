using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using MySqlConnector;

namespace ConexionSql
{
    public class Conexion
    {
        MySqlConnection con;
        public bool error { get; set; }
        public string MensjError { get; set; }
        public Conexion()
        {
            this.error = false;
            try
            {
                con = new MySqlConnection("server=localhost;user=root;password=1234;database=restaurante");
            }
            catch (Exception ex)
            {
                this.MensjError = ex.Message;
                this.error = true;
            }
        }
        public DataTable proceder(string nom, ArrayList param, ArrayList campos)
        {
            try
            {
                using (con)
                {
                    con.Open();
                    MySqlCommand cm = new MySqlCommand(nom, con);
                    cm.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < param.Count; i++)
                    {
                        cm.Parameters.AddWithValue(param[i].ToString(), campos[i].ToString());
                    }

                    MySqlDataReader reader = cm.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    return dataTable;
                }
            }
            catch (Exception exrr)
            {
                this.MensjError = exrr.Message;
                this.error = true;
                return null;
            }
        }

    }
}
