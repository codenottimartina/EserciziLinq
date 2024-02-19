using System.Linq;
// lista di stringhe
//var stringhe = new List<string>()
//{
//    "aaa",
//    "aaa",
//    "aaa",
//    "aaa",
//    "aaa"
//};

//var stringhe2 = new List<string>()
//{
//    "ok",
//    "ok",
//    "ok",
//    "no"
//};

//Console.WriteLine("Lista stringhe 1:");
//Utilities.StampaListaStringhe(stringhe);
//if (Utilities.ControlloStringheTutteUguali(stringhe))
//{
//    Console.WriteLine("Le stringhe sono tutte uguali");
//}
//else
//{
//    Console.WriteLine("Le stringhe non sono tutte uguali");
//}

//Console.WriteLine("Lista stringhe 2:");
//Utilities.StampaListaStringhe(stringhe2);
//if (Utilities.ControlloStringheTutteUguali(stringhe2))
//{
//    Console.WriteLine("Le stringhe sono tutte uguali");
//}
//else
//{
//    Console.WriteLine("Le stringhe non sono tutte uguali");
//}

//stringhe = Utilities.DuplicaStringhe(stringhe);
//stringhe2 = Utilities.DuplicaStringhe(stringhe2);
//Console.WriteLine("Lista stringhe 1:");
//Utilities.StampaListaStringhe(stringhe);
//Console.WriteLine("Lista stringhe 2:");
//Utilities.StampaListaStringhe(stringhe2);

//Console.WriteLine("Lunghezza totale stringhe 1: " + Utilities.CalcolaLunghezzaTotaleStringhe(stringhe));
//Console.WriteLine("Lunghezza totale stringhe 2: " + Utilities.CalcolaLunghezzaTotaleStringhe(stringhe2));
//public class Utilities
//{
//    // Verificare se tutte le stringhe contenute in una list sono uguali. Restituisce true se lo sono, false altrimenti.
//    public static bool ControlloStringheTutteUguali(List<string> stringhe)
//    {
//        return stringhe
//            .Aggregate(true, (res, str) => res && str.Equals(stringhe.First()));
//    }

//    // Duplica ogni stringa della list
//    public static List<string> DuplicaStringhe(List<string> stringhe)
//    {
//        return stringhe
//            .Select(str => $"{str}{str}")
//            .ToList();
//    }

//    // Restituisce la lunghezza totale di tutte le stringhe della lista
//    public static int CalcolaLunghezzaTotaleStringhe(List<string> stringhe)
//    {
//        return stringhe
//            .Sum(str => str.Length);
//    }

//    public static void StampaListaStringhe(List<string> stringhe)
//    {
//        foreach(string str in stringhe)
//        {
//            Console.WriteLine(str);
//        }
//    }
//}

// list di interi

var numeri = new List<int>()
{
    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 16, 24, 33
};

var numeri2 = new List<int>()
{
    7, 9, 10, 11, 12, 1
};

Console.WriteLine("Lista di numeri 1:");
Utilities.StampaListaInteri(numeri);
Console.WriteLine("Lista di numeri 2:");
Utilities.StampaListaInteri(numeri2);

Console.WriteLine("Lista di numeri 1 max = " +  numeri.Max());
Console.WriteLine("Lista di numeri 2 max = " +  numeri2.Max());
Console.WriteLine("Lista di numeri 1 somma = " +  numeri.Sum());
Console.WriteLine("Lista di numeri 2 somma = " +  numeri2.Sum());

var numeriMaggioriDi5 = Utilities.NumeriMaggioriDi5(numeri);
var numeri2MaggioriDi5 = Utilities.NumeriMaggioriDi5(numeri2);

Console.WriteLine("Lista di numeri 1 maggiori di 5:");
Utilities.StampaListaInteri(numeriMaggioriDi5);
Console.WriteLine("Lista di numeri 2 maggiori di 5:");
Utilities.StampaListaInteri(numeri2MaggioriDi5);

var numeriMultipliDi4 = Utilities.NumeriMultipliDi4(numeri);
var numeri2MultipliDi4 = Utilities.NumeriMultipliDi4(numeri2);

Console.WriteLine("Lista di numeri 1 multipli di 4:");
Utilities.StampaListaInteri(numeriMultipliDi4);
Console.WriteLine("Lista di numeri 2 multipli di 4:");
Utilities.StampaListaInteri(numeri2MultipliDi4);

Utilities.ContieneNumeriMaggioriDiN(30, numeri);
Utilities.ContieneNumeriMaggioriDiN(30, numeri2);

var numeriMaggiori3Decrescenti = Utilities.ListaOrdineDecrescenteSoloMaggioreDi3(numeri);
var numeri2Maggiori3Decrescenti = Utilities.ListaOrdineDecrescenteSoloMaggioreDi3(numeri2);

Console.WriteLine("Lista di numeri 1 maggiori di 3 in ordine decrescente:");
Utilities.StampaListaInteri(numeriMaggiori3Decrescenti);
Console.WriteLine("Lista di numeri 2 maggiori di 3 in ordine decrescente:");
Utilities.StampaListaInteri(numeri2Maggiori3Decrescenti);

public class Utilities
{

    // Restitusice la lista con solo i numeri maggiori di 5
    public static List<int> NumeriMaggioriDi5(List<int> numeri)
    {
        return numeri
            .Where(num => num > 5)
            .ToList();
    }

    // Restituisce una lista con solo i multipli di 4
    public static List<int> NumeriMultipliDi4(List<int> numeri)
    {
        return numeri
            .Where(num => num % 4 == 0)
            .ToList();
    }

    // Stampa una stringa in base se la lista contiene almeno un numero maggiore di n
    public static void ContieneNumeriMaggioriDiN(int n, List<int> numeri)
    {
        if (numeri.Any(num => num > n))
        {
            Console.WriteLine("Nella lista di numeri 1 ci sono valori maggiori di " + n);
        }
        else
        {
            Console.WriteLine("Nella lista di numeri 2 non ci sono valori maggiori di " + n);
        }
    }

    // Ordina la lista in ordine decrescente e contiene solo i numeri maggiori di 3
    public static List<int> ListaOrdineDecrescenteSoloMaggioreDi3(List<int> numeri)
    {
        return numeri
            .Where(num => num > 3)
            .OrderBy(num => num)
            .Reverse()
            .ToList();
    }

    // Stampa la lista di numeri
    public static void StampaListaInteri(List<int> numeri)
    {
        foreach (int num in numeri)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}