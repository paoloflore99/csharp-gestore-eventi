using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
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
                    throw new ArgumentException($"la data deve partire dal {DateTime.Today} e non prima");
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

        public Evento(string Titolo , DateTime Data , int CapacitaMassima  )
        {
            this.Titolo = Titolo;
            this.Data = Data;
            //Data.ToString("dd/MM/yyyy");
            this.CapacitaMassima = CapacitaMassima ;
            this.Postiprenotati = 0;
        }


        public void PrenotaPosti()
            
        {
            
            if (Data < DateTime.Today)
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
                throw new Exception($"la capacita massima e di {CapacitaMassima} diminuire i prenotati al massimo di {CapacitaMassima}");
            }
        }

        public void DisdiciPosti(int postiDisdetti)
        {
            if (postiDisdetti < 0 )
            {
                throw new Exception("non si possono disdire 0 posti");
            }
            
            if  (postiDisdetti > Postiprenotati)
            {
                throw new Exception("non puo disdire sotto lo 0 ");
            }

            Postiprenotati -= postiDisdetti;

        }

        public override string ToString()
        {
            return $"{Titolo}-{Data}";
        }
    }
}
