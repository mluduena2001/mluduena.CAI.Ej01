using System;
using System.Linq;

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
            string documento = txtDocumento.Text; int documentoOut = 0; string nombre = txtNombre.Text;
            string apellido = txtApellido.Text; string fechaNac = txtFechaNac.Text; DateTime fechaNacOut = DateTime.Now;
            bool flag = false; string acumuladorErrores = "";

            acumuladorErrores = acumuladorErrores + ValidarDocumento(documento, ref documentoOut);
            acumuladorErrores = acumuladorErrores + ValidarNombreApellido(nombre, "NOMBRE");
            acumuladorErrores = acumuladorErrores + ValidarNombreApellido(apellido, "APELLIDO");
            acumuladorErrores = acumuladorErrores + ValidarFecha(fechaNac, ref fechaNacOut);

            if (!string.IsNullOrEmpty(acumuladorErrores))
            {
                MessageBox.Show(acumuladorErrores);
            }
            else
            {
                lstDatos.Items.Add(documentoOut);
                lstDatos.Items.Add(nombre);
                lstDatos.Items.Add(apellido);
                lstDatos.Items.Add(fechaNacOut);
            }
        }

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
        }

    }
}