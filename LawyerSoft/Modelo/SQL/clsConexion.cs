//CLASE CLIENTE, DESARROLLADOR: Diego Vásquez
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
        //CADENA DE CONEXIÓN A BASE DE DATOS
        private SqlConnection sqlConexion = new SqlConnection("data source=(local);initial catalog=sys_agenda;integrated security=true");

        //MÉTODO conexion_db() CONECTA LA BASE DE DATOS AL SISTEMA, ES VACIO
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

        //MÉTODO desconexion_db() DESCONECTA LA BASE DE DATOS AL SISTEMA, ES VACIO
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

        //MÉTODO getConexion() OBTIENE LA CADENA DE CONEXION DE BASE DE DATOS, DE TIPO SqlConnection
        public SqlConnection getConexion()
        {
            return sqlConexion;
        }
    }
}