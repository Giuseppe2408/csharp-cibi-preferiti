// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPreferiti = { "Pasta", "Pizza", "Torta", "Kebab", "McDonald" };

Console.WriteLine("lunghezza classifica è:" + cibiPreferiti.Length);

for(int i = 0; i < cibiPreferiti.Length; i++)

{
    int index = i + 1;
    Console.WriteLine("classifica cibi preferiti: " + index + " " + cibiPreferiti[i]);
}

int ciboDiMezzo = cibiPreferiti.Length / 2;

Console.WriteLine("il mio cibo preferito è " + cibiPreferiti.First());
Console.WriteLine("il mio ultimo cibo preferito è " + cibiPreferiti.Last());
Console.WriteLine("il mio ultimo cibo preferito di mezzo è " + cibiPreferiti[ciboDiMezzo]);