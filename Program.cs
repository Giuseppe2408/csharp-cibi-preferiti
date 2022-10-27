// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] cibiPreferiti = { "Nutella", "Pasta", "Pizza", "Torta", "Kebab", "McDonald", "carne"};

Console.WriteLine("lunghezza classifica è:" + cibiPreferiti.Length);

for(int i = 0; i < cibiPreferiti.Length; i++)

{
    int index = i + 1;
    Console.WriteLine("classifica cibi preferiti: " + index + " " + cibiPreferiti[i]);
}



Console.WriteLine("il mio cibo preferito è " + cibiPreferiti[0]);
Console.WriteLine("il mio ultimo cibo preferito è " + cibiPreferiti[cibiPreferiti.Length - 1]);
if (cibiPreferiti.Length % 2 == 0)
{
    //pari
    int medSup = cibiPreferiti.Length / 2;
    int medInf = medSup - 1;
    Console.WriteLine("la mediana è: {0} e {1}", cibiPreferiti[medInf], cibiPreferiti[medSup]);
   
}
else
{
    //dispari
    int ciboDiMezzo = cibiPreferiti.Length / 2;
    Console.WriteLine("il mio ultimo cibo preferito di mezzo è " + cibiPreferiti[ciboDiMezzo]);
}