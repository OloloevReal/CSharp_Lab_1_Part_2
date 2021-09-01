using System;

namespace Labs_2
{
    class Lab_2_8: ILab{
        private int[,] items;
        private const int col = 5;
        private const int row  = 6;

        private int colMax;
        private int rowMax;
        private int MaxMin;

        public Lab_2_8(){
            this.items = new int[col,row];
        }
        public override void Do(){
            colMax = rowMax = MaxMin = int.MinValue;

            Utils.FillArray(this.items);
            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();

            for (int j = 0; j < row; j++){
                int tmpMin = this.items[0, j];
                int tmpX = 0;
                for(int i = 0; i < col; i++){
                    if(tmpMin > this.items[i, j]){
                        tmpMin = this.items[i, j];
                        tmpX = i;
                    }
                }
                if(tmpMin > MaxMin){
                    this.MaxMin = tmpMin;
                    this.colMax = tmpX;
                    this.rowMax = j;
                }
            }

            Console.WriteLine("Result: ");
            Console.WriteLine("{{{0}, {1}}} MaxMin: {2}", this.colMax, this.rowMax, this.MaxMin);
            Console.WriteLine();

        }

        public override string Description(){
           return @"2.8. Найти максимальный элемент среди минимальных элементов строк двухмерного массива целых чисел. Определить номер строки и столбца для такого элемента.";
        }
    }

}