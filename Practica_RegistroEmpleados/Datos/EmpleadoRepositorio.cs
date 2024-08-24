using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_RegistroEmpleados.Datos
{
    public class EmpleadoRepositorio
    {
        private const string RUTA_FICHERO_EMPLEADOS = @"C:\tmp\archivo.json";

        public static List<Empleado> Empleados {  get; private set; }
        //funciones 
        public static void InicializarRepositorio()
        {
            if (File.Exists(RUTA_FICHERO_EMPLEADOS))
            {
                string json = File.ReadAllText(RUTA_FICHERO_EMPLEADOS);
                Empleados = JsonConvert.DeserializeObject<List<Empleado>>(json);
            }
            else
            {
                Empleados = new List<Empleado>();
            }
            
        }

        public static void AñadirEmpleado(Empleado empleado)
        {
            Empleados.Add(empleado);
            string json = JsonConvert.SerializeObject(Empleados, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_EMPLEADOS,json);
        }
        public static void EliminarEmpleado(string id)
        {
            Empleados.RemoveAll(e => e.Id.Equals(id));
            string json = JsonConvert.SerializeObject(Empleados, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_EMPLEADOS, json);
        }
        public static void ActualizarEmpleado(string idEmpleadoOrigen, Empleado empleadoModificado)
        {
            int indiceEmpleadoOriginal = Empleados.FindIndex(e => e.Id == idEmpleadoOrigen);
            if(indiceEmpleadoOriginal != -1)
            {
                Empleados[indiceEmpleadoOriginal] = empleadoModificado;
            }
            string json = JsonConvert.SerializeObject(Empleados, Formatting.Indented);
            File.WriteAllText(RUTA_FICHERO_EMPLEADOS, json);
        }

    }
}
