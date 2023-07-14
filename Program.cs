using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignMent7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Cherry");
            list.Add("Date");
            list.Add("ElderBerry");
            Console.WriteLine("The total number of elements "+list.Count);
            Console.WriteLine("Does the element \"Date\" contains in the list?\n True \t False");
            Console.WriteLine("\t"+list.Contains("Date"));
            list.Insert(2, "Fig");
            list.Remove("Banana");
            foreach (string item in list)
                Console.WriteLine(item);
        }
    }
}
