namespace TaskForNis;

public class Program
{
    public static void Main()
    {
        do
        {
            Console.Write("Введи число a: ");
            string a = Console.ReadLine();
            if (decimal.TryParse(a, out decimal n))
            {
                Console.Write("Введи число b: ");
                string b = Console.ReadLine();
                if (decimal.TryParse(b, out decimal n2))
                {
                    Console.WriteLine($"Сумма чисел: {n + n2:f2}");
                }
                else
                {
                    Console.WriteLine("Вы ввели не число(");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не число(");
            }
            
            Console.WriteLine("Хотите выйти? y/smth_else");
            string? exit  = Console.ReadLine();
            if (exit == null ||  exit.ToLower() == "y")
            {
                break;
            }
        } while (true);
        
    }
}