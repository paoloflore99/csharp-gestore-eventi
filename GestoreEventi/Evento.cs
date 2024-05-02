using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

        public Evento(string Titolo , DateTime Data , int CapacitaMassima , int Postiprenotati)
        {
            this.Titolo = Titolo;
            this.Data = Data;
            //Data.ToString("dd/MM/yyyy");
            this.CapacitaMassima = CapacitaMassima ;
            this.Postiprenotati = Postiprenotati;
        }


        public void PrenotaPosti(string Titolo , DateTime data )
            
        {




        }

        public void DisdiciPosti(int Postiprenotati , int CapacitaMassima)
        {

            string SINO;
            do
            {
                Console.Write("Vuoi disdire delle posti (SI / NO) : ");
                SINO = Console.ReadLine();
                if (SINO == "si")
                {

                    Console.Write("quanti posti vuoi disdire : ");
                    int PostipostiDisdetti = int.Parse(Console.ReadLine());
                    if (PostipostiDisdetti > Postiprenotati)
                    {

                        Console.WriteLine($"I posti disdetti devo essere meno di : {Postiprenotati}");
                    }
                    else
                    {
                        Console.WriteLine();
                        int calcoloRifatto = Postiprenotati - PostipostiDisdetti;
                        Console.WriteLine($"adesso i prenotati sono  : {calcoloRifatto}");
                        int NuovoRisultato = CapacitaMassima - calcoloRifatto;
                        Console.WriteLine($"e i posti liberi sono : {NuovoRisultato}");
                        Console.WriteLine();
                    }

                }
                else if (SINO != "no" && SINO != "si")
                {
                    Console.WriteLine("Inserire SI o NO.");
                }
            } while (SINO == "si");

        }

        public override string ToString()
        {
            return $"{Titolo}-{Data}";
        }

        internal static void DisdiciPosti(object numeroDiPostiDaDisdire)
        {
            throw new NotImplementedException();
        }
    }
}
