using Practica_RegistroEmpleados.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_RegistroEmpleados.Formularios
{
    public partial class EmpleadoForm : Form
    {
        public Empleado Empleado { get; private set; }
        public EmpleadoForm()
        {
            InitializeComponent();
        }

        public EmpleadoForm(Empleado Empleado)
        {
            InitializeComponent();
            tbxIdEmpleado.Text = Empleado.Id;
            tbxNombre.Text = Empleado.Nombre;
            tbxApellidoPaterno.Text = Empleado.ApellidoPaterno;
            tbxApelliidoMaterno.Text = Empleado.ApellidoMaterno;
            tbxEdad.Text = Empleado.Edad.ToString();
            tbxEmail.Text = Empleado.Email;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool empleadoValidado = ValidarEmpleado(out String errorMsg);
            if (empleadoValidado)
            {
                Empleado = new Empleado(tbxIdEmpleado.Text, tbxNombre.Text, tbxApellidoPaterno.Text, tbxApelliidoMaterno.Text, Convert.ToDouble(tbxEdad.Text), tbxEmail.Text);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
            }
        }
        private bool ValidarEmpleado(out String errorMsg)
        {
            errorMsg = String.Empty;
            if (string.IsNullOrEmpty(tbxIdEmpleado.Text))
            {
                errorMsg += "El ID del empleado no puede estar vacio." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxNombre.Text))
            {
                errorMsg += "El ID del empleado no puede estar vacio." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxApellidoPaterno.Text))
            {
                errorMsg += "El ID del empleado no puede estar vacio." + Environment.NewLine;
            }
            if (string.IsNullOrEmpty(tbxApelliidoMaterno.Text))
            {
                errorMsg += "El ID del empleado no puede estar vacio." + Environment.NewLine;
            }
            bool edadOK = double.TryParse(tbxEdad.Text, out double edad);
            if (edadOK)
            {
                if (edad < 18)
                {
                    errorMsg += "La edad del empleado debe ser superior a 18 años " + Environment.NewLine;
                }
            }
            else
            {
                errorMsg += "La edad del empleado debde ser un número válido. " + Environment.NewLine;
            }
            try
            {
                new MailAddress(tbxEmail.Text);
            }
            catch (Exception ex)
            {
                errorMsg += "El e-mail debe tener un formato correcto. " + Environment.NewLine;
            }
            return errorMsg == string.Empty;
        }
    }
}
