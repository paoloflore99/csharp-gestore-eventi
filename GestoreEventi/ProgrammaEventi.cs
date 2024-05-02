using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class ProgrammaEventi
    {
        public string Titolo;

        private List<Evento> Eventi;

        public ProgrammaEventi(string titolo)
        {
            this.Titolo = titolo;
            Eventi = new List<Evento>();
        }



    }
}
