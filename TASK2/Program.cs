//Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// Пример :
// [344 452 341 125] => 2

// Пока без использования методов. 

int[] arrayThreeDigit = new int[4]; // создание массива с N элементов
Random rnd = new Random();
int count = 0;

for (int i = 0; i < arrayThreeDigit.Length; i++) // Зполнение массива случайными числами
{
    arrayThreeDigit[i] = rnd.Next(100, 999);
    Console.Write($"{arrayThreeDigit[i]} ");

    if (arrayThreeDigit[i] % 2 == 0) // проверка на четность
    {
        count++;
    }
    // else
    // {
    //     Console.WriteLine("Четные числа не найдены ");
    // }
}
Console.WriteLine($" => {count} ");


