Gjett tallet :

dette programmet er et spill som lar brukeren gjette mellom tallet 1 og 50: 
programmet starter med å spørre brukeren om den vil spille med valg av taster
(j/n). Velger brukeren (j) starter spille og brukeren får 2 forsøk å deretter starter
programmet på nytt når disse forsøkene brukt opp eller programmet avslutter om 
brukeren trykker (n)


namespace Oppgave_3;

class Program

    static void Main(string[] args)
    
        Game game = new Game()                                      ----- lager til nøkkelen svar for svar for start spill eller stopp program
        string svar;

        do								

        
            
            Console.WriteLine("vil du spille? J/N");
            svar = Console.ReadLine()?.Trim().ToLower() ?? "N"     ---- spør brukeren om den vil starte spill ved valg av
									tastene j eller n
            if (svar.StartsWith("j"))
            							 
                game.StartGame();				-----  blir "j" tasten trykket på begynner spillet

            


       

          while (svar.StartsWith("j"));				
      
      
         Console.WriteLine("takk for at du spilte");		----- spilleren trykker ("n) og programmet avslutter
         Console.ReadKey();					----- avslutter spillet
        




	namespace Oppgave_3
{

   public class Game
    
        private Random random = new Random()		---- lager til random nummer som skal bli kjørt uten at bruker vet om hvilket det er
        private int secretNumber;			før første gjetting. 
							Her blir det laget 2 forsøk som kan brukes før programmet starter på nytt
        private int MaxAttempts = 2			viss bruker finner "secret number" starter program på nytt


        public void StartGame()
        
            secretNumber= random.Next (1,50)											--- brukeren får mulighet å velge mellom tallene (1-50)
            int attempts = 0;													"secret number kommer opp etter første forsøk" og spilleren 
            Console.WriteLine($"Jeg tenker på et tall mellom 1-50, kan du gjette det? du har " + MaxAttempts + " forsøk") 	får vite hvor mange forsøk den har igjen

            while (attempts < MaxAttempts)											--- looper gjennom 2 ganger/stoppes om rett verdi blir inputtet
            
                Console.Write("Gjett tallet: ");
                string? input = Console.ReadLine();										--- bruker får beskjed om å gjette the "secret number" 
																input av riktig tall
                if (int.TryParse(input, out int guess))
                														-- if/ else viss rett verdi får brukeren beskjed fra programmet 
                    attempts++;													om riktige( programmet starter på nytt) eller verdien var ikke 																	riktig og legger til et forsøk til.

                    int difference = guess - secretNumber;									--- her beregnes forskjell mellom guess og secret number 
																string for hint. dette puttes inn i switch når tallet blir gjettet
                    string hint = "";
                    switch (difference)
                    

                        case 0:
                            Console.WriteLine($"Hurra! du gjettet riktig på {attempts} forsøk.Tallet var {secretNumber}.")	--- riktig verdi ble gjettet, får opp hvor mange forsøk som ble 																brukt før tallet ble gjettet.   
                            return;

                        case < 1:
                            hint = "for lavt! prøv høyere!";									--- her ble det gjettet for lavt tall får beskjed "prøv høyere"!
                            break;
                        
                        case > 2:
                            hint = "for høyt! prøv lavere!";									---- "for høyt prøv lavere!"
                            break;

                    

                    if (hint != "")												---- hint( er hva "secret number" er)
                    
                    
                        Console.WriteLine(hint);
                        Console.WriteLine($"forsøk igjen du har { MaxAttempts - attempts}. forsøk igjen")			skriver ut hvor mange forsøk det er igjen før programmet stopper	

                    

                

                else

                
                    Console.WriteLine("ugyldig input-skriv inn et tall!");							gitt ugyldig input(må være tall)


                    
                Console.WriteLine($" tallet var {secretNumber}, bedre lykke neste gang!")					skriver ut "secretnumber" og bedre lykke neste gang før programmet 																avslutter

                 

        
            
            
    

