using System;

namespace unm_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Boot(out num1, out num2, out object res, out op);
            switch (op)
            {
                case '+':
                    res = Suma(num1, num2);
                    break;
                case '-':
                    res = Resta(num1, num2);
                    break;
                case '*':
                    res = Mult(num1, num2);
                    break;
                case '/':
                    res = Div(num1, num2);
                    break;
                default:
                    Console.WriteLine("ingrese una opcion valida [+ - * / ]");
                    break;
            }
            Console.WriteLine("El resultado es: {0}", res);
            Console.ReadKey();
        }

        static void Boot(out int num1, out int num2, out object res, out char op)
        {
            res = 0;
            Console.WriteLine("Ingrese numero a: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero b: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Operacion:");
            op = char.Parse(Console.ReadLine());
        }
        static int Suma(int a, int b)
        {
            return a + b;
        }
        static int Resta(int a, int b)
        {
            return a - b;
        }
        static int Mult(int a, int b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            if (b == 0)
                throw new System.DivideByZeroException();
            return a / b;
        }

    }
    
}
