using System;
using System.Collections.Generic;
using System.Linq;
 
class DoubleDowns
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
 
        string[] binNumbers = new string[N];
 
        for (int k = 0; k < N; k++)
        {
            int decNum = int.Parse(Console.ReadLine());
            binNumbers[k] = Convert.ToString(decNum, 2).PadLeft(32, '0');
        }
        int verticalCount = 0;
        int leftDiagonalCount = 0;
        int rightDiagonal = 0;
 
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 0; j < 32; j++)
            {
                if (binNumbers[i].Substring(j, 1) == "1")
                {
                    #region firstBit
                    if (j == 0)
                    {
                        if (binNumbers[i + 1].Substring(j, 2) == "10")
                        {
                            verticalCount++;
                        }
                        if (binNumbers[i + 1].Substring(j, 2) == "01")
                        {
                            rightDiagonal++;
                        }
                        if (binNumbers[i + 1].Substring(j, 2) == "11")
                        {
                            verticalCount++;
                            rightDiagonal++;
                        }
                    }
                    #endregion
 
                    #region BitsMiddle
                    if (j > 0 && j <= 30)
                    {
                        if (binNumbers[i + 1].Substring(j - 1, 3) == "111")
                        {
                            verticalCount++;
                            leftDiagonalCount++;
                            rightDiagonal++;
                        }
                        if (binNumbers[i + 1].Substring(j - 1, 3) == "100")
                        {
                            leftDiagonalCount++;
                        }
                        if (binNumbers[i + 1].Substring(j - 1, 3) == "101")
                        {
                            leftDiagonalCount++;
                            rightDiagonal++;
                        }
                        if (binNumbers[i + 1].Substring(j - 1, 3) == "011")
                        {
                            verticalCount++;
                            rightDiagonal++;
                        }
                        if (binNumbers[i + 1].Substring(j - 1, 3) == "001")
                        {
                            rightDiagonal++;
                        }
                        if (binNumbers[i + 1].Substring(j - 1, 3) == "010")
                        {
                            verticalCount++;
                        }
                        if (binNumbers[i + 1].Substring(j - 1, 3) == "110")
                        {
                            leftDiagonalCount++;
                            verticalCount++;
                        }
                    }
                    #endregion
 
                    #region LastBit
                    if (j == 31)
                    {
                        if (binNumbers[i + 1].Substring(j - 1, 2) == "01")
                        {
                            verticalCount++;
                        }
                        if (binNumbers[i + 1].Substring(j - 1, 2) == "11")
                        {
                            leftDiagonalCount++;
                            verticalCount++;
                        }
                        if (binNumbers[i + 1].Substring(j - 1, 2) == "10")
                        {
                            leftDiagonalCount++;
                        }
                    }
                    #endregion
                }                      
             }
          }
       
        Console.WriteLine(rightDiagonal);
        Console.WriteLine(leftDiagonalCount);
        Console.WriteLine(verticalCount);
    }
}
