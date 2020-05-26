using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelo.Objetos;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Modelo.SQL
{
    public class clsTCita:clsConexion
    {
        public bool RegistrarCita(clsCitas clsCitas)
        {
            try
            {
                conexion_db();
                SqlCommand cmd = new SqlCommand("RegistrarCita", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cita", clsCitas.IdCita);
                cmd.Parameters.AddWithValue("@fecha_cita", clsCitas.FechaCita);
                cmd.Parameters.AddWithValue("@hora_cita", clsCitas.HoraCita);
                cmd.Parameters.AddWithValue("@asunto_cita", clsCitas.AsuntoCita);
                cmd.Parameters.AddWithValue("@fk_cliente", clsCitas.FkCliente);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                desconexion_db();
            }
        }

        public bool EditarCita(clsCitas clsCitas, string antiguoID)
        {
            try
            {
                conexion_db();
                SqlCommand cmd = new SqlCommand("EditarCita", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@antiguo_id", antiguoID);
                cmd.Parameters.AddWithValue("@id_cita", clsCitas.IdCita);
                cmd.Parameters.AddWithValue("@fecha_cita", clsCitas.FechaCita);
                cmd.Parameters.AddWithValue("@hora_cita", clsCitas.HoraCita);
                cmd.Parameters.AddWithValue("@asunto_cita", clsCitas.AsuntoCita);
                cmd.Parameters.AddWithValue("@fk_cliente", clsCitas.FkCliente);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                desconexion_db();
            }
        }
    }
}