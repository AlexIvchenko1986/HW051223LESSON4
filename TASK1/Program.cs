// # Задание
// ## Задача 1: Напишите программу, которая бесконечно запрашивает 
//целые числа с консоли. Программа завершается при вводе символа ‘q’ 
//или при вводе числа, сумма цифр которого четная 

// **Пример :**
// * _5 12 16 q [STOP]_
// * _3 45 342 15 [STOP]_


Console.WriteLine("Введите число или q , чтобы выйти ");
string manualInputSymbol = Console.ReadLine();

while (true)
{

    if (manualInputSymbol == "q")
    {
        break;
    }
    // if(.....) = Как программе понять , что я ввожу число...? 
    //Проблема, что изначально используется тип String для символа "q"
    int manualInputNumber = Convert.ToInt32(Console.ReadLine());
    int sumOfDigits = 0;
    while (manualInputNumber > 0)
    {
        sumOfDigits = sumOfDigits + manualInputNumber % 10;
        manualInputNumber = manualInputNumber / 10;
        if (manualInputNumber % 2 == 0) // проверка на четность
        {
            Console.Write("[STOP]_ ");
            break;
        }
        else
        {
            Console.WriteLine("Повторите еще раз ");
        }

    }

}

