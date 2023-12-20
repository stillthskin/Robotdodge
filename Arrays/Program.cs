using System;
public class Program
{

public static void Main()
{
    int numberOfValues = ReadInteger("Enter number of values to store: ");
    double[] values = new double[numberOfValues];
    for (int i = 0; i < numberOfValues; i++)
{
values[i] = ReadDouble($"Enter the {i + 1}st value: ");
}
   Sum(values);

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
public static Double ReadDouble(string prompt)
{
Console.Write(prompt);
while (true)
{
try
{
return Double.Parse(Console.ReadLine());
}
catch
{
Console.WriteLine("Please enter a valid Double ");
}
}
}
public static Double Sum(Double[] values){
    Double sum = 0;
    for (int i = 0; i < values.Length; i++)
    {
        sum += values[i];
    }
    Console.WriteLine("The sum total is: "+ sum);

return sum;
}
}