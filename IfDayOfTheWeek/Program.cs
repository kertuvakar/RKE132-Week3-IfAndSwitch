//proovime tuvastada, mis nädalapäev täna on. Saame enda arvutist

int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //uus muutuja nimega WeekDay. Iga tarkvara võtab op.süsteemi käest kellaaja
//arvutid loevad aega millisekundites, mis on väga suur andmeühik. UCI formaadi aeg

if (weekDay == 0)
{
    Console.WriteLine("It`s Sunday!");
}
else if (weekDay == 1)
{
    Console.WriteLine("It`s Monday!");
}
else if (weekDay == 2)
{
    Console.WriteLine("It`s Tuesday!");
}
else if (weekDay == 3)
{
    Console.WriteLine("It`s Wendesday!");
}
else if (weekDay == 4)
{
    Console.WriteLine("It`s Thursday!");
}
else if (weekDay == 5)
{
    Console.WriteLine("It`s Friday!");
}
else 
{
    Console.WriteLine("It`s Saturday!"); 
}
    