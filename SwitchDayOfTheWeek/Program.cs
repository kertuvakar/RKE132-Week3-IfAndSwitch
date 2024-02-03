
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

switch (weekDay) //väärtus, mida kontrollitakse
{ 
case 0://case 0 on sama, mis if avaldis, mis kontrollib, kas weekDay võrdub nulliga
        //if(weekDay ==0)
        Console.WriteLine("It`s Sunday!");
        break;//lõpetab switch käsu töö
case 1:
        Console.WriteLine("It`s Monday!");
        break;
case 2:
        Console.WriteLine("It`s Tuesday!");
        break;
case 3:
        Console.WriteLine("It`s Wendesday!");
        break;
case 4:
        Console.WriteLine("It`s Thursday!");
        break;
case 5:
        Console.WriteLine("It`s Friday!");
        break;
case 6:
        Console.WriteLine("It`s Saturday!");
        break;
default:    //et haldada juhtumit, kui väärtus ei vasta ühelegi nendest väärtustest
        Console.WriteLine("There is something wrong with your calendar!");
        break;
}
Console.WriteLine("Have a nice day!");