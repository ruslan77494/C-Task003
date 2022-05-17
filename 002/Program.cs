/* Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y) */

//Сначала получить число > проверить 1.2.3.4.> выдать диапозон

 int  GetQuarter()
{
    while (true)
    {
        Console.WriteLine("Введите четверть чей диапозон хотите узнать");
        int quater = Convert.ToInt32(Console.ReadLine());
        if (quater != 1 && quater != 2 && quater != 3 && quater != 4) 
        {
            Console.WriteLine("Введите 1,2,3 или 4");
    }
    else
            return quater;
        }
}

void GetRange(int quater )  // функция принимает входной параметр
{
    if (quater == 1)
    {
        Console.WriteLine("x > 0 , y > 0");
    }
    else if (quater == 2 )
    {
        Console.WriteLine("x < 0 , y > 0"); 
    }
    else if (quater == 3)
    {
         Console.WriteLine("x < 0 , y < 0");
    }
    else 
    {
         Console.WriteLine("x > 0 , y < 0");
    }
}

int giveQuater = GetQuarter();
GetRange(giveQuater);
