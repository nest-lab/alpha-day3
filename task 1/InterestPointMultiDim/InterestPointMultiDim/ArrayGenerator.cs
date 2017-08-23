using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestPointMultiDim
{
    public class ArrayGenerator
    {
        public int[,] Generate(string inputFilePath)
        {
            string[,] array2D;
            int[,] array2DNum;
            int numOfLines = 0;
            int numOfColumns = 0;
            string line;
            string line2;

            StreamReader arrayReader = new StreamReader(inputFilePath);

            while ((line = arrayReader.ReadLine()) != null)
            {
                if (line.Contains("//") || line.Contains("x"))
                {
                    numOfLines = numOfLines + 0;
                }
                else
                {
                    numOfColumns = line.Split(' ').Length;
                    numOfLines++;
                }

            }
            arrayReader.Close();

            //Console.WriteLine(numOfLines + " x" + numOfColumns);
            array2D = new string[numOfLines, numOfColumns];
            array2DNum = new int[numOfLines, numOfColumns];
            numOfLines = 0;

            StreamReader newArrayReader = new StreamReader(inputFilePath);
            while ((line2 = newArrayReader.ReadLine()) != null)
            {
                if ((line2.Contains("//") || line2.Contains("x")))
                {
                    numOfLines = numOfLines + 0;
                }
                else
                {
                    string[] tempArray = line2.Split(' ');
                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        array2D[numOfLines, i] = tempArray[i];
                        string num = array2D[numOfLines, i];
                        int numInt32 = int.Parse(num);

                        array2DNum[numOfLines, i] = numInt32;
                        //Console.WriteLine(tempArray[i]);
                        //Console.WriteLine(array2DNum[numOfLines, i]);
                    }
                    numOfLines++;
                }
            }

            //Console.ReadLine();
            return array2DNum;
        }
    }
}
