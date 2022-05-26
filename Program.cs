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



           
            FileStream fs = new FileStream(inputpath, FileMode.OpenOrCreate);
            fs.Close();
            FileStream fsout = new FileStream(outputpath, FileMode.OpenOrCreate);
            fsout.Close();


           
            int[] arr = File.ReadAllText(inputpath).Split(' ').Select(n => int.Parse(n)).ToArray();
            File.WriteAllText(outputpath, string.Join(" ", arr[0] + arr[1]));
        }
    }
}
