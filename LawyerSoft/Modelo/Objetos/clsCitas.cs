using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo.Objetos
{
    public class clsCitas
    {
        private string idCita;

        public string IdCita
        {
            get { return idCita; }
            set { idCita = value; }
        }
        private DateTime fechaCita;

        public DateTime FechaCita
        {
            get { return fechaCita; }
            set { fechaCita = value; }
        }
        private string horaCita;

        public string HoraCita
        {
            get { return horaCita; }
            set { horaCita = value; }
        }
        private string asuntoCita;

        public string AsuntoCita
        {
            get { return asuntoCita; }
            set { asuntoCita = value; }
        }
        private string fkCliente;

        public string FkCliente
        {
            get { return fkCliente; }
            set { fkCliente = value; }
        }

    }
}