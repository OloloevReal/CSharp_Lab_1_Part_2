using System;

namespace Labs_2
{
    class Lab_2_13: ILab{
        // i + j == n + 1 - элементы побочной диагонали 
        // i == j         - элементы главной диагонали
        private int[,] items;
        private const int col = 4;
        private const int row = 5;
        int SumMainD, SumSlaveD;
        int numMainD, numSlaveD;
        public Lab_2_13(){
            this.items = new int[col,row];
        }
        public override void Do(){
            Utils.FillArray(this.items);
            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();

            SumMainD = SumSlaveD = numMainD = numSlaveD = 0;

            for(int i = 0; i < col; i++){
                for(int j = 0; j < row; j++){
                    if( i == j){
                        SumMainD += items[i, j];
                        numMainD++;
                    }
                    if(i + j == col - 1){
                        SumSlaveD += items[i, j];
                        numSlaveD++;
                    }
                }
            }

            Console.WriteLine("Result: ");
            Console.WriteLine("Main diag: Num: {0}, Sum: {1}, Avg: {2}", numMainD, SumMainD, SumMainD/numMainD);
            Console.WriteLine("Slave diag: Num: {0}, Sum: {1}, Avg: {2}", numSlaveD, SumSlaveD, SumSlaveD/numSlaveD);

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