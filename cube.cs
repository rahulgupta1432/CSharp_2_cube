using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Enter the number");
    int c=Convert.ToInt32(Console.ReadLine());
    int cube=c*c*c;
    Console.WriteLine("The Cube of value is : "+cube);
  }
}