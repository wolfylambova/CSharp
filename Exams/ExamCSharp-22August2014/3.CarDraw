using System;
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());                      
            int width = 3*N;

            Console.WriteLine("{0}{1}{0}", new string('.',N), new string('*',N));
         
            #region Roof
             int dotPad = N - 1;
            int dotMiddle = N;
            for (int i = 0; i < N/2-1; i++)
            {
                string pad = new string('.', dotPad);
                string middle = new string('.', dotMiddle);
                Console.WriteLine(pad+'*'+middle+'*'+pad);
                dotPad--;
                dotMiddle += 2;

            }
            #endregion

            #region Line
            dotMiddle = N * 2 - 2;
            dotPad = (width - dotMiddle) / 2;
            Console.WriteLine("{0}{1}{0}", new string('*',dotPad), new string('.',dotMiddle));         
            
            #endregion

            #region Body
            for (int i = 0; i < N/2-2; i++)
            {
                Console.WriteLine("*{0}*", new string('.', width-2));
            }
            #endregion

            Console.WriteLine("{0}", new string('*', width));
           
            #region Wheels
            for (int i = 0; i < N/2-2; i++)
            {
                dotPad = N / 2;
                int dotWheel = N / 2 - 1;
                dotMiddle = width - (4 + dotWheel*2 + dotPad*2);
                string pads = new string('.', dotPad);
                string wheel = new string('.', dotWheel);
                string middle = new string('.', dotMiddle);
                Console.WriteLine(pads+'*'+wheel+'*'+middle+'*'+wheel+'*'+pads);
            }
            #endregion

            #region LastLine
            dotPad = N / 2;
            int wheelDot = N / 2 + 1;
            dotMiddle = width - (dotPad * 2 + wheelDot * 2);
            string padDot = new string('.', dotPad);
            string wheelStar = new string('*', wheelDot);
            string mid = new string('.', dotMiddle);
            Console.WriteLine(padDot+wheelStar+mid+wheelStar+padDot);
            #endregion
        }
    }
