using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            txtNCita.Text =  GenerarCodigoCita(txtCliente.Text, cmbAsunto.SelectedItem.ToString(), dtpFecha.Value.ToShortDateString());
            MessageBox.Show("GUARDE ESTE CÓDIGO: " + txtNCita.Text + " " + "PARA MODIFICAR LA CITA MÁS ADELANTE");
        }
    }
}