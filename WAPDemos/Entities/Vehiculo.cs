using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAPDemos.Entities
{
    public class Vehiculo: IComparable
    {
        private int modelo;
        private string marca;

        public Vehiculo(string Marca,int Modelo)
        {
            this.modelo = Modelo;
            this.marca = Marca;
        }

        public int VehiculoModelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }

        public string VehiculoMarca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }

        public int CompareTo(object obj)
        {
            Vehiculo v = (Vehiculo)obj;

            return string.Compare(this.marca, v.marca);
        }

        private class OrdenamientoAscendentePorModelo : IComparer
        {
            public int Compare(object x, object y)
            {
                Vehiculo v1 = (Vehiculo)x;
                Vehiculo v2 = (Vehiculo)y;

                if(v1.modelo > v2.modelo)
                {
                    return 1;
                }
                if(v1.modelo < v2.modelo)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        private class OrdenamientoDescendentePorModelo : IComparer
        {
            public int Compare(object x, object y)
            {
                Vehiculo v1 = (Vehiculo)x;
                Vehiculo v2 = (Vehiculo)y;

                if(v1.modelo < v2.modelo)
                {
                    return 1;
                }

                if(v1.modelo > v2.modelo)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }

        private class OrdenamientoDescendentePorMarca : IComparer
        {
            public int Compare(object x, object y)
            {
                Vehiculo v1 = (Vehiculo)x;
                Vehiculo v2 = (Vehiculo)y;

                return string.Compare(v2.marca, v1.marca);
            }
        }

        public static IComparer OrdenamientoAscendenteDeVehiculosPorModelo()
        {
            return (IComparer)new OrdenamientoAscendentePorModelo();
        }

        public static IComparer OrdenamientoDescendenteDeVehiculosPorModelo()
        {
            return (IComparer)new OrdenamientoDescendentePorModelo();
        }

        public static IComparer OrdenamientoDescendenteDeVehiculosPorMarca()
        {
            return (IComparer)new OrdenamientoDescendentePorMarca();
        }
    }
}
