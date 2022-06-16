// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным./
int promt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberInt = promt ("Введите цифру дня недели: ");

if (numberInt < 1 || numberInt > 7) 
{
  System.Console.WriteLine("Данная цифра не является днём недели");
  Environment.Exit(0);
}
if (numberInt == 6 || numberInt == 7)
System.Console.WriteLine("Это выходной");
else System.Console.WriteLine("Это не выходной");

