using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto
{
    internal class Auto : Veicolo
    {
        private int nposti;

        public Auto(int nposti, string marca, string modello, int anno) :base(marca,modello,anno)
        {
            this.nposti = nposti;
        }

    }
}
