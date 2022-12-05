using System;

class Program
{
    static void Main() {
   Random rnd=new Random();
            
            
            int number=rnd.Next(10000);
            int guess;
            int play=0;
            int count=1;
            int minTries=int.MaxValue;
          while(play!=1)
              
          { 
              Console.Clear();
              Console.WriteLine($@"
    _____    __    __    _____    _____    _____      ________   __    __     ____     ________         __      _   __    __     __    __     ______     _____   ______    _______    
   / ___ \   ) )  ( (   / ___/   / ____\  / ____\    (___  ___) (  \  /  )   (    )   (___  ___)       /  \    / )  ) )  ( (     \ \  / /    (_   _ \   / ___/  (   __ \   \     /    
  / /   \_) ( (    ) ) ( (__    ( (___   ( (___          ) )     \ (__) /    / /\ \       ) )         / /\ \  / /  ( (    ) )    () \/ ()      ) (_) ) ( (__     ) (__) )   \   /     
 ( (  ____   ) )  ( (   ) __)    \___ \   \___ \        ( (       ) __ (    ( (__) )     ( (          ) ) ) ) ) )   ) )  ( (     / _  _ \      \   _/   ) __)   (    __/     ) (      
 ( ( (__  ) ( (    ) ) ( (           ) )      ) )        ) )     ( (  ) )    )    (       ) )        ( ( ( ( ( (   ( (    ) )   / / \/ \ \     /  _ \  ( (       ) \ \  _    \_/      
  \ \__/ /   ) \__/ (   \ \___   ___/ /   ___/ /        ( (       ) )( (    /  /\  \     ( (         / /  \ \/ /    ) \__/ (   /_/      \_\   _) (_) )  \ \___  ( ( \ \_))    _       
   \____/    \______/    \____\ /____/   /____/         /__\     /_/  \_\  /__(  )__\    /__\       (_/    \__/     \______/  (/          \) (______/    \____\  )_) \__/    (_)      
                                                                                                                                                                                      
");
      count=1;
      Console.WriteLine("Guess a number");
      guess=int.Parse(Console.ReadLine());
      while(guess!=number)
      {
          Console.ForegroundColor=ConsoleColor.Red;
          Console.WriteLine($"This is for DEBUG ONLY:{number}");
          Console.ResetColor();
          if(guess<number)
          {
              Console.WriteLine($"The number is BIGGER THAN {guess}"); 
          }
          else
            Console.WriteLine($"The number is SMALLER THAN {guess}");
           
         Console.WriteLine($"Guess another number");
        guess=int.Parse(Console.ReadLine());
        count++;       
       
          
      } 
      if(count<minTries)
            minTries=count;
      Console.WriteLine($"GG, You made it in {count} guesses (your best game was {minTries} guesses  Press 1 to End and Any other number to  Play again");
       play=int.Parse(Console.ReadLine());
      
                                
       
        }
    }
}