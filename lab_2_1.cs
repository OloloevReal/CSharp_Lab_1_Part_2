using System;

namespace Labs_2
{
    class Lab_2_1: ILab{

        // Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
        // гипотенуза - растояние между двумя координатами на плоскости
        private int[,] items = {{0,1},{1,0},{3,5},{2,9},{8,0},{7,-2}};
        private int max_item_1;
        private int max_item_2;
        private double max_len;
        public override void Do(){
            Console.WriteLine("Source values (X, Y): ");
            //foreach()

            for (int i = 0; i < items.GetLength(0); i++){
                Console.Write("{{{0}, {1}}}\t", items[i,0], items[i,1]);
            }
            Console.WriteLine();

            for (int i = 0; i < items.GetLength(0); i++){
                // j = i исключаем повторный подсчет, обратный путь
                for (int j = i; j < items.GetLength(0); j++){
                    if (i != j){
                        double len = CalcLength(items[i, 0], items[i, 1], items[j, 0], items[j, 1]);
                        if(len > max_len) {
                            max_len = len; 
                            max_item_1 = i; 
                            max_item_2 = j;
                        };
                        //Console.WriteLine("{0}, {1} => {2}, {3} = {4}", items[i, 0], items[i, 1], items[j, 0], items[j, 1], len);
                    }
                }
            }

            Console.WriteLine("Max len: {{{0}, {1}}} => {{{2}, {3}}} = {4}\r\n", items[max_item_1, 0], items[max_item_1, 1], items[max_item_2, 0], items[max_item_2, 1], max_len);
        }

        private double CalcLength(int x1, int y1, int x2, int y2) => Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1,2));

        public override string Description(){
           return @"2.1. Точки на плоскости заданы координатами х и у, которые хранятся в двумерном массиве. Найти пару самых удаленных друг от друга точек.";
        }
    }

}