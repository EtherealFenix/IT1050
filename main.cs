using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter the name of an item");
    string item =Console.ReadLine();
    Console.WriteLine ("Enter the quantity");
    int quantity  = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Enter the price");
    double price = Convert.ToDouble(Console.ReadLine());
    double cost = price*quantity;
    Console.WriteLine("Total price of "+ item + "= $" + cost);
    //Console.WriteLine(item);
  }
}