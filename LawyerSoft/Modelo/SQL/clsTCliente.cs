﻿//CLASE CLIENTE, DESARROLLADOR: Diego Vásquez
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo.Objetos;
using System.Data.SqlClient;
using System.Data;

namespace Modelo.SQL
{
    //HEREDA DE CLASE CONEXION
    public class clsTCliente:clsConexion
    {
        //MÉTODO BOOLEANO REGISTRAR CLIENTE, PARAMETROS ARIBUTOS DE OBJETOS/CLIENTE, DEVUELVE TRUE SI REGISTRA, FALSE SI NO REGISTRA
        public bool RegistrarCliente(clsCliente cliente)
        {
            try
            {
                conexion_db();
                SqlCommand cmd = new SqlCommand("RegistrarCliente", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dpi_cliente", cliente.DpiCliente);
                cmd.Parameters.AddWithValue("@nombre_cliente", cliente.NombreCliente);
                cmd.Parameters.AddWithValue("@apellido_cliente", cliente.ApellidoCliente);
                cmd.Parameters.AddWithValue("@telefono_cliente", cliente.TelefonoCliente);
                cmd.Parameters.AddWithValue("@celular_cliente", cliente.CelularCliente);
                cmd.Parameters.AddWithValue("@correo_cliente", cliente.CorreoCliente);
                cmd.Parameters.AddWithValue("@direccion_cliente", cliente.DireccionCliente);
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

        //MÉTODO BOOLEANO MODIFICAR CLIENTE, PARAMETROS ARIBUTOS DE OBJETOS/CLIENTE, DEVUELVE TRUE SI MODIFICA, FALSE SI NO MODIFICA
        public bool ModificarCliente(clsCliente cliente)
        {
            try
            {
                conexion_db();
                SqlCommand cmd = new SqlCommand("EditarCliente", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dpi_cliente", cliente.DpiCliente);
                cmd.Parameters.AddWithValue("@nombre_cliente", cliente.NombreCliente);
                cmd.Parameters.AddWithValue("@apellido_cliente", cliente.ApellidoCliente);
                cmd.Parameters.AddWithValue("@telefono_cliente", cliente.TelefonoCliente);
                cmd.Parameters.AddWithValue("@celular_cliente", cliente.CelularCliente);
                cmd.Parameters.AddWithValue("@correo_cliente", cliente.CorreoCliente);
                cmd.Parameters.AddWithValue("@direccion_cliente", cliente.DireccionCliente);
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

        //VECTOR PARA DEVOLVER DATA
        private string[] query_values = new string[7];

        public string[] Query_values
        {
            get { return query_values; }
            set { query_values = value; }
        }

        //MÉTODO VACIO BUSCAR CLIENTE, PARAMETROS ARIBUTOS dpiCliente, DEVUELVE INFORMACION DE LA TABLA

        public void BuscarCliente(string dpiCliente)
        {
            try
            {
                conexion_db();
                SqlCommand cmd = new SqlCommand("BuscarCliente", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dpi_cliente", dpiCliente);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    query_values[0] = reader["dpi_cliente"].ToString();
                    query_values[1] = reader["nombre_cliente"].ToString();
                    query_values[2] = reader["apellido_cliente"].ToString();
                    query_values[3] = reader["telefono_cliente"].ToString();
                    query_values[4] = reader["celular_cliente"].ToString();
                    query_values[5] = reader["correo_cliente"].ToString();
                    query_values[6] = reader["direccion_cliente"].ToString();
                }
                else
                {
                    MessageBox.Show("REGISTRO NO EXISTENTE");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                desconexion_db();
            }
        }

        //MÉTODO BOOLEANO ELIMINAR CLIENTE, PARAMETRO dpiCliente, DEVUELVE TRUE SI ELIMINA, FALSE SI NO ELIMINA
        public bool EliminarCliente(string dpiCliente)
        {
            try
            {
                conexion_db();
                SqlCommand cmd = new SqlCommand("EliminarCliente", getConexion());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dpi_cliente", dpiCliente);
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