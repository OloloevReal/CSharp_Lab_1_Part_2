using System;
using System.Collections.Generic;

namespace Labs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ILab> Labs = new List<ILab>();
            // Labs.Add(new Lab_2_1());
            // Labs.Add(new Lab_2_2());
            // Labs.Add(new Lab_2_3());
            // Labs.Add(new Lab_2_4());
            // Labs.Add(new Lab_2_5());
            // Labs.Add(new Lab_2_6());
            Labs.Add(new Lab_2_7());
            // Labs.Add(new Lab_2_8());
            
            foreach(ILab l in Labs){
                Console.WriteLine(l.Description());
                l.Do();
            }
        }
    }
}
