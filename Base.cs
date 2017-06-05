using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3Circulares_Bases_y_Rutas
{
    class Base
    {
        public string nombreBase { get; set; }
        public DateTime minutos { get; set; }
        public Base siguiente { get; set; }
        public Base anterior { get; set; }

        public Base(string nombreBase,DateTime minutos)
        {
            this.nombreBase = nombreBase;
            this.minutos = minutos;
        }

        public override string ToString()
        {
            string regresa = "";
            regresa += "nombre: " + nombreBase + " Minutos: " + minutos;
            return regresa;
                
        }
    }
}
