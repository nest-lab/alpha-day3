using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestPointMultiDim
{
    public class GetInterestPoint
    {
        public List<int> FindingInterestPoint(int[,] array)
        {
            List<int> interestPoints = new List<int>();
            int row = array.GetLength(0);
            int col = array.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0;  j < col; j++)
                {
                    int element1;
                    int element2;
                    int element3;
                    int element4;

                    //int postion1;
                    //int position2;
                    //int position3;
                    //int position4;

                    try
                    {
                        element1 = array[i - 1, j];
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        element1 = 0;                        
                    }
                    try
                    {
                        element2 = array[i +1, j];
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        element2 = 0;
                    }
                    try
                    {
                        element3 = array[i,j-1];
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        element3 = 0;
                    }
                    try
                    {
                        element4 = array[i , j +1];
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        element4 = 0;
                    }
                    if (array[i, j] >= element1 && array[i, j] >= element2 && array[i, j] >= element3 && array[i, j] >= element4)
                    {
                        interestPoints.Add(array[i, j]);
                    }
                }
            }

            return interestPoints;
        }
    }
}
