namespace UC3_CompareTwoLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point_x1 = 0;
            int point_x2 = 0, point_y1 = 0, point_y2 = 0;
            int line1, line2;
            double length;

            Console.WriteLine("Enter 1st Value of Point: ");
            point_x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd Value of Point: ");
            point_x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 3rd Value of Point: ");
            point_y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 4th Value of Point: ");
            point_y2 = Convert.ToInt32(Console.ReadLine());

            line1 = point_x2 - point_x1;
            line2 = point_y2 - point_y1;

            length = Math.Sqrt(Math.Pow(line1, 2) + Math.Pow(line2, 2));

            if (point_x1>point_x2 && point_y1>point_y2)
            {
                Console.WriteLine("one line Are greatest");
            }
            else if (point_x1<point_x2 && point_y1<point_y2)
            {
                Console.WriteLine("One line are lessthen");
            }
            else
            {
                Console.WriteLine("Two line Are Equal");
            }

        }
    }
}