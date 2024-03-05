namespace Ex_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x:");
            double x = Convert.ToDouble(Console.ReadLine());
            
            if (1 <= x && x <= 3) 
            {
                Console.WriteLine($"{2*Math.Pow(x,2) - 3*Math.Pow(Math.E,Math.Sin(x))}");
            }
            if (x>3)
            {
                Console.WriteLine($"{3*Math.Tan(x)}");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}