// See https://aka.ms/new-console-template for more information

using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

Console.WriteLine("Your car is broken down on the side of the highway, Do you accept petrol?");
Console.WriteLine("Yes");
Console.WriteLine("No");
string Answer = Console.ReadLine();
if (Answer.ToUpper() == "NO")
{
    Console.WriteLine("You get fatally hit by a truck while on the side of the road. Game Over.");
    Environment.Exit(0);
}
else if (Answer.ToUpper() == "YES")
{
    Console.WriteLine("You keep driving until you find a gas station.");
}

Console.WriteLine();//

Console.WriteLine("Do you pull in?");
Console.WriteLine("Yes");
Console.WriteLine("No");
Answer = Console.ReadLine();
if (Answer.ToUpper() == "NO")
{
    Console.WriteLine("You run out of gas again. Game Over.");
    Environment.Exit(0);
}
else if (Answer.ToUpper() == "YES")
{
    Console.WriteLine("You get approached by a van.");
}

Console.WriteLine();//

Console.WriteLine("The van offers candy, do you accept?");
Console.WriteLine("Yes");
Console.WriteLine("No");
Answer = Console.ReadLine();
if (Answer.ToUpper() == "NO")
{
    Console.WriteLine("You get forced into the van.");
}
else if (Answer.ToUpper() == "YES")
{
    Console.WriteLine("You get kidnapped.");
}

Console.WriteLine();//

Console.WriteLine("Theres 2 doors one leads to the outside the other leads to the kidnappers room, which door do you pick?");
Console.WriteLine("1");
Console.WriteLine("2");
Answer = Console.ReadLine();
if (Answer.ToUpper() == "1")
{
    Console.WriteLine("You escape!");
}
else if (Answer.ToUpper() == "2")
{
    Console.WriteLine("You get captured and skinned, Game Over.");
    Environment.Exit(0);
}