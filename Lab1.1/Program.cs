using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfnumbers = new List<int>();

            Random random = new Random();

            int n = 0;

            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Error!");
                    continue;
                }

                break;
            }

            for (int i = 0; i < n; i++)
            {
                listOfnumbers.Add(random.Next() % 2);
            }

            foreach (var number in listOfnumbers)
            {
                Console.Write(number + " ");
            }

            int firstindex = 0, lastindex = 0;
            int j, count, maxcount = 0;

            for (int i = 0; i < n; i++)
            {
                if (listOfnumbers[i] == 1)
                {
                    j = i; count = 0;
                    while (j < n && listOfnumbers[j] != 0)
                    {
                        count++;
                        j++;
                    }

                    if (count > maxcount)
                    {
                        maxcount = count;
                        firstindex = i;
                        lastindex = j - 1;
                        i = j;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("first index: " + firstindex + " last index: " + lastindex);

            Console.ReadKey();
        }
    }
}