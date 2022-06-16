// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа./

int number = new Random().Next(1, 1000);
System.Console.Write(number);

int number1 = number;
System.Console.Write("  Резултат после удаления второй цифры : " + number1 / 10 / 10);
System.Console.WriteLine(number1 % 10);

