// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Не использовать строки
int Phrase(string message)

{
    System.Console.Write($"{message} > ");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}

int num = Phrase("Введите номер дня недели от 1 до 7: ");
    int day = num;
    if (day >= 1 && day <= 5)
    {
        System.Console.Write("День не выходной");
    }
    else if (day == 6 || day == 7)
    {
        System.Console.Write("Выходной день");
    }
    else
    {
    System.Console.Write("Вы ввели некорректный номер");
    }
