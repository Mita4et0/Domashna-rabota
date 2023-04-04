// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.Linq;
Console.WriteLine("Kolko produkta iskate");
int n =int.Parse(Console.ReadLine());
List <string> produkti = new List<string>();
for (int i =1;i<=n;i++)
{
    Console.WriteLine("Vuvedete produkt");
    List<string> produkt =Console.ReadLine().Split(' ').ToList();
}
for (int i =1;i<=n;i++)
{
    List<string> produkt = Console.ReadLine().Split(' ').ToList();
    Console.WriteLine(i+"."+produkt);
}


