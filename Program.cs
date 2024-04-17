using System;

class App
{

    class Calculate
    {
        public double a;
        public double b;
        public string op;
    }

    static Calculate InputMath()
    {
        Calculate math = new Calculate();
        Console.WriteLine("Введите первое число");
        math.a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите знак");
        math.op = Console.ReadLine();
        Console.WriteLine("Введите второе число");
        math.b = Convert.ToDouble(Console.ReadLine());
        return math;
    }

    static double Plus(Calculate math)
    {
        double result = math.a + math.b;
        return result;
    }
    
    static double Minus(Calculate math)
    {
        double result = math.a - math.b;
        return result;
    }
    
    static double Mult(Calculate math)
    {
        double result = math.a * math.b;
        return result;
    }
    
    static double Division(Calculate math)
    {
        double result = math.a / math.b;
        return result;
    }
    
    static void Main()
    {
        Calculate math = InputMath();
        Console.WriteLine($"{Plus(math)} {Minus(math)} {Mult(math)} {Division(math)}");
    }
}