using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_towers
{
    internal class TriangleTower:Tower
    {
        #region TriangleTower constructor
        /*Initializes a new instance of the TriangleTower class*/
        public TriangleTower(double width, double height) : base(width, height)
        {
            if (width % 2 == 0 || width > 2 * Height)
            {
                throw new ArgumentException("Triangle tower cannot have even width or width greater than twice the height.");
            }
        }
        #endregion

        #region GetArea
        /*Calculates and returns the area of the triangle tower*/
        public override double GetArea()
        {
            return (Width * Height)/2;
        }
        #endregion

        #region GetPerimeter
        /*Calculates and returns the perimeter of the triangle tower*/
        public override double GetPerimeter()
        {
            return Width + 2 * Math.Sqrt(Height * Height + Width * Width);//Perimeter = a + 2 * sqrt(b^2 + a^2)
        }
        #endregion

        #region PrintTriangle
        /*Prints the triangle tower */
        public void PrintTriangle()
        {
            if (Width%2==0||Width>Height*2)
            {
                Console.WriteLine("the triangle can't be printed");
                return;
            }

            if ((int)Width / 2 - 1 == 0)
            {
                Console.Write("can't print this triangle");
                Console.Write("\n");
                return;
            }

            //print the first line
            PrintLine(1);

            //middle lines
            int midLines = (int)Height - 2;
            int widthesLines = (int)Width / 2 - 1;//width types

            int linesNum = midLines/widthesLines;//how many times each width type will be printed
            int linesNumLeft=midLines% widthesLines;

            for (int i = 0; i < linesNumLeft; i++)
                PrintLine(3);

            for (int i = 0; i < widthesLines; i++)
            {
                for (int j = 0; j < linesNum; j++)
                    PrintLine(2*i+3);
            }
                
            //print the last line
            PrintLine(Width);
        }
        #endregion

        #region PrintLine
        /*Prints a line of stars with the correct space. */
        private void PrintLine(double starsNum)
        {
            for (int i = 0; i < (Width - starsNum) / 2; i++)
                Console.Write(" ");
            for (int i = 0; i < starsNum; i++)
                Console.Write("*");
            Console.Write("\n");
        }
        #endregion
    }
}


