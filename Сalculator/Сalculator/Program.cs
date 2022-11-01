using System;
using Сalculator;
double a,b,c;
char oper;
Console.WriteLine("Добро пожаловать в программу 'Калькулятор'.");
var res = new ClassReferences();
char again = 'y';
while (again == 'y')
{    
    Console.WriteLine("Введите оператор: ( + , - , * , / , k(Корень) , ^ ,s(sin) , c(cos) )");
    oper = Convert.ToChar(Console.ReadLine());

    if (oper == '+')
    {
        Console.WriteLine("Введите числа: ");
        Console.WriteLine();
        Console.WriteLine("Введите первое число: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {res.Add(a, b)}");
    }
    else if (oper == '-')
    {
        Console.WriteLine();
        Console.WriteLine("Введите числа: ");
        Console.WriteLine();
        Console.WriteLine("Введите первое число: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {res.Sub(a, b)}");
    }
    else if (oper == '/')
    {
        Console.WriteLine();
        Console.WriteLine("Введите числа: ");
        Console.WriteLine();
        Console.WriteLine("Введите первое число: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {res.Div(a, b)}");
    }
    else if (oper == '*')
    {
        Console.WriteLine();
        Console.WriteLine("Введите числа: ");
        Console.WriteLine();
        Console.WriteLine("Введите первое число: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {res.Mult(a, b)}");
    }
    else if (oper == 'c')
    {
        Console.WriteLine("Введите число: ");
        c = double.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {res.Cos(c)}");
    }
    else if (oper == 's')
    {
        Console.WriteLine("Введите число: ");
        c = double.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {res.Sin(c)}");
    }
    else if (oper == '^')
    {
        Console.WriteLine();
        Console.WriteLine("Введите числа: ");
        Console.WriteLine();
        Console.WriteLine("Введите первое число: ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {res.Pov(a, b)}");
    }
    else if (oper == 'k')
    {
        Console.WriteLine("Введите число: ");
        c = double.Parse(Console.ReadLine());
        Console.WriteLine($"Результат: {res.Sqrt(c)}");
    }
    else
    {
        Console.WriteLine("Неизвестный оператор!!!");
    }

    Console.WriteLine("Вы хотите продолжить работу с калькулятором? (y/n)");
    again = Convert.ToChar(Console.ReadLine());
}