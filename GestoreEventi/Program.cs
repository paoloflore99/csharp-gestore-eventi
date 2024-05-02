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



                Console.Write("Inserisci la data dell'evento ( gg/mm/yyyy ): ");
                string DataDAData = Console.ReadLine();
                DateTime Data;
                if (DateTime.TryParse(DataDAData, out Data)) { }
                Data.ToString("dd/MM/yyyy");



                Console.Write("Inserisci il numero dei posti totali : ");
                //int CapacitaMassima = Convert.ToInt32(Console.ReadLine());
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

                Console.WriteLine(Data);
                Console.WriteLine();



                Console.WriteLine($"numero di posti prenotati - {Postiprenotati}");
                int calcolo = CapacitaMassima - Postiprenotati;
                Console.WriteLine($"numero di posti disponibbili - {calcolo}");

                Console.WriteLine();



                Console.Write("Vuoi disdire delle posti (SI / NO) : ");
                //DisdiciPosti(int postiDisdetti)
                string SINO = Console.ReadLine();

                if (SINO == "si")
                {
                    Console.Write("quanti posti vuoi disdire : ");
                    int PostipostiDisdetti = int.Parse(Console.ReadLine());
                    if (PostipostiDisdetti > Postiprenotati)
                    {
                        
                        Console.WriteLine($"I posti disdetti devo essere meno di : {Postiprenotati}");
                    }
                    Console.WriteLine();
                    int calcoloRifatto = Postiprenotati - PostipostiDisdetti  ;
                    Console.WriteLine($"adesso i prenotati sono  : {calcoloRifatto}");
                    int NuovoRisultato = CapacitaMassima - calcoloRifatto;
                    Console.WriteLine($"e i posti liberi sono : {NuovoRisultato}") ;
                    Console.WriteLine();
                } 
                else if (SINO == "no")
                {
                    Console.WriteLine("OK va bene");
                }
                else
                {
                    Console.WriteLine("inserire si o no");
                }




            }
            catch (Exception ex)
            {
                Console.WriteLine($"si e verificato un errore: {ex.Message}");
            }

        }
    }
}
