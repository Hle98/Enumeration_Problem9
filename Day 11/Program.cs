using System;
using System.Collections.Generic;

namespace Day_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var ls = new List<string> { "A", "B","C"};
            Subsets(ls);
        }
        static void Subsets(List<string> ls)
        {
            var results = new List<string>();
            Console.WriteLine("Using Subsets1");
            Subsets1(ls, results,2);
            Console.WriteLine("Using Subsets2");
            Subsets2(ls, results, 2);
            Console.WriteLine("Using Subsets3");
            Subsets3(ls, 0, results,2);
            Console.WriteLine("Using Subsets4");
            Subsets4(ls, 0,2);
        }
        static void Subsets1(List<string> ls, List<string> results, int k)
        {
            if (ls.Count == 0 && (results.Count < k || results.Count > k))
            {
                 return;
            }
            if (ls.Count == 0 && results.Count == k)
            {
                PrintList(results);
                return;
            }
            var newList = new List<string>(ls);
            var newResults = new List<string>(results);
            string s = newList[0];
            newList.RemoveAt(0);
            Subsets1(newList, newResults,k);
            newResults.Add(s);
            Subsets1(newList, newResults,k);
        }
        static void Subsets2(List<string> ls, List<string> results,int k)
        {
            if (ls.Count == 0 && (results.Count < k || results.Count > k))
            {
                return;
            }
            if (ls.Count == 0 && results.Count == k)
            {
                PrintList(results);
                return;
            }
            string s = ls[0];
            ls.RemoveAt(0);
            Subsets2(ls, results,k);
            results.Add(s);
            Subsets2(ls, results,k);
            results.RemoveAt(results.Count - 1);
            ls.Insert(0, s);
        }
        static void Subsets3(List<string> ls, int k, List<string> results, int x)
        {
            if (ls.Count == k && (results.Count < x || results.Count > x))
            {
                return;
            }
            if (ls.Count == k && results.Count == x)
            {
                PrintList(results);
                return;
            }
            string s = ls[k];
            Subsets3(ls, k + 1, results,x);
            results.Add(s);
            Subsets3(ls, k + 1, results,x);
            results.RemoveAt(results.Count - 1);
        }
        static void Subsets4(List<string> ls, int k,int x)
        {
            if (ls.Count == k && (ls.Count < x || ls.Count > x))
            {
                return;
            }
            if (ls.Count == k && ls.Count == x)
            {
                PrintList(ls);
                return;
            }
            string s = ls[k];
            ls.RemoveAt(k);
            Subsets4(ls, k,x);
            ls.Insert(k, s);
            Subsets4(ls, k + 1,x);
        }
        static void PrintList(List<string> ls)
        {
            Console.Write(" { ");
            foreach (string s in ls)
                Console.Write(s + " ");
            Console.WriteLine("}");
        }
    }
}




          
            

                


