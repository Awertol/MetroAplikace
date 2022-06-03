using MetroAplikace;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(@"
 |  \/  |    | |            
 | \  / | ___| |_ _ __ ___  
 | |\/| |/ _ \ __| '__/ _ \ 
 | |  | |  __/ |_| | | (_) |
 |_|  |_|\___|\__|_|  \___/ 
                           ");
Console.ResetColor();

List<string> linkaA = new List<string>
{
    "Nemocnice Motol", "Petřiny", "Nádraží Veleslavín", "Bořislavka", "Dejvická", "Hradčanská",
    "Malostranská", "Staroměstská", "Muzeum", "Můstek", "Náměstí Míru", "Jiřího z Poděbrad",
    "Flora", "Želivského", "STRAŠNICKÁ", "Skalka", "Depo Hostivař"
};
List<string> linkaD = new List<string>
{
    "Depo Písnice", "Písnice", "Libuš", "Nové Dvory", "Nemocnice Krč", "Nádraží Krč",
    "Olbrachtova", "Pankrác", "Náměstí Bratří Synků", "Náměstí Míru"
};

LinkaMetra linkaMetroA = new LinkaMetra(linkaA); //linkaA = list na 12. řádku
LinkaMetra linkaMetroD = new LinkaMetra(linkaD); //linkaD = list na 18. řádku

Console.WriteLine("Stiskněte jakoukoliv klávesu...");
Console.ReadKey();

while (true)
{
    string vybranaLinka = "";
    char pismenoLinky;
    while (true)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Vyberte linku metra  A/D");
        Console.ResetColor();
        try
        {
            vybranaLinka = Console.ReadLine();
            vybranaLinka = vybranaLinka.Trim().ToUpper();
            pismenoLinky = vybranaLinka[0];
            if (pismenoLinky == 'A' || pismenoLinky == 'D')
            {
                break;
            }
        }
        catch
        {
            Console.WriteLine("Neplatný input");
        }
    }
    Console.Clear();
    Console.WriteLine($"Stanice linky {pismenoLinky}\n");
    if (pismenoLinky == 'A')
    {
        Console.ForegroundColor = ConsoleColor.Green;
        linkaMetroA.VypisStanice();
        Console.ResetColor();
        linkaMetroA.PrvniPosledniStanice();
    }
    if (pismenoLinky == 'D')
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        linkaMetroD.VypisStanice();
        Console.ResetColor();
        linkaMetroD.PrvniPosledniStanice();
    }
    Console.WriteLine("Zadej stanici odjezdu");
    string staniceA = Console.ReadLine();
    Console.WriteLine("Zadej stanici příjezdu");
    string staniceB = Console.ReadLine();

    int casCesty = 0;
    if (vybranaLinka == "A")
    {
        casCesty = linkaMetroA.ZjistiCas(staniceA, staniceB);
    }
    else if (vybranaLinka == "D")
    {
        casCesty = linkaMetroD.ZjistiCas(staniceA, staniceB);
    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Čas cesty je přibližně: {casCesty} minut"); //vypisování času
    Console.ResetColor();
    Console.ReadKey();
}

