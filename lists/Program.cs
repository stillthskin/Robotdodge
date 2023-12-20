using System.Collections.Generic;
using System;
using SplashKitSDK;

public class Program
{
    public static List<double> values= new List<double>();
    public static void Main()
    {
        do{
        switch (ReadUserOption()){
         case UserOption.NewValue:
         AddValueToList();

        break;
        case UserOption.Sum:
        Sum(values);
        break;

        case UserOption.Print:
        Console.WriteLine(values);
        break;
        }
        }
        while(ReadUserOption() != UserOption.Quit);


    }
    public static int ReadInteger(string prompt)
{
Console.Write(prompt);
while (true)
{
try
{
return Int32.Parse(Console.ReadLine());
}
catch
{
Console.WriteLine("Please enter a valid integer");
}
}
}
public static int ReadDouble(string prompt)
{
Console.Write(prompt);
while (true)
{
try
{
return Int32.Parse(Console.ReadLine());
}
catch
{
Console.WriteLine("Please enter a valid integer");
}
}

}
public static void AddValueToList()
{
    values.Add(ReadDouble("Enter values to add to the the list: "));
}
public static Double Sum(List<double> values){
    double sum = 0;
    for (int i = 0; i < values.Count; i++)
    {
        values.ForEach((value)=> sum += value);
    }
    Console.WriteLine("The sum total is: "+ sum);

return sum;
}
public static UserOption ReadUserOption()
{
Console.WriteLine("Enter 0 to add a value");
Console.WriteLine("Enter 1 to add a sum all values");
Console.WriteLine("Enter 2 to print a sum all values");
Console.WriteLine("Enter 3 to quit");
int option = 3;
Int32.TryParse(Console.ReadLine(), out option);
return (UserOption)option;
}
public enum UserOption
{
    NewValue,
    Sum,
    Print,
    Quit

}
}
