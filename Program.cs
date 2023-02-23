namespace UC1_Cartesian_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point_X1 = 0;
            int point_X2 = 0, point_Y1 = 0, point_Y2 = 0;
            double length;

            Console.WriteLine("Enter the value of Point 1: ");
            point_X1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Secound value of Point 2:");
            point_X2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Thired value of point 3");
            point_Y1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Foruth Value Of Point 4");
            point_Y2=Convert.ToInt32(Console.ReadLine());

            length = Math.Sqrt(Math.Pow(point_X2 - point_X1, 2)+Math.Pow(point_Y2-point_Y1,2));

            Console.WriteLine("Length of the Line: " + length);
        }
    }
}