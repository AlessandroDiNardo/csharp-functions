// See https://aka.ms/new-console-template for more information

 namespace Snacks
{
    internal class Program
    {
        static void Main()
        {
        /* Snacks1();
           Snacks2();
           Snacks3();
           Snacks4(); */
           Snacks5();
        }

        //5. Snacks5
        public static void Snacks5()
        {
            Console.WriteLine("Snack5: ");
            Console.WriteLine("Inserisci Lunghezza Array: "); //Chiedo all'utente di inserire un numero per la capacità dell'array
            int lungArr  = Convert.ToInt32(Console.ReadLine());
            int[] numArr = new int[lungArr]; // viene creato un nuovo array vuoto con quella dimensione inserita dall'utente e viene memorizzato nella variabile numArr

            Console.WriteLine("Inserisci " + lungArr + " numeri nell'array:"); 
            for (int i = 0; i < lungArr; i++) // ciclo for per inserire n numeri in base alla lunghezza da lui inserita
            {
                 numArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");

            //Richiamo funzione per la stampa dell'array con la lunghezzza inserita e con i numeri inseriti dall'utente
            StampaArray("Array Originale", numArr);
            Console.WriteLine("");

            // Richiamo la funzione per elevare al quadrato gli elementi dell'array e salvandolo in nuovo array che viene stampato mostrando anche la stampa dell'array originale che non ' stato modificato
            int[] newArr = ElevaArrayAlQuadrato(numArr);
            StampaArray("Array Modificato", newArr);
            Console.WriteLine("");
            StampaArray("Array Originale non modificato", numArr);
            Console.WriteLine("");

            //Somma di tutti gli elementi dell'array
            int sum = SommaElementiArray(numArr);
            Console.WriteLine("Somma elementi Array Originale: " + sum);

            //Viene fatto il quadrato degli elementi dell'array e poi vengono sommati
            Console.WriteLine("Somma elementi Array Modificato: " + SommaElementiArray(ElevaArrayAlQuadrato(newArr)));
        }


        //funzione del BONUS

        //Funzione stampa array
        public static void StampaArray(string title, int[] array) //funzione per la stampa dell'array che ha come parametro un array di interi
        {
            Console.Write(title + "[");
            for (int i = 0; i < array.Length; i++) //Ciclo per Stampare ogni elemento all'interno dell'array
            {
                Console.Write(array[i]);
                if( i < array.Length - 1 )
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }

        //Funzione Quadrato singolo elemento
        public static int Quadrato(int n) //Funzione per calcolare il quadrato che ha come argomento un variabile N
        {
            int res = n * n; //Calcolo del quadrato del numero inserito
            return res;
        }

        //Funzione quadrato degli elementi dell'array
        public static int[] ElevaArrayAlQuadrato(int[] array) //Funzione per calcolare il quadrato degli elementi all'interno dell'array clonato
        {
            int[] copiaArr = (int[])array.Clone(); //Clono l'array orinale
            for (int i = 0; i < copiaArr.Length; i++) //Ciclo per calcolare il quadrato di tutti gli elementi dell'array clonato
            {
                copiaArr[i] = Quadrato(copiaArr[i]);
            }
            return copiaArr;
        }

        //Funzione somma degli elementi dell'array
        static int SommaElementiArray(int[] array) //Funzione per la somma degli elementi all'interno dell'array
        {
            int sum = 0;

            for (var i = 0; i < array.Length; i++) //ciclo per far stampare il risultato sommando i numeri all'interno dell'array
            {
                sum += array[i]; //somma dei numeri
            }
            return sum;
        }
    }
}