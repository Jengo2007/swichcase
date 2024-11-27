// See https://aka.ms/new-console-template for more information


var day =Int32.Parse(Console.ReadLine());

var month =Int32.Parse(Console.ReadLine());
if (day > 1)
{
    day -=1;
    
}
else
{


    switch (month)
    {
        case 1:
            day = 31;
            month = 12;
            break;
        case 2:
            day = 31;
            month =1;
            break;
        case 3:
            day = 28;
            month=2;
            break;
        case 4:
            day = 31;
            month = 3;
            break;
        case 5:
            day = 30;
            month = 4;
            break;
        case 6:
            day = 31;
            month = 5;
            break;
        case 7:
            day = 30;
            month = 6;
            break;
        case 8:
            day = 31;
            month = 7;
            break;
        case 9:
            day = 31;
            month = 8;
            break;
        case 10:
            day = 30;
            month = 9;
            break;
        case 11:
            day = 31;
            month = 10;
            break;
        case 12:
            day = 30;
            month = 11;
            break;
        default:
            Console.WriteLine("Invalid month");
            break;
    }
}

Console.WriteLine($"Предыдуший день{(day) + "-" + (month)}");

