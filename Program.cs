using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AplusB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputpath = "D:\\SolutionsForSpaceApp\\2001\\input.txt";
            string outputpath = "D:\\SolutionsForSpaceApp\\2001\\output.txt";



            string reada = Console.ReadLine();
            string readb = Console.ReadLine();
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            File.WriteAllText(inputpath, string.Join(" ", reada, readb));


             



            StreamReader fstake = new StreamReader(inputpath, Encoding.Unicode);

            int[] arr = File.ReadAllText(inputpath).Split(' ').Select(n => int.Parse(n)).ToArray();
            File.WriteAllText(outputpath, string.Join(" ", arr[0] + arr[1]));
        }
    }
}
