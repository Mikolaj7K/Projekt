// See https://aka.ms/new-console-template for more information
Random r = new Random();
int rNum = r.Next(1, 4);
Console.WriteLine("Cześć, zagrajmy w grę. Podaj mi swoje imie.");
string? Name = Console.ReadLine();
Console.WriteLine(Name + " zgadni liczbę 'alpha' o której myslę. (1-3)" + rNum);
int Ans1 = Convert.ToInt32(Console.ReadLine());
if (Ans1 == rNum){
    Console.WriteLine("Świetnie.");
} else {
    Console.WriteLine("Umierasz.");
    return;
}
Console.WriteLine(Name + ", Teraz podaj taką liczbę 'beta' aby po dodaniu jej i liczby 'alpha' wyszło 10.");
int Ans2 = Convert.ToInt32(Console.ReadLine());

if (Ans2 + rNum == 10 || Ans2 + Ans1 == 10) {
    Console.WriteLine("Znakomicie.");
} else {
     Console.WriteLine("Umierasz.");
    return;
}
Console.WriteLine(Name + ", Teraz podasz 4 liczby pod rząd, podaj takie liczby aby po dodaniu z liczbą 'beta' wyszła liczba parzysta.");
//zamiast pisać 4 razy console read line piszemy funkcję.
int suma = Ans2;
for (int i = 0; i < 4; i++)
{
    Console.Write("Podaj liczbę " + (i + 1) + ": ");
    int liczba = Convert.ToInt32(Console.ReadLine());
    suma += liczba;
}
if (suma % 2 == 0)
{
    Console.WriteLine("Brawo. Wygrałeś grę.");
} else {
    Console.WriteLine("Umierasz. A było tak blisko...");
    return;
}
