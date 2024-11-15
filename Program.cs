using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число: ");
        var x = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        var y = Convert.ToInt32(Console.ReadLine());
        int result = 0;
        for (int i = 0; i < Math.Abs(x); i++) result += y;



        static int multiply(int x, int y)
        {

            
            if (y == 0)
                return 0;

            
            if (y > 0)
                return (x + multiply(x, y - 1));

            
            if (y < 0)
                return -multiply(x, -y);

            return -1;
        }



        int Multiply1(int a, int b)
        {
            int result1 = 0;
            while (b > 0)
            {
                if ((b & 1) != 0) 
                    result1 += a;
                a <<= 1; 
                b >>= 1; 
            }
            return result1;
        }



        int Multiply2(int a, int b)
        {
            return Enumerable.Range(0, b).Aggregate(0, (total, current) => total + a);
        }


        int Multiply3(int a, int b)
        {
            return Enumerable.Range(1, b).Sum(x => a);
        }

        Console.WriteLine(Multiply3(x, y));
        Console.WriteLine(Multiply2(x, y));
        Console.WriteLine(Multiply1(x,y));
        Console.WriteLine(result);
        Console.WriteLine(multiply(x, y));
    }
}