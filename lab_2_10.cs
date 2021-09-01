using System;

namespace Labs_2
{
    class Lab_2_10: ILab{
        private int[,] items;
        private const int col = 5;
        private const int row  = 6;
        public Lab_2_10(){
            this.items = new int[col,row];
        }
        public override void Do(){
            // Utils.FillArray(this.items);
            // Console.WriteLine("Source values: ");
            // Utils.PrintArray(this.items);
            // Console.WriteLine();


            Console.WriteLine();
        }

        public override string Description(){
           return @"2.10. Удалить столбец двухмерного массива вещественных чисел, в котором находится максимальный элемент этого массива.";
        }
    }

}