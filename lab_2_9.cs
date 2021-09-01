using System;

namespace Labs_2
{
    class Lab_2_9 : ILab
    {
        private int[,] items;
        private const int col = 5;
        private const int row = 6;

        private int colMax;
        private int rowMax;
        private int MaxMin;
        public Lab_2_9()
        {
            this.items = new int[col, row];
        }
        public override void Do()
        {
            Utils.FillArray(this.items);
            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();
            

            colMax = rowMax = 0;
            MaxMin = int.MinValue;
            int tmpValue;
            int tmpRowId = 0;

            for (int i = 0; i < col; i++){
                tmpValue = items[i, 0];
                for (int j = 0; j < row; j++){
                    if (tmpValue > items[i, j]){
                        tmpValue = items[i, j];
                        tmpRowId = j;
                    }
                }
                if(MaxMin < tmpValue){
                    MaxMin = tmpValue;
                    colMax = i;
                    rowMax = tmpRowId;
                }
            }

            Console.WriteLine("Result: ");
            Console.WriteLine("{{{0}, {1}}} MaxMin: {2}", this.colMax, this.rowMax, this.MaxMin);
            Console.WriteLine();
        }

        public override string Description()
        {
            return @"2.9. Найти максимальный среди минимальных элементов столбцов двухмерного массива целых чисел. Определить номер строки и столбца для такого элемента.";
        }
    }

}