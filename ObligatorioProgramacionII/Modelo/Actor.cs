using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioProgramacion.model{

    public class Actor{
        public int NroActor { get; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public string Nacionalidad { get; set; }

        public Actor(){

        }

        public Actor(int nroActor, string nombre, string apellido, DateTime fechaDeNacimiento, string nacionalidad){

            Nombre = nombre;
            Apellido = apellido;
            FechaDeNacimiento = fechaDeNacimiento;
            Nacionalidad = nacionalidad;
            NroActor = nroActor;
        }
    }
}
