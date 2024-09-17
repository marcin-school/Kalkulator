
double result = 0;

Console.WriteLine("Type first number");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type second number");
int num2 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Choose option");
Console.WriteLine("\t1) Add");
Console.WriteLine("\t2) Substract");
Console.WriteLine("\t3) Multiply");
Console.WriteLine("\t4) Divide");

switch (Console.ReadLine()) {
    case "1":
        result = num1 + num2;
        break;
    case "2":
        result = num1 - num2;
        break;
    case "3":
        result = num1 * num2;
        break;
    case "4":
        result = num1 / num2;
        break;
}

Console.WriteLine($"Your result is {result}");
