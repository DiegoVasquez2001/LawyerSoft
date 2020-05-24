using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Modelo.SQL
{
    public class clsConexion
    {
        private SqlConnection sqlConexion = new SqlConnection("data source=(local);initial catalog=sys_agenda;integrated security=true");

        public void conexion_db()
        {
            try
            {
                if (sqlConexion.State == ConnectionState.Closed)
                {
                    sqlConexion.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void desconexion_db()
        {
            try
            {
                if (sqlConexion.State == ConnectionState.Open)
                {
                    sqlConexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public SqlConnection getConexion()
        {
            return sqlConexion;
        }
    }
}