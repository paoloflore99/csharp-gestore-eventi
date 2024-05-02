﻿using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestoreEventi
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            try
            {

                
                Console.Write($"Inserisci il nome dell'evento : ");
                string Titolo = Console.ReadLine();
                if (string.IsNullOrEmpty(Titolo))
                {
                    throw new Exception("nome evento obligatorio");
                }


                Console.Write("Inserisci la data dell'evento (gg/mm/yyyy): ");
                string DataDAData = Console.ReadLine();
                DateTime data;

                if (DateTime.TryParseExact(DataDAData, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out data))
                {
                    Console.WriteLine("Data inserita correttamente: " + data.ToString("dd/MM/yyyy"));
                }
                else
                {
                    Console.WriteLine("Formato data non valido. Assicurati di inserire la data nel formato corretto (gg/mm/yyyy).");
                }



                Console.Write("Inserisci il numero dei posti totali : ");
                int CapacitaMassima;
                if (!int.TryParse(Console.ReadLine(), out CapacitaMassima))
                {
                    //throw new Exception("inserisci numero intero");
                    Console.WriteLine("inserisci numero intero");
                }

                if (CapacitaMassima < 0)
                {
                    CapacitaMassima = 0;
                    Console.WriteLine("la capacita massima deve essere superio allo 0 ");

                }

                Console.Write("Quanti posti desideri prenotare :  ");
                int Postiprenotati = Convert.ToInt32(Console.ReadLine());


                
                Console.WriteLine();



                Console.WriteLine($"numero di posti prenotati - {Postiprenotati}");
                int calcolo = CapacitaMassima - Postiprenotati;
                Console.WriteLine($"numero di posti disponibbili - {calcolo}");

                Console.WriteLine();

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


                //ninte

                ProgrammaEventi programmaEventi = new ProgrammaEventi(Titolo);

                List<Evento> eventiInData = programmaEventi.EventiInData(data); ;
                foreach (Evento evento in eventiInData)
                {
                    Console.WriteLine($"Titolo - {Titolo} :");
                    Console.WriteLine($"Data - {evento.Data}");
                    Console.WriteLine();
                }

                programmaEventi.StampaEventi();


                programmaEventi.SvuolaLista();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"si e verificato un errore: {ex.Message}");
            }

        }
    }
}
//Data = DateTime.ParseExact("31/12/2024", "dd/MM/yyyy", null);
//DateTime.TryParseExact("31/12/2024", "dd/MM/yyyy", new CultureInfo("it-IT"), DateTimeStyles.None, out DateTime result);