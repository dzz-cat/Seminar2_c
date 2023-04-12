// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// Вариант 1

Console.Write("Введите номер дня недели от 1 до 7 (Понедельник - 1, Вторник - 2 и т.д.):  ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) {
	if (Day >= 6) {
		Console.Write("Ура! Сегодня выходной");
	} else {
		Console.Write("Увы. Это рабочий день");
	}
} else {
	Console.Write("Введите  любое число от 1 до 7");
}


// Вариант 2

// bool Correct(int dayNum)
//     {
//         if  (dayNum > 0 && dayNum < 8)
//             {
//             return true;
//             }
//         else 
//             {
//                 return false;
//             }
//     }

// Console.WriteLine("Введите номер дня недели от 1 до 7 (Понедельник - 1, Вторник - 2 и т.д.):  ");
// int dayNum = Convert.ToInt32(Console.ReadLine());

// if (Correct(dayNum))
//     {
//         if (dayNum > 0 && dayNum < 6)
//         { 
//             Console.WriteLine("Увы, это рабочий день");
           
//         }

//         else if (dayNum > 6 && dayNum < 8)
//         {
//             Console.WriteLine("Ура, выходной!");
            
//         }
//     }
// else 

//     {
//     Console.WriteLine("Вы уверены, что ввели правильный номер?");
//     }
