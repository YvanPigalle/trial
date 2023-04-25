//Задача:
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
// а какое меньшее.



/*
Console.Write ("Брат, впиши первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Впиши второе число, брат: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
if (num_1 > num_2) 
{
    Console.WriteLine ($"Первое число больше, брат");
}
if (num_2 > num_1)
{
    Console.WriteLine ($"Второе число больше, брат");
}
else num_1 = num_2;
{
    Console.WriteLine ($"Числа равны, брат");
}
*/




//Задача
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


/*
int max = 0;

Console.Write("Insert your first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Now insert your second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ok, what's yoour third number?: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 > max)
{
    max = num1;
}
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

Console.WriteLine("The biggest number is " + max);
*/


//Задача
//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
//(делится ли оно на два без остатка)


/*
Console.Write("Insert your number: ");
int num = Convert.ToInt32(Console.ReadLine());

int del = num % 2;

if (del == 0)
{
    Console.WriteLine("YEAH");
}
else
{
    Console.WriteLine("NOPE");
}
*/



//Задача
// Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N


Console.Write("Insert your number: ");
int num = Convert.ToInt32(Console.ReadLine());

int dubN = 2;

if(num > 1)
{
    while(dubN <= num)
    {
        Console.Write(dubN + " ");
        dubN += 2;
    }
}