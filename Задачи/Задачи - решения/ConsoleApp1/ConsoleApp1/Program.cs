using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int secKey = int.Parse(Console.ReadLine());
            string[] webData = new string[3];
            var siteLoss = 0.0;
            string[] names = new string[N];
            for (int i = 0; i < N; i++)
            {
                webData = Console.ReadLine().Split(' ').ToArray();
                siteLoss += double.Parse(webData[1]) * double.Parse(webData[2]);
                names[i] = webData[0];
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Total Loss: {0:F20}", siteLoss);
            Console.WriteLine("Security Token: {0}", Math.Pow(secKey, N));
            Console.ReadKey();
        }
    }
}
