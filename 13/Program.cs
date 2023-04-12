// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Задача требует уточнения условия, т.к. например, в данном случае максимальное вводимое число ограничено методом Convert.ToInt32 (от 0 до 4 294 967 295), 


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int numLeng = num.ToString().Length;
    if (numLeng >= 3)
        {
            while (num > 999)
            {
                num = num / 10;
            }
            int num3 = num % 10;
            Console.WriteLine($"Третья цифра введенного числа {num3} ");
        } 
    else
    {
        Console.WriteLine("Упс. Введеное число содержит менее трех цифр. Попробуйте еще раз.");
    }


//  через генератор


//  int num = new Random().Next();
// Console.WriteLine("Сгенерированное число:");
// Console.WriteLine(num);
// int numLeng = num.ToString().Length;
//     if (numLeng >= 3)
//         {
//             while (num > 999)
//             {
//                 num = num / 10;
//             }
//             int num3 = num % 10;
//             Console.WriteLine($"Третья цифра введенного числа {num3} ");
//         } 
//     else
//     {
//         Console.WriteLine("Упс. Сгенерированное число содержит менее трех цифр. вы проиграли =)");
//     }



