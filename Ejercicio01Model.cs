using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace mluduena.CAI.Ej01
{
    internal class Ejercicio01Model
    {
        public long Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Ejercicio01Model() { }

        public Ejercicio01Model(int documento, string nombre, string apellido, DateTime fechaNacimiento)
        {
            Documento = documento;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public string ValidarDocumento(string par1, ref long par2)
        {
            if (string.IsNullOrEmpty(par1))
            {
                return "El documento no puede ser vacío.\n";
            }
            else if (!long.TryParse(par1, out par2))
            {
                return "El documento ingresado debe ser un número entero.\n";
            }
            else if (par2.ToString().Length > 8 || par2.ToString().Length < 7)
            {
                return "El documento ingresado debe tener 7-8 dígitos.\n";
            }
            else
            {
                return "";
            }
        }

        public string ValidarNombreApellido(string par1, string par2)
        {
            if (par1.All(Char.IsLetter) == false)
            {
                return $"El campo {par2} no puede contener números y/o símbolos.\n";
            }
            else if (string.IsNullOrEmpty(par1))
            {
                return $"El campo {par2} no puede ser vacío.\n";
            }
            else if (par1.Length > 50)
            {
                return $"El campo {par2} no puede superar los 50 caracteres.\n";
            }
            else
            {
                return "";
            }
        }

        public string ValidarFecha(string par1, ref DateTime par2)
        {
            if (string.IsNullOrEmpty(par1))
            {
                return "El campo FECHA DE NACIMIENTO no puede ser vacío.";
            }
            else if (!DateTime.TryParse(par1, out par2))
            {
                return "El campo FECHA DE NACIMIENTO debe ser una fecha";
            }
            else if (par2 > DateTime.Now)
            {
                return "La fecha de nacimiento ingresada no puede ser mayor al día de hoy";
            }
            else
            {
                return "";
            }
        }
    }
}
