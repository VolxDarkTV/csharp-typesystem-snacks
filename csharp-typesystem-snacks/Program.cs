using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Piccoli Snack!");


            //Snack 1

            //int first = Convert.ToInt32(Console.ReadLine());
            //int second = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine($"Tra {first} & {second} è maggiore {GetMax(first, second)}");



            //Snack 2

            //String firstWord = Console.ReadLine();
            //String secondWord = Console.ReadLine();



            //if (firstWord.Length == secondWord.Length)
            //{
            //    Console.WriteLine($"Hanno lunghezzauguale {firstWord} {secondWord}");
            //}
            //else if (firstWord.Length > secondWord.Length)
            //{

            //    Console.WriteLine($"Tra {secondWord} & {firstWord} è maggiore {firstWord}");
            //}
            //else
            //{
            //    Console.WriteLine($"Tra {firstWord} & {secondWord} è maggiore {secondWord}");
            //}



            //Snack 3
            //int sum = 0;
            //for(int i=0; i<10; i++)
            //{
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    sum += number;
            //}
            //    Console.WriteLine($"{sum}");




            //Snack 4

            //int sum = 0;

            //for(int i = 2; i <= 10; i++)
            //{
            //    sum += i;
            //}
            //double average = (double)sum / 9;
            //Console.WriteLine("La somma dei numeri da 2 a 10 è: " + sum);
            //Console.WriteLine("La media dei numeri da 2 a 10 è: " + average);



            //Snack 5

            //int number = Convert.ToInt32(Console.ReadLine());

            ////Dispari
            //if (number % 2 != 0)
            //{
            //    Console.WriteLine($"Numero: {number + 1}");
            //}
            //else
            //{
            //    Console.WriteLine($"Numero: {number}");
            //}




            //Snack 6

            //String[] partyList = { "Vincenzo", "Gloria", "Giovanni", "Giacomo", "Davide", "Elena" };

            //Console.WriteLine("Name: ");

            //String name = Console.ReadLine();
            //bool invitato = false;

            //foreach (String party in partyList)
            //{
            //    if (party.ToLower() == name.ToLower())
            //    {
            //        invitato = true;
            //        break;
            //    }
            //}

            //if (invitato)
            //    Console.WriteLine("sei dentro");
            //else 
            //    Console.WriteLine("Non sei invitato");


            //Snack 7 Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

            //int[] oddNumbers = new int[0];


            //for (int i = 0; i < 6; i++)
            //{
            //    Console.WriteLine("Inserisci 6 numeri: ");
            //    int userNumber = Convert.ToInt32(Console.ReadLine());

            //    if (userNumber % 2 != 0)
            //    {

            //        int[] nuovoArray = new int[oddNumbers.Length + 1];

            //        for (int j = 0; j < oddNumbers.Length; j++)
            //        {
            //            nuovoArray[j] = oddNumbers[j];
            //        }

            //        nuovoArray[oddNumbers.Length] = userNumber;
            //        oddNumbers = nuovoArray;
            //    }
            //}
            //// stampa dell'array contenente solo i numeri dispari
            //Console.WriteLine("Numeri dispari inseriti:");
            //foreach (int n in oddNumbers)
            //{
            //    Console.Write(n + " ");
            //}

            //Snack 8 Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

            //int[] evenNumbers = { 1, 2, 3, 4, 5, 6, 7 };

            //int oddSum = 0;

            //for (int i = 0; i < evenNumbers.Length; i++)
            //{
            //    if(i % 2 != 0)
            //    {
            //        oddSum += evenNumbers[i];
            //    }
            //}

            //Console.WriteLine($"La somma è: {oddSum}");


            //Snack 9 Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

            int[] numbers = new int[0];

            int sum = 0;

            while (sum < 50)
            {
                Console.WriteLine($"Inserisci numeri somma max 50: ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());

                // creazione di un nuovo array con un elemento in più rispetto a quello originale
                int[] nuovoArray = new int[numbers.Length + 1];

                for(int i = 0; i < numbers.Length; i++)
                {
                    nuovoArray[i] = numbers[i];
                }

                nuovoArray[numbers.Length] = inputNumber;

                numbers = nuovoArray;

                sum += inputNumber;
            }

            Console.WriteLine("Array completo: ");
            foreach (var item in numbers)
            {
                Console.WriteLine(item + " ");
            }
            
            Console.WriteLine("La somma degli elementi è: " + sum);


        }

        //Snack 1
        //public static int GetMax(int first, int second)
        //{
        //    return first > second ? first : second;
        //}





    }
}