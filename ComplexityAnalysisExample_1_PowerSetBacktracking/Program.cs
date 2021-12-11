using System;
using System.Collections.Generic;


namespace ComplexityAnalysisExample_1_PowerSetBacktracking
{
    class Program
    {
        static void PrintSet(Stack<int> set)
        {
            foreach (int element in set)
                Console.Write("{0} ", element);
            Console.WriteLine();
        }
        static void SubsetUtility( int[] set, Stack<int> subset, int index)
        {
            PrintSet(subset);
            for(int i=index; i< set.Length; i++)
            {
                subset.Push(set[i]);
                SubsetUtility(set, subset, i + 1);
                Console.WriteLine("Popped: "+subset.Pop());
            }
            
            return;
        }
        static void Main(string[] args)
        {
            int index = 0;
            int[] set = {1,2 ,3, 4};
            Stack<int> subset = new Stack<int>(set.Length);

            SubsetUtility(set, subset, index);
            Console.ReadKey();
        }
    }
}
