Console.WriteLine("Vuvedete imeto na fitnesa");
string name=Console.ReadLine();
Console.WriteLine("Vuvedete ured");
List<string> gym = Console.ReadLine().Split(' ').ToList();
Console.WriteLine("Vuvedete ured na koito iskate da trenirate");
string machine = Console.ReadLine();
for(int i=0;i<1;i++)
{
    if (gym.Contains(machine)) 
    Console.WriteLine("Da ima ured na koito iskash da trenirash");
}
for (int i = 0; i < gym.Count; i++)
{
    Console.WriteLine(gym[i]+"."+name);
}
gym.Add("legpresa");
Console.WriteLine(gym.Count);
