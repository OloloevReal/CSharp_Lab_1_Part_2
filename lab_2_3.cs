using System;

namespace Labs_2
{
    class Lab_2_3: ILab{

        private int[,] items;
        private const int col = 6;
        private const int row = 5;

        private float maxAvgValue;
        private int maxAvgCol;

        public Lab_2_3(){
            items = new int[col,row];
            // avg = new float[col];
            Utils.FillArray(items);
        }
        public override void Do(){
            maxAvgValue = 0;
            maxAvgCol = 0;
            Console.WriteLine("Source values: ");
            Utils.PrintArray(items);
            Console.WriteLine();
           
            for(int i = 0; i < col; i++){
                int tmp = 0;
                for(int j = 0; j < row; j++){
                    tmp+=items[i, j];
                }
                float colAvg = tmp / col;
                Console.Write("{0} ", colAvg);
                if(colAvg > maxAvgValue){
                    maxAvgValue = colAvg;
                    maxAvgCol = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Max average value: {0}, column id: {1}", maxAvgValue, maxAvgCol);
            Console.WriteLine();
        }

        public override string Description(){
           return @"2.3. Найти номер столбца двухмерного массива целых чисел, для которого среднеарифметическое значение его элементов максимально.";
        }
    }

}