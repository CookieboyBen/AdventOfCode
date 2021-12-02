using System;

namespace Part1
{
    class Part1
    {
        public static void run(){
            string[] depths = System.IO.File.ReadAllLines("input.txt");
            int increaseCounter = 0, decreaseCounter = 0;
            for (int i = 0; i < depths.Length; i++){
                string increased = "N/A";
                if (i != 0){
                    int depth = Int32.Parse(depths[i]);
                    int lastDepth = Int32.Parse(depths[i-1]);
                    if (depth > lastDepth){
                        increased = "Increased";
                        increaseCounter++;
                    }
                    else if(depth < lastDepth){
                        increased = "Decreased";
                        decreaseCounter++;
                    }
                    else{
                        increased = "N/A";
                    }
                }
                Console.WriteLine("{0} ({1})", depths[i], increased);
            }

            Console.WriteLine("Depth increased {0} times, \nAnd decreased {1} times", increaseCounter, decreaseCounter);
            Console.ReadLine();
        }
    }
}


