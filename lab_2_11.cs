using System;
using System.Collections.Generic;

namespace Labs_2
{
    class Lab_2_11: ILab{
        private int[,] items = {{2, 4, 12},{8, 1, 89},{ 87, 89, 1},{56, 12, 5}, {12, 87, 2}};

        public override void Do(){
            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();

            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (var item in items){
                int value;
                if (dict.TryGetValue(item, out value)){
                    dict[item] += 1;
                }else{
                    dict[item] = 0;
                }
                
            }

            Console.WriteLine("Result: ");
            foreach(var item in dict){
                Console.Write("{0} ", item.Key);
            }
            Console.WriteLine("\n");
        }

        public override string Description(){
           return @"2.11. Найти все неповторяющиеся элементы двухмерного массива целых чисел.";
        }
    }

}