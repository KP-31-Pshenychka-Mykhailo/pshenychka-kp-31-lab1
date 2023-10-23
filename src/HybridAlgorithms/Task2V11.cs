namespace HybridAlgorithms;
{ 
        public class Task2
        {

            public static void Main(string[] args)
            {
                    
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
                 
            Console.WriteLine("Введіть число:");
                int date = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введіть місяць:");
                int month = Convert.ToInt32(Console.ReadLine());

                Task2 task = new Task2();
                DayOfWeek dayOfWeek = task.Calculate(date, month);

                Console.WriteLine($"День тижня:{dayOfWeek}");
            }
            public DayOfWeek Calculate(int date, int month)
            {
                
                int d = date;
                int m = month;
                int y;

                if (m > 2)
                {
                    y = 2023 + 1;
                }
                else
                {
                    y = 2023;
                }

                int firstday = 4 + (y - 1) % 7;
                int allday = (d - 1) + (m - 1) * 30 + (y - 1) / 4 - (y - 1) / 100 + (y - 1) / 400;
                int dayofweek = (firstday + allday) % 7;

               
                DayOfWeek result = (DayOfWeek)dayofweek;

                return result;
            }

            
        }

    }
