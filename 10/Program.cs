// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


//Варианты решения: 

// без использования рандомайзера и конструкции if/else


Console.WriteLine("Введите трехзначное число:");
	int num = Convert.ToInt32(Console.ReadLine());
	int Length = num.ToString().Length;
        if (Length == 3) 
            {
                int num1 = ( num/10 ) % 10;
                Console.WriteLine($"Вторая цифра введенного числа {num1}");
            } 
        else 
            {
                Console.WriteLine("Вы ввели не трехзначное число");
            }

//   и еще раз  без использования рандомайзера, но  с  конструкцией if/else


// Console.WriteLine("Введите трехзначное число: ");
// 	int num = Convert.ToInt32(Console.ReadLine());
// if (num > 99 && num < 1000)
//     {
//     int num1 = num / 10 % 10;
//     Console.WriteLine($"вторая цифра - {num1}");
//     }
// else Console.WriteLine("Число не трехзначное, что странно.  Попробуйте еще раз =)  ");   


//   с использованием рандомайзера

// int num = new Random().Next(99,1000);
// Console.WriteLine(num);
// int num1 = num / 10 % 10;;  
// Console.WriteLine($"вторая цифра - {num1}");


//   и еще раз  с использованием рандомайзера и конструкции if/else


// int num = new Random().Next(99,1000);
// Console.WriteLine(num);

// if (num > 99 && num < 1000)
//     {
//     num1 = num / 10 % 10;
//     Console.WriteLine($"вторая цифра - {num1}");

//     }
// else Console.WriteLine("Число не трехзначное, что странно.");


