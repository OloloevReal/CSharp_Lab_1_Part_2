using System;

namespace Labs_2
{
    class Lab_2_10: ILab{
        private float[,] items;
        private const int col = 5;
        private const int row  = 6;
        public Lab_2_10(){
            this.items = new float[col,row];
        }
        public override void Do(){
            Utils.FillArray(this.items);
            Console.WriteLine("Source values: ");
            Utils.PrintArray(this.items);
            Console.WriteLine();

            float tmpValue = items[0, 0];
            int maxColId = 0;
            for(int i = 0; i < col; i++){
                for(int j = 0; j < row; j++){
                    if(tmpValue < items[i, j]){
                        tmpValue = items[i, j];
                        maxColId = i;
                    }
                }
            }

            float[,] tmpItems = new float[col - 1, row];
            for(int i = 0; i < col; i++){
                for(int j = 0; j < row; j++){
                    if(i < maxColId){
                        tmpItems[i, j] = items[i, j];
                    }else if(i > maxColId){
                        tmpItems[i - 1, j] = items[i, j];
                    }
                }
            }

            items = tmpItems;
            Console.WriteLine("Max element: {0}, column id: {1}", tmpValue, maxColId);
            Console.WriteLine("Result values: ");
            Utils.PrintArray(items);
            Console.WriteLine();
        }

        public override string Description(){
           return @"2.10. Удалить столбец двухмерного массива вещественных чисел, в котором находится максимальный элемент этого массива.";
        }
    }

}