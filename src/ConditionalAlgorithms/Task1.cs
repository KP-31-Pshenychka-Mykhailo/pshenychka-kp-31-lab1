namespace ConditionalAlgorithms;
{
    internal class Program
    {

        public static void Main(string[] args)
        {
             Console.InputEncoding = Encoding.Unicode;
             Console.OutputEncoding = Encoding.Unicode;
            
            Console.WriteLine("Введіть a, b і c:");

            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());
            if (z == 0)
            {
                Console.WriteLine("Помилка");
            }
            else
            {
                Task1 task = new Task1();
                (double a, double b) result = task.Calculate(x, y, z);

                Console.WriteLine($"x = {result.a}");
                Console.WriteLine($"y = {result.b}");
            }
        }

        public class Task1
        {
            public (double a, double b) Calculate(double x, double y, double z)
            {
                double a, b;
                
                
                 a = Math.Cos(x + ((x * y) / z));

                 b = (x * x * x) / Math.Cos(a);

                return (a, b);
            }
        }
     

    }
}
