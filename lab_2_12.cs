using System;

namespace Labs_2
{
    class Lab_2_12: ILab{
        private int[,] items;
        private const int N = 10;
        public Lab_2_12(){
            this.items = new int[N,N];
        }
        public override void Do(){
            // Utils.FillArray(this.items);
            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);
            // Console.WriteLine();

            for(int i = 0; i < items.Length; i++){

            }

            Console.WriteLine("Result: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();
        }

        public override string Description(){
           return @"2.12. Заполнить двухмерный массив целыми числами от 1 до 100 по спирали.";
        }
    }

}