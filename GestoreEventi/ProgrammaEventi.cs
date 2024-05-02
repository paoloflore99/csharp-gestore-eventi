using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi 
    {
        public string Titolo;

        private List<Evento> eventi;

        public ProgrammaEventi(string titolo)
        {
            this.Titolo = titolo;
            eventi = new List<Evento>();
        }

        public void AggiungiEvento(Evento eventiaggiunti)
        {
           eventi.Add(eventiaggiunti);
        }



        public List<Evento>EventiInData(DateTime data)
        {
            List<Evento> eventiInData = new List<Evento>();

            foreach (Evento evento in eventi)
            {
                if (evento.Data == data.Date)
                {
                    eventiInData.Add(evento);
                }
            }

            return eventiInData;
        }

        public void StampaEventi()
        {
            foreach (Evento evento in eventi)
            {
                Console.WriteLine(evento);
            }
        }

        public int NumeroDiEventi()
        {
            return eventi.Count;
        }

        public void SvuolaLista()
        {
            Console.WriteLine("cancellare tutti ggli eventi si : no ");
            string cancella = Console.ReadLine();
            if (cancella == "si")
            {
                eventi.Clear();
                Console.WriteLine($"tutti ggli eventi sono stati cancellati ");
            }
            else
            {
                Console.WriteLine($"nessun evento cancellato {Titolo}");
            }
        }
        public void ListaTitoli()
        {
            foreach(Evento evento in eventi)
            {

            }
            string listaMetodo = $"{Titolo}";

        }

    }
}
