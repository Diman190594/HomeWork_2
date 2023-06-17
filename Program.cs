//Напишите программу, которая принимает на вход трехначное число и 
//на выходе показывает вторую цифру этого числа

/*
Console.Write("Enter your number:");
int getNumber = Convert.ToInt32(Console.ReadLine());

string showNumber = Convert.ToString(getNumber);

Console.WriteLine(showNumber[1]);
*/

//Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет

/*
Console.Write("Enter your number:");
int getNumber = Convert.ToInt32(Console.ReadLine());

string thirdElement = Convert.ToString(getNumber);
if (thirdElement.Length > 2)
{
    Console.Write("Third element = " + thirdElement[2]);
}
else
{
    Console.Write("Third element is not found");
}
*/

//Напишите программу которая, принимает на ахлд цифру, обозначающую день недели,
//и проверяет является ли этот день выходным.

Console.Write("Enter your number day of the week:");
int numb = Convert.ToInt32(Console.ReadLine());

void getDayOfTheWeek (int numb) 
{
    if (numb == 6 || numb == 7) 
    {
        Console.Write("Ура выходной");
    }
    else if (numb < 1 || numb > 7)
    {
      Console.Write("Ты ввел " + numb + " такого дня недели нет, ты явно устал введи цифру 6 или 7");
    }
    else
    {
        Console.Write("Опять работать");
    }
}
getDayOfTheWeek(numb);