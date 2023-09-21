// See https://aka.ms/new-console-template for more information
Console.Title = "SkyNet";
Console.ForegroundColor = ConsoleColor.Green;
int num1;
int num2;
int add, sub, mul, div;
int choice;
Console.Write("Enter the First Number");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter The Second Number");
num2 = Convert.ToInt32(Console.ReadLine());

//Condition 
Console.WriteLine("What operationn you want to perform enter your choice\n1. for Addition press 1\n2. for Substraction presss 2\n3. for Multiplication press 3\n4. for Division press 4");

choice = Convert.ToInt32(Console.ReadLine());

// conditional statements
if (choice == 1)
{
    add = num1 + num2;
    Console.WriteLine("Addition: " + add);
}
else if (choice == 2)
{
    sub = num1-num2;
    Console.WriteLine("Substraction: " + sub);
}
else if (choice == 3)
{
    mul = num1 * num2;
    Console.WriteLine("Multiplication: " + mul);
}
else if (choice == 4)
{
    div = num1/num2;
    Console.WriteLine("Division: " + div);
}
else 
{
    Console.WriteLine("Enter the proper choice");
}

Console.ReadKey();