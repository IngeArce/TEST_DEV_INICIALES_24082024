﻿using Practica_RegistroEmpleados.Datos;
using Practica_RegistroEmpleados.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_RegistroEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EmpleadoRepositorio.InicializarRepositorio();
            VisualizarEmpleados();
        }

        private void VisualizarEmpleados()
        {
            dataGridView1.Rows.Clear();
            foreach (Empleado empleado in EmpleadoRepositorio.Empleados)
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = empleado.Id.ToString();
                dataGridView1.Rows[rowIndex].Cells[1].Value = empleado.Nombre.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = empleado.ApellidoPaterno.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = empleado.ApellidoMaterno.ToString();
                dataGridView1.Rows[rowIndex].Cells[4].Value = empleado.Edad.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = empleado.Email.ToString();
            }
        }
        private void pcbAñadir_Click(object sender, EventArgs e)
        {
            EmpleadoForm empleadoForm = new EmpleadoForm();
            DialogResult dialogResult = empleadoForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                EmpleadoRepositorio.AñadirEmpleado(empleadoForm.Empleado);
                VisualizarEmpleados();
            }
        }

        private void pcbEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                string idEmpleadoEliminar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                EmpleadoRepositorio.EliminarEmpleado(idEmpleadoEliminar);
                VisualizarEmpleados();
            }
            else
            {
                MessageBox.Show("No has seleccionado ningún empleado","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pcbModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) {
                string idEmpleadoModificar = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nombreEmpleadoModificar = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string apellidoPaternoEmpleadoModificar = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string apellidoMaternoEmpleadoModificar = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                double edadEmpleadoModificar = Convert.ToDouble(dataGridView1.SelectedRows[0].Cells[4].Value);
                string emailEmpleadoModificar = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                Empleado empleadoModificar = new Empleado(idEmpleadoModificar, nombreEmpleadoModificar, apellidoPaternoEmpleadoModificar, apellidoMaternoEmpleadoModificar, edadEmpleadoModificar, emailEmpleadoModificar);
                EmpleadoForm empleadoForm = new EmpleadoForm(empleadoModificar);
                DialogResult dialogResult = empleadoForm.ShowDialog();
                if(dialogResult == DialogResult.OK)
                {
                    EmpleadoRepositorio.ActualizarEmpleado(idEmpleadoModificar, empleadoForm.Empleado);
                    VisualizarEmpleados();
                }

            }
            else
            {
                MessageBox.Show("No has seleccionado ningun empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
