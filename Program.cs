// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

//string[] cibiPreferiti = { "Nutella", "Pasta", "Pizza", "Torta", "Kebab", "McDonald", "carne"};

//Console.WriteLine("lunghezza classifica è:" + cibiPreferiti.Length);

//for(int i = 0; i < cibiPreferiti.Length; i++)

//{
//    int index = i + 1;
//    Console.WriteLine("classifica cibi preferiti: " + index + " " + cibiPreferiti[i]);
//}



//Console.WriteLine("il mio cibo preferito è " + cibiPreferiti[0]);
//Console.WriteLine("il mio ultimo cibo preferito è " + cibiPreferiti[cibiPreferiti.Length - 1]);
//if (cibiPreferiti.Length % 2 == 0)
//{
//    //pari
//    int medSup = cibiPreferiti.Length / 2;
//    int medInf = medSup - 1;
//    Console.WriteLine("la mediana è: {0} e {1}", cibiPreferiti[medInf], cibiPreferiti[medSup]);

//}
//else
//{
//    //dispari
//    int ciboDiMezzo = cibiPreferiti.Length / 2;
//    Console.WriteLine("il mio ultimo cibo preferito di mezzo è " + cibiPreferiti[ciboDiMezzo]);
//}


//Secondo esercizio di oggi

//snack 1
//utente inserisce 2 numeri in successione software stampa maggiore

//Console.WriteLine("inserisci un numero : ");

//int firstNum = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("inserisci un altro numero : ");

//int secondNum = Convert.ToInt32(Console.ReadLine());

//if (firstNum > secondNum)
//{
//    Console.WriteLine(firstNum);
//}
//else
//{
//    Console.WriteLine(secondNum);
//}


//snack 2
//L’utente inserisce due parole in successione.
//Il software stampa prima la parola più corta, poi la parola più lunga.

//Console.WriteLine("inserisci parola");

//string firstWord = Console.ReadLine();

//Console.WriteLine("inserisci parola");

//string secondWord = Console.ReadLine();

//if (firstWord.Length < secondWord.Length)
//{
//    Console.WriteLine(firstWord);
//    Console.WriteLine(secondWord);
//}
//else
//{
//    Console.WriteLine(secondWord);
//    Console.WriteLine(firstWord);
//}

//snack 3
//Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.

//int somma = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("inserisci num");
//    int num = Convert.ToInt32(Console.ReadLine());
//    somma = somma += num;


//}
//Console.WriteLine();
//Console.WriteLine("la somma è: " + somma);

//snack 4
//Calcola la somma e la media dei numeri da 2 a 10.

//int somma = 0;
//int media = 0;

//for (int i = 2; i <= 10; i++)
//{

//    Console.WriteLine(i);
//    somma = i + somma;
//    //5 + 7 = 12
//};

//media = somma / 9;

//Console.WriteLine("somma: " + somma);
//Console.WriteLine();
//Console.WriteLine("media " + media);


//snack 5
//Il software chiede all’utente di inserire un numero. Se il numero inserito è pari,
//stampa il numero, se è dispari, stampa il numero successivo.
//Console.WriteLine("inserisci numero");
//int numUser = Convert.ToInt32(Console.ReadLine());

//if (numUser % 2 == 0)
//{
//    Console.WriteLine(numUser);
//}
//else {
//    Console.WriteLine(numUser + 1);
//}

//snack 6
//In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
//Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

//string[] invited = { "Giovanni", "Mirco", "Paolo", "Giuseppe" };

//Console.WriteLine("nome partecipante");
//string name = Console.ReadLine();
//bool nameList = false;

//for (int i = 0; i < invited.Length; i++)
//{
//    if (invited[i] == name)
//    {
//        nameList = true;
//    }
//    else
//    {
//        nameList = false;
//    }
//}

//if (nameList)
//{
//    Console.WriteLine("puoi entrare");
//} else
//{
//    Console.WriteLine("non puoi entrare");
//}

//snack 7
//Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo
//nell’array.

//int[] numUser = new int[6];
//for (int index = 0; index < 6; index++)
//{
//    Console.WriteLine("dimmi un num");
//    int requestNum = Convert.ToInt32(Console.ReadLine());
//    if (requestNum % 2 != 0)
//    {
//        numUser[index] = requestNum;
//    }
//}

//snack 8
//Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in
//posizione dispari.

//int[] integerNum = { 2, 30, 12, 12, 15, 20, 30, 50};
//int valSomma = 0;

//int arrLength = integerNum.Length;
//for (int index = 0; index < arrLength; index++) {
//    if (index % 2 == 1)
//    {
//        valSomma = valSomma + integerNum[index];
//    }

//}
//Console.WriteLine("La somma è:" + valSomma);

//snack 9
//Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
//somma degli elementi è minore di 50.

//int[] numberUSer = new int[50];


//int i = 0;
//int somma = 0;

//while (somma < 50)
//{
//    Console.WriteLine("dammi dei numeri");
//    int inputUser = Convert.ToInt32(Console.ReadLine());
//    i = inputUser += numberUSer[i];
//    somma += inputUser;
//    Console.WriteLine("La somma attuale è: " + somma);
//    i++;

//}

//snack 10
//Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.

//Console.WriteLine("inserisci numero");
//int inputUser = Convert.ToInt32(Console.ReadLine());

//esercizio giorno 3
//snack 1
//Dare la possibilità di inserire due parole.
Console.WriteLine("inserisci due parole");
Console.WriteLine();
string firstWord = Console.ReadLine();
string secondWord = Console.ReadLine();
wordLength(firstWord, secondWord);

//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.

void wordLength(string arg1, string arg2)
{
    if (arg1 == arg2)
    {
        Console.WriteLine("stampa delle due parole uguali: " + arg1 + arg2);
    }
    else
    {
        if (arg1.Length > arg2.Length)
        {
            Console.WriteLine(arg1);
        }
        else
        {
            Console.WriteLine(arg2);
        }
    }


}


//snack 2
//Quindi chiedere un numero all’utente e comunicargli se è pari o dispari.
Console.WriteLine("inserisci un numero");
Console.WriteLine();
int userNumber = Convert.ToInt32(Console.ReadLine());
evenOdd(userNumber);


//Scrivere una funzione per verificare se un numero è pari o dispari.

void evenOdd(int arg1)
{
    if (arg1 % 2 == 0)
    {
        Console.WriteLine("il tuo numero è pari");
    }
    else
    {
        Console.WriteLine("il tuo numero è dispari");
    }
}