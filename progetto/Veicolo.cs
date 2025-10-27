using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace progetto
{
    internal class Veicolo
    {
        protected string marca;
        protected string modello;
        protected int anno;
        protected bool acceso;

        public Veicolo(string marca, string modello, int anno)
        {
            this.marca = marca;
            this.modello = modello;
            this.anno = anno;
            acceso = false;
        }

        private bool OnOff()
        {
            acceso=!acceso;
            return acceso;
        }

    }
}
