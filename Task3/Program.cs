// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
//. Не использовать строки
int Phrase(string message)

{
    System.Console.Write($"{message} > ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int num = Phrase("Введите число: ");
if (num > 99)
{
    while (num > 999)
    {
        num /= 10;
    }
    System.Console.Write($"Третья цифра = {num % 10}");
}
else
{
     System.Console.Write("Третья цифра отсутствует");
}