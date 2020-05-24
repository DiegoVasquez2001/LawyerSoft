using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Objetos
{
    public class clsCliente
    {
        private string dpiCliente;

        public string DpiCliente
        {
            get { return dpiCliente; }
            set { dpiCliente = value; }
        }
        private string nombreCliente;

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        private string apellidoCliente;

        public string ApellidoCliente
        {
            get { return apellidoCliente; }
            set { apellidoCliente = value; }
        }
        private string telefonoCliente;

        public string TelefonoCliente
        {
            get { return telefonoCliente; }
            set { telefonoCliente = value; }
        }
        private string celularCliente;

        public string CelularCliente
        {
            get { return celularCliente; }
            set { celularCliente = value; }
        }
        private string correoCliente;

        public string CorreoCliente
        {
            get { return correoCliente; }
            set { correoCliente = value; }
        }
        private string direccionCliente;

        public string DireccionCliente
        {
            get { return direccionCliente; }
            set { direccionCliente = value; }
        }
    }
}