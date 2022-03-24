DateTime cas = DateTime.Now;
int mesicee = cas.Month;
string[] pole = { "Leden", "Únor", "Březen", "Duben", "Květen", "Červen", "Červenec", "Srpen", "Zaří", "Říjen", "Listopad", "Prosinec" };


Console.WriteLine($"Teď je: {pole[mesicee - 1]}, další měsíc: {pole[mesicee]}, předchozí měsíc: {pole[mesicee - 2]}");
Console.WriteLine("Napiš číslo měsíce (1-12)");


int mesic = Convert.ToInt32(Console.ReadLine());
int mínus = mesic - 1;
int plus = mesic + 1;


if (mesic >= 2 && mesic <= 11)
{
    Console.WriteLine($"Teď je: {pole[mesic - 1]}, další měsíc: {pole[plus - 1]}, předchozí měsíc: {pole[mínus - 1]}");
    Console.ReadLine();
}
else if (mesic == 1)
{
    Console.WriteLine($"Teď je: {pole[0]}, další měsíc: {pole[1]}, předchozí měsíc: {pole[11]}");
    Console.ReadLine();
}
else if (mesic == 12)
{
    Console.WriteLine($"Teď je: {pole[11]}, další měsíc: {pole[0]}, předchozí měsíc: {pole[10]}");
    Console.ReadLine();
}
Console.WriteLine("Vypsat všechny měsíce, YES/NO?");
string nevim = Console.ReadLine();
if (nevim == "YES")
{
    foreach (string popsmoke in pole)
    {
        Console.WriteLine(popsmoke);

    }
}
else if (nevim == "NO")
{
    Console.WriteLine("co to máčkáš vole");
    Console.ReadLine();
    System.Environment.Exit(0);
}

