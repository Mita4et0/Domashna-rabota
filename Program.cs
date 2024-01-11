var name = new Dictionary<string,int>();
name["Ivan"] = 175;
name["Boris"] = 163;
name["Aleksander"] = 185;
name["Nikola"] = 192;
name["Todor"] = 168;
foreach (var i in name)
{
    Console.WriteLine("{0}--->{1}", i.Key, i.Value);
}
Console.WriteLine();
    int d = (175+163+185+192+168) / 5;
Console.WriteLine("Srednata visochina e:"+d);
Console.WriteLine();
name.Add("Dimitar", 190);
foreach (var i in name)
{
    Console.WriteLine("{0}--->{1}", i.Key, i.Value);
}
Console.WriteLine();
Console.WriteLine("Broq na vsichki uchenici="+name.Count);
