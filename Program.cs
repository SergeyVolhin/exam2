using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            File.AppendAllLines("C:/Users/1253125/Desktop/text.txt", new string[] { "C:/Users/1253125/Desktop/text2.txt" });
            using (StreamWriter w = File.AppendText("text.txt"))
            {
                w.WriteLine("?");
            };
        }
    }
}
