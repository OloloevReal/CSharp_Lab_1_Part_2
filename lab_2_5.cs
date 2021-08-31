using System;

namespace Labs_2
{
    class Lab_2_5: ILab{
        public override void Do(){
            Console.WriteLine();
        }

        public override string Description(){
           return @"2.5. В двухмерном массиве целых чисел поменять местами столбцы, симметричные относительно середины массива (вертикальнойлинии).";
        }
    }

}