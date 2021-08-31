using System;

namespace Labs_2
{
    class Lab_2_5: ILab{
        private const string Message = "Не удается определить середину массива, кол-во колонок четное.";
        private int[,] items;
        private int col = 5;
        private int row = 6;

        public Lab_2_5(){
            items = new int[col, row];
        }
        public override void Do(){
            Utils.FillArray(this.items);
            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);

            if (col % 2 == 0) {
               throw new Exception(Message);
            }

            for(int i = 0; i < col / 2; i++){
                for(int j = 0; j < row; j++){
                    int tmp = items[i, j];
                    items[i, j] = items[col - 1 - i, j];
                    items[col - 1 - i, j] = tmp;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Result values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();
        }

        public override string Description(){
           return @"2.5. В двухмерном массиве целых чисел поменять местами столбцы, симметричные относительно середины массива (вертикальной линии).";
        }
    }

}