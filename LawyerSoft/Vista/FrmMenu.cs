using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Resources;


namespace Vista
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            timerControl.Enabled = true;
        }
        void Tiempo()
        {
            labelDate.Text = DateTime.Now.ToShortDateString();
            labelHour.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void timerControl_Tick(object sender, EventArgs e)
        {
            Tiempo();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            Formularios(frmCliente);
        }

        void Formularios(Form formulario)
        {
            panelDesktop.Controls.Clear();
            formulario.TopLevel = false;
            formulario.WindowState = FormWindowState.Maximized;
            panelDesktop.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
