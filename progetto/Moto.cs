using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progetto
{
    internal class Moto:Veicolo
    {
        private int nPreseAria;
        private bool frenoAnt;
        private bool frenoPost;

        public Moto(int nPreseAria, string marca, string modello, int anno,bool freno) : base(marca, modello, anno, freno)
        {
            this.nPreseAria = nPreseAria;

        }
        public void Frena(string tipofreno)
        {
            if (tipofreno == "anteriore")
            {
                frenoAnt = !frenoAnt;
            }
            else if (tipofreno == "posteriore")
            {
                frenoPost = !frenoPost;
            }
            else
            {
                frenoAnt = !frenoAnt;
                frenoPost = !frenoPost;
            }
        }
    }
}
