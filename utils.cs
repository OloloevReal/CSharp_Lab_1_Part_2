using System;

namespace Labs_2
{
    static class Utils{
        public static void FillArray(int[,] items){
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < items.GetLength(0); i++){
                for(int j = 0; j < items.GetLength(1); j++){
                    items[i, j] = rand.Next(100);
                }
            }
        }

        public static void PrintArray(int[,] items){
            for (int j = 0; j < items.GetLength(1); j++){
                for(int i = 0; i < items.GetLength(0); i++){
                    Console.Write("{0}\t", items[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}