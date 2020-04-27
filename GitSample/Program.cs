using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSample
{
    class Program
    {
        public delegate void ShowLog(string messenger); // Points Function
        public delegate void ShowLog1(string messenger);
        ShowLog showlog;
        public static void prin(string a)
        {
            Console.WriteLine("{0}",a);
        }
        public static void prin1(string a)
        {
            Console.WriteLine("{0}", a);
        }
        
        public static int sum(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Func<int, int, int> Sum;
            ShowLog sooo = null;
            sooo += prin;
            sooo += prin;
            sooo += (x) => { Console.WriteLine("B"); };
            Sum = sum;
                
            sooo("a");
            Console.ReadKey();
            
        }
    }
}
