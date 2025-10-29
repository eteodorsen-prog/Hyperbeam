namespace Oppgave_3;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        string svar;

        do

        {
            
            Console.WriteLine("vil du spille? J/N");
            svar = Console.ReadLine()?.Trim().ToLower() ?? "N";

            if (svar.StartsWith("j"))
            {
                game.StartGame();

            }


        }

          while (svar.StartsWith("j"));
      
      
         Console.WriteLine("takk for at du spilte");
         Console.ReadKey();
        
   }
      
 }
        



    
    

