namespace Twitter_towers
{
    internal class RectangleTower: Tower
    {
        #region RectangleTower constructor
        /*Initializes a new instance of the RectangleTower class*/
        public RectangleTower(double width, double height) : base(width, height){}
        #endregion

        #region GetArea
        /*Calculates and returns the area of the rectangle tower*/
        public override double GetArea()
        {
            return Width * Height;
        }
        #endregion

        #region GetPerimeter
        /*Calculates and returns the perimeter of the rectangle tower*/
        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
        #endregion
    }
}