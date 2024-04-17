using System;

class App
{

    class Calculate
    {
        public double a;
        public double b;
        public string op;
    }
    
    static double NumPow(Calculate math)
    {
        return Math.Pow(math.a, math.b);
    }

    static double NumSqrt(Calculate math)
    {
        return Math.Sqrt(math.a);
    }

    static Calculate InputMath()
    {
        Calculate math = new Calculate();
        Console.WriteLine("Введите первое число");
        math.a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите знак");
        math.op = Console.ReadLine();
        if(math.op != "sqrt")
        {
            Console.WriteLine("Введите второе число");
            math.b = Convert.ToDouble(Console.ReadLine());
        }
        return math;
    }

    static void OutPut(Calculate math)
    {
        string str = $"{math.a} {math.op} {math.b} = ";
        switch (math.op)
        {
            /*case "+":
                Console.WriteLine(str + Plus(math));
                break;
            case "-":
                Console.WriteLine(str + Minus(math));
                break;
            case "*":
                Console.WriteLine(str + Mult(math));
                break;
            case "/":
                Console.WriteLine(str + Div(math));
                break;
            */case "^":
                Console.WriteLine(str + NumPow(math));
                break;
            case "sqrt":
                Console.WriteLine(math.op + math.a + " = " + NumSqrt(math));
                break;
            default:
                Console.WriteLine("Ошибка! Неверный ввод данных!");
                break;
        }
    }

    static void Main()
    {
        Calculate math = InputMath();
        OutPut(math);
    }
}