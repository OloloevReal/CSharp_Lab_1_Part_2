using System;

namespace Labs_2
{
    class Lab_2_2: ILab{

        private int[,] items;
        private const int col = 5;
        private const int row = 9;
        private int[] sum;

        public Lab_2_2(){
            this.items = new int[col, row];
            Utils.FillArray(items);
            this.sum = new int[row - 1];                   
        }
        public override void Do(){
            Console.WriteLine("Source values: ");
            Utils.PrintArray(items);

            Console.WriteLine();
            
                for(int j = 1; j < row; j++){
                    for (int i = 0; i < col; i++){
                        if (i + j < row){
                            Console.Write("{0} \t", this.items[i, i + j]);
                            this.sum[j - 1] += this.items[i, i + j];
                        }
                    }
                    Console.Write(" = {0}", this.sum[j - 1]);
                    Console.WriteLine();
                }
            Console.WriteLine();           
        }
        public override string Description(){
           return @"2.2. Найти суммы элементов двухмерного массива целых чисел, расположенных на линиях, параллельных главной диагонали, и ниже ее.";
        }
    }

}