int count = CountPositiveNumbers();
Console.WriteLine($"Количество чисел больше 0: {count}");


static int CountPositiveNumbers()
{
    Console.WriteLine("Введите числа (для завершения ввода введите любой символ, не являющийся числом):");
    int count = 0;

    while (true)
    {
        int number;
        if (int.TryParse(Console.ReadLine(), out number))
        {
            if (number > 0)
            {
                count++; // Увеличиваем счетчик, если число больше 0
            }
        }
        else
        {
            break; // Прерываем цикл, если ввод не является числом
        }
    }

    return count;
}
