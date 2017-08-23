
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestPointMultiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "mytest.txt";
            int[,] array4User;
            List<int> finalItems = new List<int>();

            ArrayGenerator arrayGenerator = new ArrayGenerator();
            array4User = arrayGenerator.Generate(filename);

            int row = array4User.GetLength(0);
            int col = array4User.GetLength(1);

            Console.WriteLine(row + "x" + col);

            GetInterestPoint pointGetting = new GetInterestPoint();
            finalItems = pointGetting.FindingInterestPoint(array4User);

            Console.WriteLine("Interest point is at: ");
            foreach (var item in finalItems)
            {
                Console.Write(item);
                Console.Write(" ");
            }

            Console.ReadLine();

        }

    }
}
