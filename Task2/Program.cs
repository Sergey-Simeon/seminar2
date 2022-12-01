// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 
// Не использовать строки для расчета

int Phrase(string message)

{
    System.Console.Write($"{message} > ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int number = Phrase("Введите трёхзначное число: ");
if(number >= 100 && number < 1000)
{
    number %= 100;
    number /= 10;
    System.Console.Write(number);
}
else
{
    System.Console.Write("Вы ввели не трехзначное число"); 
}
