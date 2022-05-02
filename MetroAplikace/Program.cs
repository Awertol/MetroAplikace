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

Console.WriteLine("Vyberte linku metra  A/D");
string vybranaLinka = Console.ReadLine();

if (vybranaLinka == "A" || vybranaLinka == "D")
{
    if (vybranaLinka == "A")
    {
        linkaMetroA.VypisStanice();
        linkaMetroA.PrvniPosledniStanice();
    }
    if (vybranaLinka == "D")
    {
        linkaMetroD.VypisStanice();
        linkaMetroD.PrvniPosledniStanice();
    }
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
else if(vybranaLinka=="D")
{
    casCesty = linkaMetroD.ZjistiCas(staniceA, staniceB);
}

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"Čas cesty je přibližně: {casCesty} minut"); //vypisování času
Console.ResetColor();


