using System;

namespace Labs_2
{
    class Lab_2_9: ILab{
        private int[,] items;
        private const int col = 5;
        private const int row  = 6;
        public Lab_2_9(){
            this.items = new int[col,row];
        }
        public override void Do(){
            Utils.FillArray(this.items);
            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();


            Console.WriteLine();
        }

        public override string Description(){
           return @"2.9. Найти максимальный среди минимальных элементов столбцов двухмерного массива целых чисел. Определить номер строки и столбца для такого элемента.";
        }
    }

}