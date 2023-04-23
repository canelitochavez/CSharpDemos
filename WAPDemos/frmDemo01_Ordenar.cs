using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WAPDemos.Entities;

namespace WAPDemos
{
    public partial class frmDemo01_Ordenar : Form
    {
        public frmDemo01_Ordenar()
        {
            InitializeComponent();
        }

        ArrayList empleados;

        private ArrayList obtenerEmpleados()
        {
            empleados = new ArrayList()
            {
                new Empleado()
                {
                    Nombre="Juan",
                    Apellidos="Rojas",
                    SueldoDiario=23544.00m,
                    FechaIngreso= new DateTime(2011,02,03)
                },
                new Empleado()
                {
                    Nombre="Paola",
                    Apellidos="Rojas",
                    SueldoDiario=23544.00m,
                    FechaIngreso=new DateTime(2003,02,03)
                },
                new Empleado()
                {
                    Nombre="Luis",
                    Apellidos="Peralta",
                    SueldoDiario=23544.00m,
                    FechaIngreso=new DateTime(2005,02,03)
                }
            };
            return empleados;
        }

        private void btnLlenar_Click(object sender, EventArgs e)
        {
            this.obtenerEmpleados();
            lstEmpleados.DataSource = empleados;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstEmpleados.DataSource = null;
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (empleados != null)
            {
                empleados.Sort();
                this.btnLimpiar_Click(this, null);
                lstEmpleados.DataSource = empleados;
            }
            else
            {
                MessageBox.Show("Lista Vacía...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
