using System;

namespace Labs_2
{
    class Lab_2_13: ILab{
        private int[,] items;
        private const int col = 5;
        private const int row  = 6;
        public Lab_2_13(){
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
           return @"2.13. Определить:
   - а) сумму элементов главной диагонали массива;
   - б) сумму элементов побочной диагонали массива;
   - в) среднее арифметическое элементов главной диагонали массива;
   - г) среднее арифметическое элементов побочной диагонали массива.";
        }
    }

}