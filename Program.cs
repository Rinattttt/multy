using System;
using System.Linq;
class Program
{
    /// <summary>
    /// Умножение двух чисел с использованием цикла.
    /// </summary>
    static int MultiplyUsingLoop(int a, int b)
    {
        // Проверка на отрицательное значение
        int result = 0;
        bool isNegative = false;

        // Убираем знак, если он отрицательный
        if (a < 0)
        {
            a = -a;
            isNegative = !isNegative;
        }
        if (b < 0)
        {
            b = -b;
            isNegative = !isNegative;
        }
        // Суммируем a, b раз
        for (int i = 0; i < b; i++)
        {
            result += a;
        }

        // Возвращаем результат с учетом знака
        return isNegative ? -result : result;
    }
    /// <summary>
    /// Рекурсивное умножение двух чисел.
    /// </summary>
    static int MultiplyUsingRecursion(int a, int b)
    {
        // Базовый случай для рекурсии
        if (b == 0)
            return 0;

        // Умножаем a на b, рекурсивно уменьшая b
        if (b > 0)
            return a + MultiplyUsingRecursion(a, b - 1);

        // Если b отрицательное
        return -MultiplyUsingRecursion(a, -b);
    }
    /// <summary>
    /// Умножение двух чисел с использованием битовых операций.
    /// </summary>
    static int MultiplyUsingBitwise(int a, int b)
    {
        int result = 0;

        // Обрабатываем знак
        bool isNegative = (a < 0) ^ (b < 0);

        // Приводим оба числа к положительным
        a = Math.Abs(a);
        b = Math.Abs(b);

        // Основной цикл обработки умножения
        while (b > 0)
        {
            // Если последний бит b установлен, добавляем a к результату
            if ((b & 1) == 1)
                result += a;

            // Сдвигаем a влево (умножаем на 2) и b вправо (делим на 2)
            a <<= 1; // Умножаем a на 2
            b >>= 1; // Делим b на 2
        }

        // Возвращаем результат с учетом знака
        return isNegative ? -result : result;
    }
    /// <summary>
    /// Умножение двух чисел с использованием Enumerable.Repeat.
    /// </summary>
    static int MultiplyUsingRepeat(int a, int b)
    {
        // Если b равно 0, результат равен 0
        if (b == 0) return 0;

        // Возвращаем сумму a, повторенного b раз
        return a > 0 ? Enumerable.Repeat(a, b).Sum() : -Enumerable.Repeat(-a, -b).Sum();
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите x");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите y");
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(MultiplyUsingLoop(x, y));
        Console.WriteLine(MultiplyUsingRecursion(x, y));
        Console.WriteLine(MultiplyUsingBitwise(x, y));
        Console.WriteLine(MultiplyUsingRepeat(x, y));
    }

}


