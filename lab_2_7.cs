using System;

namespace Labs_2
{
    class Lab_2_7: ILab{

        // i + j = n + 1 - элементы побочной диагонали 
        // i < n - j + 1 - элементы выше
        // i > n - j + 1 - элементы ниже

        private float[,] items;
        private int n = 4;

        public Lab_2_7(){
            this.items = new float[n, n];
            Utils.FillArray(items);
        }
        public override void Do(){
            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();

            float tmp;
            for(int i = 0; i < n - 1; i++){
                for(int j = 0; j < n-i-1; j++){
                    tmp = items[i, j];
                    items[i, j] = items[n - j - 1, n - i - 1];
                    items[n - j - 1, n - i - 1] = tmp;
                }
            }

            Console.WriteLine("Result values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();

        }

        public override string Description(){
           return @"2.7. Поменять местами значения элементов двухмерного массива вещественных чисел, симметричных относительно побочной диагонали.";
        }
    }

}