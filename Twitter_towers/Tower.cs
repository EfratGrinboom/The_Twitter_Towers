using System;

namespace Twitter_towers
{
    internal abstract class Tower
    {
        #region Tower constructor
        /*Initializes a new instance of the Tower class*/
        public Tower(double width, double height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new ArgumentOutOfRangeException("Width and height must be positive values.");
            }
            Width = width;
            Height = height;
        }
        #endregion

        #region GetArea
        /*abstract function to Calculates and returns the area of the tower*/
        public abstract double GetArea();
        #endregion

        #region GetPerimeter
        /*abstract function to Calculates and returns the perimeter of the tower*/
        public abstract double GetPerimeter();
        #endregion

        protected double Height { get; set; }
        protected double Width { get; set; }
    }
}



