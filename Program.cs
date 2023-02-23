namespace UC2_EqualityOfTwoLines
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int point_x1;
            int point_x2, point_y1, point_y2, line1, line2;
            double length;
            //bool value1, value2;


            Console.WriteLine("Enter the First Value of Point: ");
            point_x1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Secount value of Point: ");
            point_x2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the thires Value of Point: ");
            point_y1= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Forth Value of Point: ");
            point_y2= Convert.ToInt32(Console.ReadLine());

            

            line1 = point_x2 - point_x1;
            line2=point_y2- point_y1;

            length = Math.Sqrt(Math.Pow(line1,2)+Math.Pow(line2,2));
            Console.WriteLine("Length of the line:"+ length);
                                   
            Console.WriteLine(length.Equals(line1));
            Console.WriteLine(length.Equals(line2));

        }
    }
}