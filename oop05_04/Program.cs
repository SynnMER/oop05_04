using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop05_04
{
    public class Test
    {
        public int a;
       public Test()
       {
            Console.WriteLine("create object");
       }
        static public int myDouble(int _arg)
        {
            return _arg *2 ;
        }
    }
    internal class Program
    {
        static void myConvert(string _promt,out int? a) {
            a = null;
            Console.WriteLine(_promt);
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);

            }
        }
        static void Main(string[] args)
        {
            int a = 4;
            int? a1 = null;
            string b = "6a";
            while (a1 == null)
            {
                myConvert("Write number", out a1);
            }
            var aaa = new Test();
            //Console.WriteLine(aaa.myDouble(a));
            Test.myDouble(3);
            Console.WriteLine(a1);
            int[] arr = new int[3] {1,2,0} ;
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            var _list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                _list.Add(arr[i]);
                Console.WriteLine(_list[i]);
            }
            _list.Add(-7);
            int counter = 0;
            foreach (var item in _list)
            {
                //Console.Write("Element {0} = {1}",counter,item);
                Console.Write($"Element {counter} = {item}");
                counter++;
            }
            Console.ReadKey();
        }
    }
}
