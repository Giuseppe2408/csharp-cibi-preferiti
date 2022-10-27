// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPreferiti = { "Pasta", "Pizza", "Torta", "Kebab", "McDonald" };

Console.WriteLine("lunghezza classifica è:" + cibiPreferiti.Length);

for(int i = 0; i < cibiPreferiti.Length; i++)

{
    int index = i + 1;
    Console.WriteLine("classifica cibi preferiti: " + index + cibiPreferiti[i]);
}

Console.WriteLine("il mio cibo preferito è " + cibiPreferiti[0]);
Console.WriteLine("il mio ultimo cibo preferito è " + cibiPreferiti[4]);
Console.WriteLine("il mio ultimo cibo preferito di mezzo è " + cibiPreferiti[2]);