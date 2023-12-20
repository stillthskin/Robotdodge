using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        string name; 
        string inputText; 
        int heightInCM;
        double heightInMeters; 
        double weight;
        double userBMI;

        Console.Write("Enter your name: ");
        name = Console.ReadLine();

        Console.WriteLine("Hello " + name);
        
        Console.Write("Enter your height in centimeters: ");
        inputText = Console.ReadLine();
        heightInCM = Convert.ToInt32(inputText);
        heightInMeters = heightInCM / 100;
        Console.Write("Enter your weight in kilograms: ");
        inputText = Console.ReadLine();
        weight = Convert.ToDouble(inputText);

        Console.WriteLine("You have entered" + heightInMeters +" and "+ weight);

        userBMI =  weight / (heightInMeters * heightInMeters);

        Console.WriteLine("Your BMI is: " +userBMI);
    }
}