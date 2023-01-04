using System.Diagnostics.CodeAnalysis;

Console.WriteLine("For calculatro press 1 and for Calculate The multiple of five between -1 and -1000 press 2 and 3 for factorial: ");
Console.Write("Press your number: ");
var inputnum = Console.ReadLine();
if (inputnum == "1")
{
    double fnum = 0;
    double snum = 0;
    Calculator(fnum, snum);

}

else if (inputnum == "2")
{

    for (int i = -5; i >= -1000; i += -5)
    {

        Console.Write(i);
    }
    return;
}

else if (inputnum == "3")
{
    int fanum = 1;
    Factorial(fanum);
}


else
{
    Console.WriteLine("You Enter Wrong Number please be carefull!!!!");
}

double Calculator(double firstnum, double secondnum)
{
    Console.Write("Please input first number: ");
    var firstnumberstring = Console.ReadLine();
    var firstnumber = double.Parse(firstnumberstring);
    Console.Write("Please Choice operator between +,-,*,/ and ^: ");
    var op = Console.ReadLine();
    Console.Write("Please input second number: ");
    var secondnumberstring = Console.ReadLine();
    var secondnumber = double.Parse(secondnumberstring);
    double result = 0;
    if (op == "+")
        result = firstnumber + secondnumber;
    else if (op == "-")
        result = firstnumber - secondnumber;
    else if (op == "*")
        result = firstnumber * secondnumber;
    else if (op == "/")
        result = firstnumber / secondnumber;
    else if (op == "^")
    {
        result = 1;
        for (var j = 1; j <= secondnumber; j++)
        {
            result = result * firstnumber;
        }
    }
     

    else
    {
        Console.WriteLine("You are input a wrong operator");
        
    }
    Console.WriteLine("Result is: " + result);
    return result;
}

int Factorial(int fnum)
{
    int fact = 1;
    int num;
    int f;
    Console.Write("Please input a number: ");
    num = Convert.ToInt32(Console.ReadLine());
    for (f = 1; f <= num; f++)
    {

        fact = fact * f;
    }

    Console.Write(fact);
    return fnum;
}
