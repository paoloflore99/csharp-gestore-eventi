using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using GestoreEventi;
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
                int calcolo =  - Postiprenotati;
                Console.WriteLine($"numero di posti disponibbili - {calcolo}");

                Console.WriteLine();
                
                Evento evento = new Evento(Titolo, data, CapacitaMassima, Postiprenotati);
                evento.DisdiciPosti(Postiprenotati, CapacitaMassima);


                //Evento.DisdiciPosti(numeroDiPostiDaDisdire);
                //ninte

                ProgrammaEventi programmaEventi = new ProgrammaEventi(Titolo);

                List<Evento> eventiInData = programmaEventi.EventiInData(data); ;
                foreach (Evento evento2 in eventiInData)
                {
                    Console.WriteLine($"Titolo - {Titolo} :");
                    Console.WriteLine($"Data - {evento2.Data}");
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