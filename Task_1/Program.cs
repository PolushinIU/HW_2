// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа./

int promt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberInt = promt ("Введите трехзначное число: ");
if (numberInt <= 99 || numberInt >= 1000 )
{ 
    System.Console.WriteLine("Введено не верное число");
}
else  System.Console.WriteLine("Вторая цифра введенного числа: " + numberInt /10 % 10);

