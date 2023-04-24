using System;
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
    public partial class frmDemo02_Ordenar : Form
    {
        public frmDemo02_Ordenar()
        {
            InitializeComponent();
        }

        public Vehiculo[] vehiculos { get; set; }
        public Vehiculo[] arrayVehiculo { get; set; }

        private void frmDemo02_Ordenar_Load(object sender, EventArgs e)
        {
            arrayVehiculo = new Vehiculo[6]
            {
                new Vehiculo("Ford",1992),
                new Vehiculo("Fiat",1988),
                new Vehiculo("Buick",1932),
                new Vehiculo("Ford",1932),
                new Vehiculo("Dodge",1999),
                new Vehiculo("Honda",1977)
            };

            vehiculos = arrayVehiculo;
        }

        private void ObtenerArray()
        {
            vehiculos = null;
            vehiculos = arrayVehiculo.Clone() as Vehiculo[];
        }

        private void btnArrayUnsorted_Click(object sender, EventArgs e)
        {
            this.ObtenerArray();
            this.txtConsole.Clear();
            this.txtConsole.Text += "Array - Unsorted\r\n\r\n";
            this.MostrarVehiculos();
        }

        private void MostrarVehiculos()
        {
            if(vehiculos != null || vehiculos.Length > 0)
            {
                foreach(Vehiculo v in vehiculos)
                {
                    this.txtConsole.Text += $"Marca:{v.VehiculoMarca} \t\t Modelo:{v.VehiculoModelo} \r\n";
                }
            }
            else
            {
                this.txtConsole.Text += "Array - Empty\r\n";
            }
        }

        private void btnArraySortedDefault_Click(object sender, EventArgs e)
        {
            this.txtConsole.Clear();
            this.ObtenerArray();

            //Demo IComparable by sorting array with "default" sort order.
            Array.Sort(vehiculos);
            this.txtConsole.Text += "Array - Sorted by Marca (Ascending - IComparable)\r\n\r\n";
            this.MostrarVehiculos();
        }

        private void btnArraySortedAscendingNumericValue_Click(object sender, EventArgs e)
        {
            this.txtConsole.Clear();
            this.ObtenerArray();

            //Demo ascending sort of numeric value with IComparer.
            Array.Sort(vehiculos,Vehiculo.OrdenamientoAscendenteDeVehiculosPorModelo());
            this.txtConsole.Text += "Array - Sorted by Year (Ascending - IComparer)\r\n\r\n";
            this.MostrarVehiculos();
        }

        private void btnArraySortedDescendingNumericValue_Click(object sender, EventArgs e)
        {
            this.txtConsole.Clear();
            this.ObtenerArray();

            //Demo descending sort of numeric value with IComparer.
            Array.Sort(vehiculos, Vehiculo.OrdenamientoDescendenteDeVehiculosPorModelo());
            this.txtConsole.Text += "Array - Sorted by Year (Descending - IComparer)\r\n\r\n";
            this.MostrarVehiculos();
        }

        private void btnArraySortedDescendingStringValue_Click(object sender, EventArgs e)
        {
            this.txtConsole.Clear();
            this.ObtenerArray();

            //Demo descending sort of string value with IComparer.
            Array.Sort(vehiculos, Vehiculo.OrdenamientoDescendenteDeVehiculosPorMarca());
            this.txtConsole.Text += "Array - Sorted by Make (Descending - IComparer)\r\n\r\n";
            this.MostrarVehiculos();
        }
    }
}
