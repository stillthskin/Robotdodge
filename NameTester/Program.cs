using System;
using SplashKitSDK;

public class Program
{
    
    public static void Main()
    {
        MenuOption userSelection;
        do
        {
            userSelection = ReadUserOption();
            switch(userSelection)
            {
                case MenuOption.TestName:
                TestName();
                //Console.WriteLine("Test Name...");
                break;
                case MenuOption.GuessThatNumber:
                RunGuessThatNumber();
                break;
            
            }
} while (userSelection != MenuOption.Quit);
    }

    public static void  TestName(){
        string name;
        Console.WriteLine("Enter your name");
        name = Console.ReadLine();
        if (name.ToLower() == "andrew")
        {
            Console.WriteLine("Welcome my Coder!");
        
        }
        else if ( name.ToLower() == "jake" )
        {
            Console.WriteLine("Welcome Jake!");
        }
        else{
            Console.WriteLine("Welcome User!");
        }

    }
    public static void  RunGuessThatNumber(){
          int target;
          int guess = 0;
          int themin = 1;
          int themax = 100;

          target = new Random().Next(100) + 1;
          Console.WriteLine(target);
          guess = ReadGuess(themin, themax);
          while(guess != target){
              guess = ReadGuess(themin, themax);
              if (guess < target){
                  Console.WriteLine("Guess less than the target value");
              }
              else if(guess > target){
                  Console.WriteLine("Guess greater than the target value");
                }
              else{
                  Console.WriteLine("The guess is right");
              }
          }
  

    }
    private static int ReadGuess(int min, int max)
    {
        int userNumber;
        do
        {
             Console.WriteLine("Enter a number to guess between "+min +" and "+max);
             try{
             userNumber = Convert.ToInt32(Console.ReadLine());
             }
             catch{
                 userNumber = -1;
             }
        } 
        while (userNumber < min || userNumber > max);

        return userNumber;
    }
    public enum MenuOption
{
    TestName,
    GuessThatNumber,
    Quit
}
    private static MenuOption ReadUserOption()
{
    int option;

    Console.WriteLine("Please select what task you would like to perform: 1. Test Name, *** 2. Guess That Number *** 3. Quit");
    do
    {
        Console.WriteLine("Chose between 1-3");
        try{
        option = Convert.ToInt32(Console.ReadLine());
        }
        catch{
            option = -1;
        }
    } 
    while (option<1 || option>3);
    return (MenuOption)(option - 1);
}

}
