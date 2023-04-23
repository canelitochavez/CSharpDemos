using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAPDemos.Entities
{
    public class Empleado : IComparable
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public decimal SueldoDiario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int CompareTo(object obj)
        {
            int resultado = 0;

            Empleado e = obj as Empleado;

            if(obj != null)
            {
                if(this.FechaIngreso < e.FechaIngreso)
                {
                    resultado = -1;
                }
                if(this.FechaIngreso == e.FechaIngreso)
                {
                    resultado = 0;
                }
                if(this.FechaIngreso > e.FechaIngreso)
                {
                    resultado = 1;
                }
            }
            else
            {
                throw (new Exception("Objetos no compatibles"));
            }

            return resultado;
        }

        public override string ToString()
        {
            return $"{this.Nombre},{this.Apellidos},{this.SueldoDiario},{this.FechaIngreso.ToString("yyyy/MM/dd")}";
        }
    }
}
