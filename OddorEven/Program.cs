

Console.WriteLine("Enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());//salvestab selle väärtuse muutujasse usernum
//Kas kasutaja arv on paaris või paaritu
//loome uue muutuja, see on klassikaline lähenemine. Voib ka if lauset teha

int result = userNum % 2;


if(result != 0) //kontrollib, kas tulemus ei ole null
                 //kui tulemus ei ole null, siis on tulemus on paaritu arv
{
    Console.WriteLine("User number is odd.");
}else 
{
    Console.WriteLine("User number is even.");
}
