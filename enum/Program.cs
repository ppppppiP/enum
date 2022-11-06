// 4.104, 4.114.
// 4.104.Соссотавить программу, которая в зависимости от порядкового номера дня не-дели (1, 2,..., 7)
// выводит на экран его название (понедельник, вторник, ..., воскресенье).

/*4.114 Дата некоторого дня характеризуется тремя натуральными числами: g(год), m(порядковый номер месяца) и n(число).
По заданным g, n и m определить:
а) дату предыдущего дня;
б) дату следующего дня.В обеих задачах рассмотреть два случая:
1) заданный год не является високосным;
2) заданный год может быть високосным (см.задачу 4.65).
*/
Console.WriteLine("(4.104 Введите порядковый номер дня недели от 1 до 7");
int day = Convert.ToInt32(Console.ReadLine());

switch(day)
{
   case 1:
        Console.WriteLine(Wk.ПОНЕДЕЛЬНИК);
        break;
   case 2:
        Console.WriteLine(Wk.ВТОРНИК);
        break ;
   case 3:
        Console.WriteLine(Wk.СРЕДА);
        break;
    case 4:
        Console.WriteLine(Wk.ЧЕТВЕРГ);
        break;
    case 5:
        Console.WriteLine(Wk.ПЯТНИЦА);
        break;
    case 6:
        Console.WriteLine(Wk.СУББОТА);
        break;
    case 7:
        Console.WriteLine(Wk.ВОСКРЕСЕНЬЕ);
        break;

}
Console.WriteLine();

Console.Write("(4.114 Введите год: ");
int year = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер месяца: ");
int mounth = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите день: ");
int dayZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Дата предыдущего дня: {dayZ - 1}.{mounth}.{year}");
Console.WriteLine($"Дата следующего дня: {dayZ + 1}.{mounth}.{year}");

if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
{
    Console.WriteLine("Год високосный");
}
else
{
    Console.WriteLine("Год не високосный");
}





enum Wk
{
    ПОНЕДЕЛЬНИК,
    ВТОРНИК,
    СРЕДА,
    ЧЕТВЕРГ,
    ПЯТНИЦА,
    СУББОТА,
    ВОСКРЕСЕНЬЕ
}

