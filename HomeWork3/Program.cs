////Task1

Console.WriteLine("Enter 5 student grades: ");

int mark1 = Convert.ToInt16(Console.ReadLine());
int mark2 = Convert.ToInt16(Console.ReadLine());
int mark3 = Convert.ToInt16(Console.ReadLine());
int mark4 = Convert.ToInt16(Console.ReadLine());
int mark5 = Convert.ToInt16(Console.ReadLine());

if (mark1 < 1 || mark1 > 5  || mark2 < 1 || mark2 > 5 || mark3 < 1 || mark3 > 5 || mark4 < 1 || mark4 > 5 || mark5 < 1 || mark5 > 5) 
{
    Console.WriteLine("Entered invalid marks. Each mark must be a number between 1 and 5.");

}
else 
{
    double average = (mark1 + mark2 + mark3 + mark4 + mark5) / 5.0;

    if (average >= 4.0) 
    {
        Console.WriteLine("The student is admitted to the exam.");
    }
    else 
    {
        Console.WriteLine("The student is not admitted to the exam.");
    }

}
//Task2 

Console.WriteLine("Enter any number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result;

if (number % 2 != 0)
{
    result = number * 3;
}
else
{
    result = number / 2;

}
Console.WriteLine("Result:" + result);

// Task3 

double num1, num2, result;
char operation;

Console.WriteLine("Enter 1 number: ");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter 2 number: ");
num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter an operation (+, -, *, /): ");
operation = Convert.ToChar(Console.ReadLine());

if (operation == '+')
{
    result = num1 + num2;
    Console.WriteLine("Result: " + result);

}
else if (operation == '-')
{
    result = num1 - num2;
    Console.WriteLine("Result:" + result);

}
else if (operation == '*')
{
    result = num1 * num2;
    Console.WriteLine("Result: " + result);

}
else if (operation == '/')
{
    if (num2 != 0)
    {
        result = num1 / num2;
        Console.WriteLine("Result: " + result);
    }
    else
    {
        Console.WriteLine("Division by zero is impossible!");
    }
}
else
{
    Console.WriteLine("Wrong operation!");
}
Console.ReadLine();