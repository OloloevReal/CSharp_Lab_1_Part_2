using System;

namespace Labs_2
{
    static class Utils{
        // public static void FillArray(int[,] items){
        //     Random rand = new Random(DateTime.Now.Millisecond);
        //     for (int i = 0; i < items.GetLength(0); i++){
        //         for(int j = 0; j < items.GetLength(1); j++){
        //             items[i, j] = rand.Next(100);
        //         }
        //     }
        // }
        public static void FillArray(int[,] items){
            Random rand = new Random(DateTime.Now.Millisecond);
            _fillarray<int>(items, ()=>rand.Next(100));
        }

        public static void FillArray(double[,] items){
            Random rand = new Random(DateTime.Now.Millisecond);
            _fillarray<double>(items, ()=>rand.Next(100) * rand.NextDouble());
        }

        private static void _fillarray<T>(T[,] items, Func<T> f){
            for (int i = 0; i < items.GetLength(0); i++){
                for(int j = 0; j < items.GetLength(1); j++){
                    items[i, j] = f();
                }
            }
        }

        public static void PrintArray<T>(T[,] items){
            for (int j = 0; j < items.GetLength(1); j++){
                for(int i = 0; i < items.GetLength(0); i++){
                    Console.Write("{0}\t", items[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}