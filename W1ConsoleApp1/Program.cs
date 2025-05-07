namespace W1ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Console.Write("Enter circle radius: ");
            //double r = double.Parse(Console.ReadLine());
            //double diameter = 2 * r;
            //double circumference = 2 * Math.PI * r;
            //double area = Math.PI * r * r;
            //Console.WriteLine("Diameter: " + diameter);
            //Console.WriteLine("Circumference: " + circumference);
            //Console.WriteLine("Area: " + area);

            int[] numbers = { 10, 20, 0, 30 };
            int total = 0;
            int count = numbers.Length;

            for (int i = 0; i < count; i++) // off-by-one error
            {
                total += numbers[i];
            }

            int average = total / count;
            Console.WriteLine("Average: " + average);

            Console.WriteLine("Hello");
        }
    }
}
