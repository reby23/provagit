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
        protected bool anno;
        protected bool acceso;
        protected bool freno;

        public Veicolo(string marca, string modello, int anno,bool freno)
        {
            this.marca = marca;
            this.modello = modello;
            this.anno = anno;
            acceso = false;
            this.freno = freno; 
        }

        private bool OnOff()
        {
            acceso=!acceso;
            return acceso;
        }

        private void Frena()
        {
            freno = !freno;
        }

    }
}
