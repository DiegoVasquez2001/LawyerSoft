using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo.SQL;
using Modelo.Objetos;

namespace Vista
{
    public partial class FrmCita : Form
    {
        public FrmCita()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string GenerarCodigoCita(string dpi, string asunto, string fecha)
        {
            string codigoCita = "";
            string auxDpi = ""; 
            string auxAsunto = "";
            string auxFecha = "";

            for (int i = 0; i < 4; i++)
            {
                auxDpi += dpi[i];
            }
            for (int i = 0; i < asunto.Length; i++)
            {
                if (asunto[i] != ' ')
                {
                    auxAsunto += asunto[i];
                }
            }
            for (int i = 0; i < fecha.Length; i++)
            {
                if (fecha[i] != '/')
                {
                    auxFecha += fecha[i];
                }
            }
            return codigoCita=auxDpi+auxAsunto+auxFecha;
        }

        clsCitas objCitas = new clsCitas();
        clsTCita sqlCitas = new clsTCita();

        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCliente.Text.Equals("") || cmbAsunto.Text.Equals("") || cmbHora.Text.Equals(""))
                {
                    MessageBox.Show("Hay campos vacíos, verifique por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtNCita.Text = GenerarCodigoCita(txtCliente.Text, cmbAsunto.SelectedItem.ToString(), dtpFecha.Value.ToShortDateString());
                    objCitas.IdCita = txtNCita.Text.Trim();
                    objCitas.FechaCita = dtpFecha.Value;
                    objCitas.HoraCita = cmbHora.SelectedItem.ToString();
                    objCitas.AsuntoCita = cmbAsunto.SelectedItem.ToString();
                    objCitas.FkCliente = txtCliente.Text.Trim();

                    if (sqlCitas.RegistrarCita(objCitas) == true)
                    {
                        MessageBox.Show("Cita Creada", "Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Por favor, guarde este código: " + txtNCita.Text + " " + "para poder gestionar más adelante la cita, modificarla o eliminarla", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cita No Creada", "Registros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Numero de DPI no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCliente.Text.Equals("") || cmbAsunto.Text.Equals("") || cmbHora.Text.Equals(""))
                {
                    MessageBox.Show("Hay campos vacíos, verifique por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string antiguoID = txtNCita.Text.Trim();
                    txtNCita.Text = GenerarCodigoCita(txtCliente.Text, cmbAsunto.SelectedItem.ToString(), dtpFecha.Value.ToShortDateString());
                    objCitas.IdCita = txtNCita.Text.Trim();
                    objCitas.FechaCita = dtpFecha.Value;
                    objCitas.HoraCita = cmbHora.SelectedItem.ToString();
                    objCitas.AsuntoCita = cmbAsunto.SelectedItem.ToString();
                    objCitas.FkCliente = txtCliente.Text.Trim();

                    if (sqlCitas.EditarCita(objCitas, antiguoID) == true)
                    {
                        MessageBox.Show("Cita Modificada", "Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MessageBox.Show("Por favor, guarde este código: " + txtNCita.Text + " " + "para poder gestionar más adelante la cita, modificarla o eliminarla", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cita No Modificada", "Registros", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Numero de DPI no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}