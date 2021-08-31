using System;

namespace Labs_2
{
    class Lab_2_8: ILab{
        public override void Do(){
            Console.WriteLine();
        }

        public override string Description(){
           return @"2.8. Найти максимальный элемент среди минимальных элементов строк двухмерного массива целых чисел. Определить номер строки и столбца для такого элемента.";
        }
    }

}