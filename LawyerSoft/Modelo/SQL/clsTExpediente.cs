using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.Objetos;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Modelo.SQL
{
    class clsTExpediente : clsConexion
    {
        public bool RegistrarExpediente(clsExpediente clsExpediente)
        {
            try
            {
                conexion_db();
                SqlCommand cmd = new SqlCommand("RegistrarExpediente", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@numero_expediente", clsExpediente.NumeroExpediente);
                cmd.Parameters.AddWithValue("@tipo_expediente", clsExpediente.TipoExpediente);
                cmd.Parameters.AddWithValue("@estado_expediente", clsExpediente.EstadoExpediente);
                cmd.Parameters.AddWithValue("@fecha_expediente", clsExpediente.FechaExpediente);
                cmd.Parameters.AddWithValue("@FK_cliente", clsExpediente.DpiCliente);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                desconexion_db();
            }
        }
    }
}