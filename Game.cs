using System.Diagnostics;
using System.Reflection.PortableExecutable;
using Microsoft.Win32.SafeHandles;


namespace Oppgave_3
{

   public class Game
    {
        private Random random = new Random();
        private int secretNumber;
        private int MaxAttempts = 2;


        public void StartGame()
        {
            secretNumber= random.Next (1,50);
            int attempts = 0;
            Console.WriteLine($"Jeg tenker på et tall mellom 1-50, kan du gjette det? du har " + MaxAttempts + " forsøk");

            while (attempts < MaxAttempts)
            {
                Console.Write("Gjett tallet: ");
                string? input = Console.ReadLine();

                if (int.TryParse(input, out int guess))
                {
                    attempts++;

                    int difference = guess - secretNumber;
                    string hint = "";
                    switch (difference)
                    {

                        case 0:
                            Console.WriteLine($"Hurra! du gjettet riktig på {attempts} forsøk.Tallet var {secretNumber}.");
                            return;

                        case < 1:
                            hint = "for lavt! prøv høyere!";
                            break;
                        
                        case > 2:
                            hint = "for høyt! prøv lavere!";
                            break;

                    }

                    if (hint != "")
                    
                    {
                        Console.WriteLine(hint);
                        Console.WriteLine($"forsøk igjen du har { MaxAttempts - attempts}. forsøk igjen");

                    }

                }

                else

                {
                    Console.WriteLine("ugyldig input-skriv inn et tall!");


                    }
                Console.WriteLine($" tallet var {secretNumber}, bedre lykke neste gang!");

                 }

        }
            
            
    }

}
         


