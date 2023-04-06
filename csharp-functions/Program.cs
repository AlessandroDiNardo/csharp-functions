// See https://aka.ms/new-console-template for more information

 namespace Snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Snacks1();
        }

        //1. void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]
        public static void Snacks1()
        {
            Console.WriteLine("Snack1: ");
            int[] arrNum = { 12, 23, 34, 45, 56, 67, 78, 89, 90, 101};
            StampaArray(arrNum);

            void StampaArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Elemento {i + 0}: {array[i]}");
                }
            }
        }
    }
}