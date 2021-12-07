using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv ut menyalternativ
            Console.WriteLine("1. integer-lista.");
            Console.WriteLine("2. double-lista.");
            Console.WriteLine("3. Dictionary-exempel.");
            Console.WriteLine("4. Tärningskast med Dictionary.");
            Console.WriteLine("5. Tärningskast med SortedList (Övning 1).");
            Console.WriteLine("6. Queue-exempel.");
            Console.WriteLine("7. Stack-exempel.");
            Console.WriteLine("8. Övning 2");
            Console.WriteLine("9. Övning 3");
            Console.WriteLine("10. Övning 4");

            //Läs in menyval
            Console.Write("Ange siffra för vad du vill göra: ");
            string val = Console.ReadLine();

            //Använd en switch-sats för att anropa den metod som hör ihop med menyvalet.
            switch(val){
                case "1":
                    IntegerLista();
                    break;
                case "2":
                    DoubleLista();
                    break;
                case "3":
                    DictionaryExempel();
                    break;
                case "4":
                    DiceDictionary();
                    break;
                case "5":
                    DiceSortedList();
                    break;
                case "6":
                    QueueExempel();
                    break;
                case "7":
                    StackExempel();
                    break;
                case "8":
                    Övning2();
                    break;
                case "9":
                    Övning3();
                    break;
                case "10":
                    Övning4();
                    break;
            }

            Console.ReadKey();
        }

        static void Övning2()
        {
            //Skapar en lista som heter "övning2" och som har värdet double
            List<double> övning2 = new List<double>(); 

            //Skapar en for metod som gör att programmet innanför den skall upprepas
            for (int i = 0; i < 1000000000; i++)
            {
                //Frågar användaren om värdet på talet som han/hon skall mata in
                Console.Write("Mata in ett tal:");
                //Omvandlar svaret från användaren, från string till double
                double tal = double.Parse(Console.ReadLine());
                //använder mig av if eftersom det skall finnas ett villkor om användaren trycker in talet 0
                if (tal == 0)
                {
                    //Denna rad gör att programmet stängs ner när man matar in 0
                    Environment.Exit(1);
                }
                //Annars, ifall man sätter in andra värden än 0 då skall programmet innanför else satsen köras
                else 
                {
                    //Denna rad gör att talet som blev inmatad av användaren skall lägga till i listan som vi har skapat.
                    övning2.Add(tal);
                    //Denna rad skriver ut svaret av själva programmet. Programmet skall skriva ut medelvärdet av talen i listan. 
                    Console.WriteLine("Medelvärde:" + övning2.Average());
                }
            }
        }

        static void Övning3()
        {
            //skapar en random funktion till programmet
            Random slump = new Random();
            //skapar listan till Övning 3 med string 
            List<string> övning3 = new List<string>();
            
            //skapar en variabel till de 4 olika färgerna men tar även hjälp av array
            var färg = new string[] { "h", "r", "k", "s" };
            
            // skapar en for loop till färgerna
            for (int i = 0; i < 4; i++)
            {
                //lägger till färgerna plus essen i listan
                övning3.Add(färg[i] + "e");
                //skapar en for loop till talen från 2 till 10 i kortleken.
                for (int tal = 2; tal <= 10; tal++)
                {
                    //lägger till färger plus talen från 2 tull 10 i kortleken. 
                    övning3.Add(färg[i] + tal.ToString());
                }
            }
            //skapar en while true tills antalet kort blir 0 kvar
            while( övning3.Count != 0)
            {
                //skapar en variabel som heter random som är koppla till listan som skall slumpa fram alla antal kort
                int random = slump.Next(0, övning3.Count);

                //skapar en output som användaren skall se, typ resultatet av programmet
                Console.WriteLine("Du tog upp kortet:" + övning3[random]);
                //kod för att man skall ta bort det slumpmässiga kortet som man drog innan
                övning3.RemoveAt(random);
            }
        }
        static void Övning4()
        {
            //skapar en random function som heter första_tal
            Random första_tal = new Random();
            //skapar en variabel som heter kort som är en dictionary
            var kort = new Dictionary<string, int>();
            //skapar en variabel till de 4 olika färgerna men tar även hjälp av array
            var färg = new string[] { "h", "r", "k", "s" };
            //skapar en for loop till färgerna
            for (int i= 0; i <=3; i++)
            {
                //lägger till färgerna plus essen i listan samt värdet 1 tillhör essen. Alltså ess = 1
                kort.Add(färg[i] + "e",1);
                //skapar en for loop till talen från 2 till 10 i kortleken.
                for (int tal = 2; tal<= 10; tal++)
                {
                    //lägger till färger plus talen från 2 till 10 i kortleken, samt värdet för respektiv tal ska tillhöra talet, tex. kortet 2 ska ha värdet 2 osv.
                   kort.Add(färg[i] + tal.ToString(),tal);
                }
                //lägger till färgen plus knäckten i listan samt tilläger att knäckten har värdet 11
                kort.Add(färg[i] + "kn", 11);
                //lägger till färgen plus damen i listan samt tilläger att damen har värdet 12
                kort.Add(färg[i] + "d", 12);
                //lägger till färgen plus kungen i listan samt tilläger att kungen har värdet 13
                kort.Add(färg[i] + "k", 13);
            }
            //skapar en variabel som heter nyckel som ska bli en array
            var nyckel = kort.Keys.ToArray();
            //skapar en variabel som heter counter som är lika med 0
            int counter = 0;
            //skapar en for loop till 1000
            for (int i = 0; i <= 1000; i++)
            {
                //skapar den första slump och talet ska fortsätta från noll till arrays längd.
                int första_slump = första_tal.Next(0, nyckel.Length);
                //skapar den andra slump och talet ska fortsätta från noll till arrays längd.
                int andra_slump = första_tal.Next(0, nyckel.Length);
                //skapar if sats där vi antar att första slumpen ska bli lika med andra slumpen
                if (kort[nyckel[första_slump]] == kort[nyckel[andra_slump]])
                {
                    //Ifall första slump talet är lika med andra slump talet då ska man skriva ut "Par"
                    Console.WriteLine("Par!");
                    //den fortsätter räkna med +1 till counter värde
                    counter++;
                }
            }
            //skriver ut resultatet till counter.
            Console.WriteLine(counter);
        }
        static void DictionaryExempel()
        {
            //Skapa en dictionary med string som nyckel och int som värde
            Dictionary<string, int> personer = new Dictionary<string, int>();

            //Lägg till
            personer.Add("Kalle", 10);
            personer.Add("Sven", 12);
            personer.Add("Oskar", 10);
            personer.Add("Viggo", 13);

            Console.WriteLine("Kalles ålder är: " + personer["Kalle"]);

            //"Iterera" genom samlingen
            foreach (KeyValuePair<string, int> kvp in personer)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }
        }

        static void DiceSortedList()
        {
            //Skapa en dictionary med int som nyckel och int som värde
            Dictionary<int, int> resultat = new Dictionary<int, int>();

            //skapa ett Random objekt för att slumpa
            Random random = new Random();

            //Gör tusen upprepnigar
            for (int i = 0; i < 1000; i++)
            {
                //Slumpa tal mellan 1 och 6
                int tal = random.Next(1, 7);

                //Lägg nyckel om denna inte redan finns
                if (!resultat.ContainsKey(tal))
                    resultat.Add(tal, 0);

                //Öka förekomsten av tal
                resultat[tal]++;
            }

            //Visa resultatet
            foreach (KeyValuePair<int, int> kvp in resultat)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }


        }

        static void DiceDictionary()
        {
            //Skapa en dictionary med int som nyckel och int som värde
            Dictionary<int, int> resultat = new Dictionary<int, int>();

            //skapa ett Random objekt för att slumpa
            Random random = new Random();

            //Gör tusen upprepnigar
            for (int i = 0; i < 1000; i++)
            {
                //Slumpa tal mellan 1 och 6
                int tal = random.Next(1, 7);

                //Lägg nyckel om denna inte redan finns
                if (!resultat.ContainsKey(tal))
                    resultat.Add(tal, 0);

                //Öka förekomsten av tal
                resultat[tal]++;
            }

            //Visa resultatet
            foreach (KeyValuePair<int, int> kvp in resultat)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }

        }

        static void QueueExempel()
        {
                Queue<string> nummer = new Queue<string>();
                nummer.Enqueue("ett");
                nummer.Enqueue("två");
                nummer.Enqueue("tre");
                nummer.Enqueue("fyra");
                nummer.Enqueue("fem");

                // "Iteration" utan att ändra innehållet i kön
                foreach (string number in nummer)
                {
                    Console.WriteLine(number);
                }

                // "Iteration" samtidigt som kön töms
                while (nummer.Count > 0)
                {
                    Console.WriteLine(nummer.Dequeue());
                }
        }

        static void StackExempel()
        {
            Stack<string> nummer = new Stack<string>();
            nummer.Push("ett");
            nummer.Push("två");
            nummer.Push("tre");
            nummer.Push("fyra");
            nummer.Push("fem");

            // "Iteration" utan att ändra innehållet i stacken
            foreach (string number in nummer)
            {
                Console.WriteLine(number);
            }

            // "Iteration" samtidigt som stacken töms
            while (nummer.Count > 0)
            {
                Console.WriteLine(nummer.Pop());
            }
        }

        static void IntegerLista()
        {
            //Skapa en lista av int
            List<int> lista = new List<int>();

            //Fyll listan med några enstaka värden
            lista.Add(5);
            lista.Add(15);
            lista.Add(25);

            //Lägg till flera tal samtidigt genom att använda en Array med värden
            lista.AddRange(new int[] { 1, 2, 3, 4, 5, 6 });

            //"Iterera" genom listan och skriv ut varje enskilt värde och index.
            //Indexeringen är precis som med Array men istället för .Length finns det en .Count
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Index: {0} Tal: {1}", i, lista[i]);
            }

            //Undersök om ett visst värde finns i listan
            Console.WriteLine("Finns talet 5 i listan? " + lista.Contains(5));
            Console.WriteLine("Finns talet 7 i listan? " + lista.Contains(7));

            //Ta bort första förekomst av ett värde
            lista.Remove(5);

            //Ta bort värde på ett angivet index
            lista.RemoveAt(3);

            //"Iterera" igen, denna gång med en foreach loop
            foreach (int tal in lista)
            {
                Console.WriteLine("Tal: {0}", tal);
            }
        }

        static void DoubleLista()
        {
            //Skapa en lista av double
            List<double> dLista = new List<double>();

            //Lägg till flera tal samtidigt genom att använda en Array med värden
            dLista.AddRange(new double[] { 3.2, 5.1, 13, 7.4, 8.2, 2.8, 14.1 });

            //Skriv ut lite information om innehållet i listan
            Console.WriteLine("Summan av alla element: " + dLista.Sum());
            Console.WriteLine("Medelvärdet: " + dLista.Average().ToString("0.00"));
            Console.WriteLine("Största värdet: " + dLista.Max());
            Console.WriteLine("Minsta värdet: " + dLista.Min());

            //Vilket index hade det minsta värdet...?
            Console.WriteLine("Minsta värdet fanns på index: " + dLista.IndexOf(dLista.Min()));

            //Sortera listan
            dLista.Sort();

            foreach (double d in dLista)
            {
                Console.WriteLine("Värde: " + d);
            }

        }
    }
}
