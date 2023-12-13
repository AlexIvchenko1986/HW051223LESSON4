// Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.) 

// Пример :
// [1 3 5 6 7 8] => [8 7 6 5 3 1]

// добавление переменной temp.

int[] array = new int[8]; // создание массива с N элементов
Random rnd = new Random();
int temp;

for (int i = 0; i < array.Length; i++) // Зполнение массива случайными числами
{
    array[i] = rnd.Next(1, 10);
    Console.Write($"{array[i]} ");
}
Console.Write("=> ");
// пересорт массива
for (int i = 0; i < array.Length / 2; i++) // цикл до середины массива
{
    temp = array[i];
    array[i] = array[array.Length - 1 - i]; // обращение через последний эл.т массива
    array[array.Length - 1 - i] = temp;
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}

