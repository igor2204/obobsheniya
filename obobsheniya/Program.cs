using System;



class Calculator<T>
{
    public T Add(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x + y;
    }

    public T Subtract(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x - y;
    }

    public T Multiply(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;
        return x * y;
    }

    public T Divide(T a, T b)
    {
        dynamic x = a;
        dynamic y = b;

        if (y == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }

        return x / y;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите первое число: ");
        dynamic num1 = Convert.ChangeType(Console.ReadLine(), typeof(double));

        Console.WriteLine("Введите второе число: ");
        dynamic num2 = Convert.ChangeType(Console.ReadLine(), typeof(double));

        Console.WriteLine("Выберите операцию: ");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        int operation = Convert.ToInt32(Console.ReadLine());

        Calculator<dynamic> calculator = new Calculator<dynamic>();

        dynamic result = 0;

        switch (operation)
        {
            case 1:
                result = calculator.Add(num1, num2);
                break;
            case 2:
                result = calculator.Subtract(num1, num2);
                break;
            case 3:
                result = calculator.Multiply(num1, num2);
                break;
            case 4:
                try
                {
                    result = calculator.Divide(num1, num2);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
                break;
            default:
                Console.WriteLine("Неверная операция.");
                return;
        }

        Console.WriteLine("Результат: " + result);
    }
}
