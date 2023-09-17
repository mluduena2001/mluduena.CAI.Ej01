using System;
using System.IO.Pipes;
using System.Linq;
using mluduena.CAI.Ej01;




namespace mluduena.CAI.Ej01
{
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ejercicio01Model validar = new Ejercicio01Model();

            string documento = txtDocumento.Text; long documentoOut = 0; string nombre = txtNombre.Text;
            string apellido = txtApellido.Text; string fechaNac = txtFechaNac.Text; DateTime fechaNacOut = DateTime.Now;
            bool flag = false; string acumuladorErrores = "";

            acumuladorErrores = acumuladorErrores + validar.ValidarDocumento(documento, ref documentoOut);
            acumuladorErrores = acumuladorErrores + validar.ValidarNombreApellido(nombre, "NOMBRE");
            acumuladorErrores = acumuladorErrores + validar.ValidarNombreApellido(apellido, "APELLIDO");
            acumuladorErrores = acumuladorErrores + validar.ValidarFecha(fechaNac, ref fechaNacOut);

            if (!string.IsNullOrEmpty(acumuladorErrores))
            {
                MessageBox.Show(acumuladorErrores);
            }
            else
            {
                Ejercicio01Model persona = new Ejercicio01Model();
                persona.Documento = documentoOut;
                persona.Nombre = nombre;
                persona.Apellido = apellido;
                persona.FechaNacimiento = fechaNacOut;

                lstDatos.Items.Add(persona.Documento);
                lstDatos.Items.Add(persona.Nombre);
                lstDatos.Items.Add(persona.Apellido);
                lstDatos.Items.Add(persona.FechaNacimiento);
            }
        }

        /*
        private string ValidarDocumento(string par1, ref int par2)
        {
            if (string.IsNullOrEmpty(par1))
            {
                return "El documento no puede ser vacío.\n";
            }
            else if (!int.TryParse(par1, out par2))
            {
                return "El documento ingresado debe ser un número entero.\n";
            }
            else if (par2.ToString().Length != 7 && par2.ToString().Length != 8)
            {
                return "El documento ingresado debe tener 7-8 dígitos.\n";
            }
            else
            {
                return "";
            }
        }

        private string ValidarNombreApellido(string par1, string par2)
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

        private string ValidarFecha(string par1, ref DateTime par2)
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
        }*/

    }
}