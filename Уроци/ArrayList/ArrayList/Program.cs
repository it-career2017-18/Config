using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList<int> arr = new ArrayList<int>();
            var num = 0;

            do {
                Console.WriteLine("Enter number: ");
                num= int.Parse(Console.ReadLine());
                arr.Add(num);
            }while(num!=0);

            int sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
            }

            arr.RemoveAt(1);
            sum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sum += arr[i];
            }

            
        }
    }
}
