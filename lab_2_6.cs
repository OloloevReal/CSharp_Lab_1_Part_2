using System;

namespace Labs_2
{
    class Lab_2_6: ILab{

        private const string Message = "Не удается определить середину массива, кол-во рядов четное.";
        private int[,] items;
        private int col = 6;
        private int row = 5;

        public Lab_2_6(){
            items = new int[col, row];
        }
        public override void Do(){
            Utils.FillArray(this.items);
            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();

            if (row % 2 == 0) {
               throw new Exception(Message);
            }

            for(int i = 0; i < row /2; i++){
                for(int j = 0; j < col; j++){
                    int tmp = items[j, i];
                    items[j, i] = items[j, row - 1 - i];
                    items[j, row - 1 - i] = tmp;
                }
            }

            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();
        }

        public override string Description(){
           return @"2.6. В двухмерном массиве целых чисел поменять местами строки, симметричные относительно середины массива (горизонтальной линии).";
        }
    }

}