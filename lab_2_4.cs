using System;

namespace Labs_2
{
    class Lab_2_4: ILab{

        // только для квадратной матрицы?

        private double[,] items;
        private const int N = 4;
        public Lab_2_4(){
            items = new double[N,N];
        }
        public override void Do(){
            Utils.FillArray(this.items);
            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();
            
            for(int i = 0; i < N; i++){
                for(int j = i; j < N; j++){
                    double tmp = this.items[j, i];
                    this.items[j, i] = this.items[i, j];
                    this.items[i, j] = tmp;
                }
            }

            Console.WriteLine("Result values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();
        }

        public override string Description(){
           return @"2.4. В двухмерном массиве вещественных чисел поменять местами строки и столбцы с одинаковыми номерами.";
        }
    }

}