using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo.Objetos;
using Modelo.SQL;

namespace Vista
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNCION LIMPIAR, PARA BORRAR DATA DE LOS TEXTBOX
        void Limpiar()
        {
            txtApellidos.Clear();
            txtBusqueda.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtDPI.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDPI.Focus();
        }

        //CONSTRUCTOR DE LOS OBJETOS CLIENTE Y TCLIENTE
        clsTCliente sqlCliente = new clsTCliente();
        clsCliente objCliente = new clsCliente();

        //BOTON REGISTRAR
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (txtDPI.Text.Equals("") || txtNombre.Text.Equals("") || txtApellidos.Text.Equals("") || txtTelefono.Text.Equals("") || txtCelular.Text.Equals("") || txtCorreo.Text.Equals("") || txtDireccion.Text.Equals(""))
            {
                MessageBox.Show("¡Campos Vacíos!");
            }
            else
            {
                objCliente.DpiCliente = txtDPI.Text.Trim();
                objCliente.NombreCliente = txtNombre.Text.Trim();
                objCliente.ApellidoCliente = txtApellidos.Text.Trim();
                objCliente.TelefonoCliente = txtTelefono.Text.Trim();
                objCliente.CelularCliente = txtCelular.Text.Trim();
                objCliente.CorreoCliente = txtCorreo.Text.Trim();
                objCliente.DireccionCliente = txtDireccion.Text.Trim();

                if (sqlCliente.RegistrarCliente(objCliente) == true)
                {
                    MessageBox.Show("REGISTRO REALIZADO");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("REGISTRO NO REALIZADO");
                    Limpiar();
                }
            }
        }

        //BOTON MODIFICAR
        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (txtDPI.Text.Equals("") || txtNombre.Text.Equals("") || txtApellidos.Text.Equals("") || txtTelefono.Text.Equals("") || txtCelular.Text.Equals("") || txtCorreo.Text.Equals("") || txtDireccion.Text.Equals(""))
            {
                MessageBox.Show("¡Campos Vacíos!");
            }
            else
            {
                objCliente.DpiCliente = txtDPI.Text.Trim();
                objCliente.NombreCliente = txtNombre.Text.Trim();
                objCliente.ApellidoCliente = txtApellidos.Text.Trim();
                objCliente.TelefonoCliente = txtTelefono.Text.Trim();
                objCliente.CelularCliente = txtCelular.Text.Trim();
                objCliente.CorreoCliente = txtCorreo.Text.Trim();
                objCliente.DireccionCliente = txtDireccion.Text.Trim();

                if (sqlCliente.ModificarCliente(objCliente) == true)
                {
                    MessageBox.Show("REGISTRO MODIFICADO");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("REGISTRO NO MODIFICADO");
                    Limpiar();
                }
            }
        }

        //BOTON BUSCAR
        string busqueda = "";
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            busqueda = txtBusqueda.Text;
            if (!txtBusqueda.Text.Equals(""))
            {
                sqlCliente.BuscarCliente(busqueda);
                txtDPI.Text = sqlCliente.Query_values[0];
                txtNombre.Text = sqlCliente.Query_values[1];
                txtApellidos.Text = sqlCliente.Query_values[2];
                txtTelefono.Text = sqlCliente.Query_values[3];
                txtCelular.Text = sqlCliente.Query_values[4];
                txtCorreo.Text = sqlCliente.Query_values[5];
                txtDireccion.Text = sqlCliente.Query_values[6];
                txtBusqueda.Clear();
                ReiniciarMatrizData();
            }
            else 
            {
                MessageBox.Show("CAMPO DE BUSQUEDA VACÍO");
                txtBusqueda.Clear();
            }
        }

        //FUNCION PARA REINICIAR DATA DEL ARRAY
        void ReiniciarMatrizData()
        {
            for (int i = 0; i < sqlCliente.Query_values.Length; i++)
            {
                sqlCliente.Query_values[i] = "";
            }
        }

        //BOTON ELIMINAR
        string dpiCliente = "";
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            dpiCliente = txtDPI.Text;

            if (sqlCliente.EliminarCliente(dpiCliente) == true)
            {
                MessageBox.Show("REGISTRO ELIMINADO");
                Limpiar();
            }
            else
            {
                MessageBox.Show("REGISTRO NO ELIMINADO");
                Limpiar();
            }
        }
    }
}