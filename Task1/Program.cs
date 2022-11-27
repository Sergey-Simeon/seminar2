//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Не использовать строки

int Phrase(string message)

{
    System.Console.Write($"{message} > ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int num = Phrase("Введите трёхзначное число: ");
if(num >= 100 && num < 1000)
{
   int result = ((num / 10) % 10);
   System.Console.Write($"Вторая чифра введенного числа: {result}");
}
else
{
   System.Console.Write("Вы ввели не трехзначное число"); 
}