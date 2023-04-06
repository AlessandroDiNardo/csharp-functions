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

        //1. void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]
        public static void Snacks1()
        {
            Console.WriteLine("Snack1: ");
            int[] arrNum = { 12, 23, 34, 45, 56, 67, 78, 89, 90, 101}; //creo un array di interi
            StampaArray(arrNum); //richiamo funzione per stampa array che ha come parametro l'array dichiarato

            static void StampaArray(int[] array) //funzione per la stampa dell'array che ha come parametro un array di interi
            {
                for (int i = 0; i < array.Length; i++) //Ciclo per Stampare ogni elemento all'interno dell'array
                {
                    Console.WriteLine($"Elemento {i + 0}: {array[i]}");
                }
            }
            Console.WriteLine("");
        }


        //2. int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
        public static void Snacks2()
        {
            Console.WriteLine("Snacks2:");
            Console.WriteLine("Inserisci un numero: "); //Viene chiesto all'utente di inserire un numero
            int num = Convert.ToInt32(Console.ReadLine());
            Quadrato(num); // Richiamo funzione per la stampa del risultato che ha come argomento il numero inserito

            static int Quadrato(int n) //Funzione per calcolare il quadrato che ha come argomento un variabile N
            {
                int res = n * n; //Calcolo del quadrato del numero inserito
                Console.WriteLine($"Risultato:{res}");
                return res;
            }
            Console.WriteLine("");
        }


        //3. int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato. Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! 
        public static void Snacks3()
        {
            Console.WriteLine("Snacks3: ");
            int[] numArr = { 2, 3, 4, 5, };
            StampaArray(numArr); //Richiamo funzione per la stampa dell'array originale
            ElevaArrayAlQuadrato(numArr); //Richiamo funzione per il calcolo del quadrato dell'array clonato

            static void StampaArray(int[] array) //funzione per la stampa dell'array che ha come parametro un array di interi
            {
                Console.WriteLine("Array originale:");
                for (int i = 0; i < array.Length; i++) //Ciclo per Stampare ogni elemento all'interno dell'array
                {
                    Console.WriteLine($"Elemento {i + 0}: {array[i]}");
                }
                Console.WriteLine("");
            }

            static int[] ElevaArrayAlQuadrato(int[] array) //Funzione per calcolare il quadrato degli elementi all'interno dell'array clonato
            {
                Console.WriteLine("Nuovo array:");
                int[] copiaArr = (int[]) array.Clone(); //Clono l'array orinale
                for (int i = 0; i < copiaArr.Length; i++) //Ciclo per calcolare il quadrato di tutti gli elementi dell'array clonato
                {
                    int res = copiaArr[i] * copiaArr[i];
                    Console.WriteLine($"Elemento {i + 0}: {res}");
                }
                Console.WriteLine("");
                return copiaArr;
            }
        }


        //4. int sommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
        public static void Snacks4()
        {
            Console.WriteLine("Snacks4: ");
            int[] numArr = { 12, 23, 34, 45, 56, 67, 78, 89, 90, 101 };
            StampaArray(numArr); //Richiamo funzione per la stampa dell'array originale
            SommaElementiArray(numArr); //Richiamo la funzione per la stampa del risultato della sommma

            static void StampaArray(int[] array) //funzione per la stampa dell'array che ha come parametro un array di interi
            {
                Console.WriteLine("Array:");
                for (int i = 0; i < array.Length; i++) //Ciclo per Stampare ogni elemento all'interno dell'array
                {
                    Console.WriteLine($"Elemento {i + 0}: {array[i]}");
                }
                Console.WriteLine("");
            }

            static int SommaElementiArray(int[] array) //Funzione per la somma degli elementi all'interno dell'array
            {
                int sum = 0;

                for (var i = 0; i < array.Length; i++) //ciclo per far stampare il risultato sommando i numeri all'interno dell'array
                {
                    sum += array[i]; //somma dei numeri
                }

                Console.WriteLine($"Il risultato della somma degli elementi è: {sum}");
                return sum;
            }
        }



        //5. Snacks5
        public static void Snacks5()
        {
            Console.WriteLine("Inserisci Lunghezza Array: "); //Chiedo all'utente di inserire un numero per la capacità dell'array
            int lungArr  = Convert.ToInt32(Console.ReadLine());
            int[] numArr = new int[lungArr]; // viene creato un nuovo array vuoto con quella dimensione inserita dall'utente e viene memorizzato nella variabile numArr

            Console.WriteLine("Inserisci " + lungArr + " numeri nell'array:"); 
            for (int i = 0; i < lungArr; i++) // ciclo for per inserire n numeri in base alla lunghezza da lui inserita
            {
                 numArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");

            StampaArray(numArr);
            StampaElevaArrayAlQuadrato(numArr);
            SommaElementiArray(numArr);
            ElevaArrayAlQuadrato(numArr);

            static void StampaArray(int[] array) //funzione per la stampa dell'array che ha come parametro un array di interi
            {
                Console.WriteLine("1. Stampa dell'array");
                for (int i = 0; i < array.Length; i++) //Ciclo per Stampare ogni elemento all'interno dell'array
                {
                    Console.WriteLine($"Elemento {i + 0}: {array[i]}");
                }
                Console.WriteLine("");
            }

            static int[] StampaElevaArrayAlQuadrato(int[] array) //funzione per la stampa dell'array che ha come parametro un array di interi
            {
                Console.WriteLine("2. Stampa dell'array originale e calcolo del qaudrato dei numeri all'itnerno del nuovo array creato");
                Console.WriteLine("Array originale: ");
                for (int i = 0; i < array.Length; i++) //Ciclo per Stampare ogni elemento all'interno dell'array
                {
                    Console.WriteLine($"Elemento {i + 0}: {array[i]}");
                }

                Console.WriteLine("Nuovo array:");
                int[] copiaArr = (int[])array.Clone(); //Clono l'array orinale
                for (int i = 0; i < copiaArr.Length; i++) //Ciclo per calcolare il quadrato di tutti gli elementi dell'array clonato
                {
                    int res = copiaArr[i] * copiaArr[i];
                    Console.WriteLine($"Elemento {i + 0}: {res}");
                }
                Console.WriteLine("");
                return copiaArr;
            }


            static int SommaElementiArray(int[] array) //Funzione per la somma degli elementi all'interno dell'array
            {
                Console.WriteLine("3. Somma elementi dell'array");
                int sum = 0;

                for (var i = 0; i < array.Length; i++) //ciclo per far stampare il risultato sommando i numeri all'interno dell'array
                {
                    sum += array[i]; //somma dei numeri
                }

                Console.WriteLine($"Il risultato della somma degli elementi è: {sum}");
                Console.WriteLine("");
                return sum;
            }

            static int[] ElevaArrayAlQuadrato(int[] array) //Funzione per calcolare il quadrato degli elementi all'interno dell'array clonato
            {
                Console.WriteLine("4. Calcolo quadrato elementi dell'array");
                for (int i = 0; i < array.Length; i++) //Ciclo per calcolare il quadrato di tutti gli elementi dell'array clonato
                {
                    int res = array[i] * array[i];
                    Console.WriteLine($"Elemento {i + 0}: {res}");
                }
                Console.WriteLine("");
                return array;
            }
        }
    }
}