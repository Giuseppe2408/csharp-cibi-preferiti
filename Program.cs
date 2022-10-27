// See https://aka.ms/new-console-template for more information
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
//}
//else
//{
//    Console.WriteLine(secondWord);
//}

//snack 3
//Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.

//int somma = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("inserisci num");
//    int num = Convert.ToInt32(Console.ReadLine());
//    int sum = somma += num;
//    Console.WriteLine(sum);

//}

//snack 4 
//Calcola la somma e la media dei numeri da 2 a 10.

//int somma = 0;
//int i = 0;


//for (; i < 10; i++)
//{
//    int index = i + 1;
//    Console.WriteLine(index);
//    int sum = index += somma;
//    Console.WriteLine("somma:" + sum);
//};


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

int[] numUser = new int[6];
for (int index = 0; index < 6; index++)
{
    Console.WriteLine("dimmi un num");
    int requestNum = Convert.ToInt32(Console.ReadLine());
    if (requestNum % 2 != 0)
    {
        numUser[index] = requestNum;
        Console.WriteLine(numUser[index]);
    }
    
}

