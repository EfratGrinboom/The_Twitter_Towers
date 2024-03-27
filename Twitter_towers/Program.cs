using System;

namespace Twitter_towers
{
    internal class Program
    {
        #region Main
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Enter your choice:1 for Retangle Tower, 2 for Triangle Tower, 3 to Exit");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CalculateRectangleTower();
                        break;
                    case 2:
                        CalculateTriangleTower();
                        break;
                    case 3:
                        Console.WriteLine("Exiting program...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            } while (choice != 3);
        }
        #endregion

        #region Calculate Rectangle Tower
        /*Gets the dimensions of a rectangle tower from the user, creates a RectangleTower object,
        and calculate area or perimeter based on a condition.*/
        private static void CalculateRectangleTower()
        {
            double width, height;
            Console.WriteLine("Enter width and height of the rectangle tower:");
            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            RectangleTower rectTower = new RectangleTower(width, height);
            if (width == height || width - height > 5 || height - width > 5)
                Console.WriteLine("area: " + rectTower.GetArea());
            else
                Console.WriteLine("perimeter: " + rectTower.GetPerimeter());

        }
        #endregion

        #region Calculate Triangle Tower
        /*Gets the dimensions of the triangle tower from the user, creates a TriangleTower object,
        and allows the user to choose between calculating the perimeter or printing the triangle.*/
        private static void CalculateTriangleTower()
        {
            double width, height;
            Console.WriteLine("Enter width and height of the triangle tower:");
            width = double.Parse(Console.ReadLine());
            height = double.Parse(Console.ReadLine());
            TriangleTower triTower = new TriangleTower(width, height);

            Console.WriteLine("Enter 1 to Calculate the perimeter of the triangle and 2 to print the triangle:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("area: " + triTower.GetPerimeter());
                    break;
                case 2:
                    triTower.PrintTriangle();
                    break;
                default:
                    Console.WriteLine("incorrect choice");
                    break;
            }
        }
        #endregion
    }
}


/*Running example:
 * Enter your choice:1 for Retangle Tower, 2 for Triangle Tower, 3 to Exit
1
Enter width and height of the rectangle tower:
2
2
area: 4
Enter your choice:1 for Retangle Tower, 2 for Triangle Tower, 3 to Exit
2
Enter width and height of the triangle tower:
5
4
Enter 1 to Calculate the perimeter of the triangle and 2 to print the triangle:
2
  *
 ***
 ***
*****
Enter your choice:1 for Retangle Tower, 2 for Triangle Tower, 3 to Exit
*/