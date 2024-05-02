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
            if ( CapacitaMassima < 0 )
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
                if (Postiprenotati < 0)
                {
                    throw new ArgumentException("i posti prenotati devono essere positivi ");
                }
            }
        }

        public Evento(string Titolo , DateTime Data , int CapacitaMassima , int Postiprenotati)
        {
            this.Titolo = Titolo;
            this.Data = Data;
            this.CapacitaMassima = CapacitaMassima ;
            this.Postiprenotati = Postiprenotati;
            Postiprenotati = 0;
        }
    }
}
