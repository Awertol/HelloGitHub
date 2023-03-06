Console.WriteLine("Ahoj, jsem Michal Helgert, chodím na PedF UK a baví mě: ");

Console.ForegroundColor = ConsoleColor.Green;

string[] zajmy = { "Netflix", "Výměna manželek", "PlayStation", "Spánek", "Hardware" };
foreach(var item in zajmy)
{
    Console.WriteLine(item);
}
