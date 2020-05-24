using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Objetos
{
    class clsExpediente
    {
        private int numeroExpediente;

        public int NumeroExpediente
        {
            get { return numeroExpediente; }
            set { numeroExpediente = value; }
        }
        private string tipoExpediente;

        public string TipoExpediente
        {
            get { return tipoExpediente; }
            set { tipoExpediente = value; }
        }
        private string estadoExpediente;

        public string EstadoExpediente
        {
            get { return estadoExpediente; }
            set { estadoExpediente = value; }
        }
        private DateTime fechaExpediente;

        public DateTime FechaExpediente
        {
            get { return fechaExpediente; }
            set { fechaExpediente = value; }
        }
        private string dpiCliente;

        public string DpiCliente
        {
            get { return dpiCliente; }
            set { dpiCliente = value; }
        }

    }
}