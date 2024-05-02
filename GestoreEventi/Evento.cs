using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        public string Titolo
        {
            get { return Titolo; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("titolo obligatorio");
                }
            }
        }
        public DateTime Data {
            get {  return Data; }
            set
            {
                if (value < DateTime.Today)
                {
                    throw new ArgumentException("la data deve partire dal 2024/05/02 e non prima");
                }
            }
        }
        public int CapacitaMassima
        {
            get {  return CapacitaMassima; }
            private set
            {
            if (value < 0 )
                {
                    throw new Exception("la capacita massima deve essere positiva ");
                }
            }         
        }
        public int Postiprenotati
        {
            get { return Postiprenotati; }
            private set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("i posti prenotati devono essere positivi ");
                }
            }
        }

        public Evento(string Titolo , DateTime Data , int CapacitaMassima , int Postiprenotati)
        {
            this.Titolo = Titolo;
            this.Data = Data;
            Data.ToString("dd/MM/yyyy");
            this.CapacitaMassima = CapacitaMassima ;
            this.Postiprenotati = Postiprenotati;
            Postiprenotati = 0;
        }

        public override string ToString()
        {
            return $"{Titolo}-{Data}";
        }
        public void PrenotaPosti()
        {
            if (Data < DateTime.Today  )
            {
                throw new Exception($"prenotare per una data dopo il {DateTime.Today}");
            }

            int PostiDisponibbili = CapacitaMassima - Postiprenotati ;

            if (PostiDisponibbili <= 0 )
            {
                throw new Exception("Mi dispiace , ma non ci sono piu posti disponibbili per questo evento");
            }

            if (CapacitaMassima > Postiprenotati)
            {
                throw new Exception($"la capacita massima e di {CapacitaMassima} diminuire i prenotati al massimo di {CapacitaMassima} ");
            }
        }

        public void DisdiciPosti() { }
    }
}
