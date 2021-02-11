using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Lab3a");
 

 int fahrenheit;
Console.WriteLine("Enter temperature in celsius");

 int celsius = Convert.ToInt32(Console.ReadLine());
fahrenheit = (celsius * 9) / 5 + 32;

Console.WriteLine("The converted fahrenheit temperature is" + fahrenheit);

 if ( celsius < 32 )
 {
   Console.WriteLine("This temperature is below freezing of 32 degree Farenheit");
 }

 if ( celsius > 100)
 {
   Console.WriteLine("This temperature is above boiling point of 212 degree Farenheit");
 }
  } 
}