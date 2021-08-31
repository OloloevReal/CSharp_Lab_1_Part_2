using System;

namespace Labs_2
{
    class Lab_2_4: ILab{

        private double[,] items;
        private const int col = 6;
        private const int row = 5;
        public override void Do(){

        }

        public override string Description(){
           return @"2.4. В двухмерном массиве вещественных чисел поменять местами строки и столбцы с одинаковыми номерами.";
        }
    }

}