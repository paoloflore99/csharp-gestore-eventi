using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    internal class Evento
    {
        public string Titolo {  get; set; }
        public int Data { get; set; }
        public int CapacitaMassima { get; set; }
        public int PostiDisponibboli { get; set;}
    }
}
