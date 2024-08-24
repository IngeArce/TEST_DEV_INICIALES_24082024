using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_RegistroEmpleados.Datos
{
    public class Empleado
    {
        public string Id { get; private set; }
        public string Nombre { get; private set; }
        public string ApellidoPaterno { get; private set; }
        public string ApellidoMaterno {  get; private set; }
        public double Edad {  get; private set; }

        public string Email {  get; private set; }

        public Empleado (string id, string nombre, string apellidoPaterno, string apellidoMaterno, double edad, string email)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.ApellidoPaterno = apellidoPaterno;
            this.ApellidoMaterno = apellidoMaterno;
            this.Edad = edad;
            this.Email = email;
        }
    }
}
