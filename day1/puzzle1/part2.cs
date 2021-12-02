using System;

namespace Part2
{
    class Part2
    {
        public static void run(){
            string[] depths = System.IO.File.ReadAllLines("input.txt");
            int increaseCounter = 0, decreaseCounter = 0;
            int[] depthWindow = {0, 0, 0};
            int sum = 0, oldSum = 0;
            for (int i = 0; i < depths.Length; i++){
                string increased = "N/A";
                depthWindow[i] = Int32.Parse(depths[i]);
                sum = depthWindow[depthWindow.Length - 1] + depthWindow[depthWindow.Length - 2] + depthWindow[depthWindow.Length - 3];
                if (sum > oldSum){
                    increased = "increased";
                    increaseCounter++;
                }
                else if (sum < oldSum){
                    increased = "decreased";
                }
                else{
                    increased = "N/A";
                }
                Console.WriteLine("{0} {1}", sum, increased);
                oldSum = sum;
                //Console.WriteLine("A {0} B {1} C {2}", depthWindow[0], depthWindow[1], depthWindow[2]);
            }
            Console.WriteLine("Depth increased {0} times, \nAnd decreased {1} times", increaseCounter, decreaseCounter);
        }
    }
}
