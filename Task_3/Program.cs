// Напишите программу, которая выводит третью цифру заданного числа
 // или сообщает, что третьей цифры нет./

    int promt(string message)
{
    System.Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberInt = promt ("Введите число:  ");

if (numberInt <= 99)
{ 
    System.Console.WriteLine("Введено не верное число"); 
}
else 
  { while (numberInt >= 1000)
   {
      numberInt = numberInt / 10;
   }
   numberInt = numberInt % 10;
 System.Console.WriteLine("третья цифра введенного числа: " + numberInt);
  }


