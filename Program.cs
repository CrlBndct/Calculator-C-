using System;

class Calculator
{

    static double add(double num1, double num2)
    {
        return num1 + num2;
    }

    static double sub(double num1, double num2)
    {
        return num1 - num2;
    }

    static double div(double num1, double num2)
    {
        return num1 / num2;
    }

    static double mult(double num1, double num2)
    {
        return num1 * num2;
    }

    static void Main(string[] args)
    {
        Console.Write(" ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write(" ");
        string op = Convert.ToString(Console.ReadLine());

        Console.Write(" ");
        double num2 = Convert.ToDouble(Console.ReadLine());


        switch (op)
        {
            case "+":
                Console.WriteLine("= " + add(num1, num2));
                break;

            case "-":
                Console.WriteLine("= " + sub(num1, num2));
                break;

            case "/":
                Console.WriteLine("= " + div(num1, num2));
                break;

            case "x":
                Console.WriteLine("= " + mult(num1, num2));
                break;
        }


    }
}
