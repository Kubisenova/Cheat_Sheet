﻿// Шпаргалка:
// // Типы данных
// // int - целое число
int x = 5;
// // // double - дробное число (ещё есть float, decimal, но мы будем использовать double)
// double y = 2.5;
// // // string - строка
// // string str = "Привет всем!";
// // // bool - логический тип данных. Может принимать значения true (истина) или false (ложь)
// bool b = y > x; // 2.5 > 5 == false
// Console.WriteLine(b);


// // Блоки кода
// // Пространство между двумя фигурными скобками называется блок кода
// !!! то что существует внутри блока кода, не существует вне блока кода !!
// {
//     int abc = 5;
// }

// Console.WriteLine(abc); // ошибка - abc не существует



// // // Ветвление if..else
// if (x == 5) // == - проверка на равенство
// // // если выражение в скобках верное, то выполняется этот блок кода
// {
//     Console.WriteLine("x это пять");
// }
// else
// // // если выражение не верное, то выполняется блок кода после else
// {
//     Console.WriteLine("x это НЕ пять");
// }





// // // Цикл
//  int a = 0;
//  while (a < 5)
// // // если условие в скобках верное, то выполняется этот блок кода
//  {
//      Console.WriteLine(a);
//      a++; // увеличение a на единицу
    // равнозначно с:
     // a = a + 1;
     // a += 1;
// }

// форматирование текста в vs code - alt + shift + f (для Windows)

// Вывод в консоль:
// Console.WriteLine(переменная) - выводит переменную в консоль и переходит на новую строку
// Console.Write(переменная) - выводит переменную в консоль и остаётся на этой строке

// Console.WriteLine(1);
// Console.WriteLine(2);

// Console.Write(1);
// Console.Write(234);

// Чтение с консоли:
// Console.ReadLine() - читает строку с консоли (до тех пор, пока не будет нажат enter)

// string text = Console.ReadLine();

// Перевод строки в число:

// Convert.ToInt32(переменная) - переводит переменную в целое число (int)
// Convert.ToDouble(переменная) - переводит переменную в дробное число число (double)

Console.WriteLine("Введите число: ");
string text = Console.ReadLine();
int number = Convert.ToInt32(text);

int abc = number * number;
Console.WriteLine("Ответ: ");
Console.WriteLine(abc);



// else
// // если выражение не верное, то выполняется блок кода после else
// {
//     Console.WriteLine("x это НЕ пять");
// }

// // Цикл
// int a = 0;
// while (a < 5)
// // если условие в скобках верное, то выполняется этот блок кода
// {
//     Console.WriteLine(a);
//     a++; // увеличение a на единицу
//     // равнозначно с:
//     // a = a + 1;
//     // a += 1;
// }

// форматирование текста в vs code - alt + shift + f (для Windows)

// Вывод в консоль:
// Console.WriteLine(переменная) - выводит переменную в консоль и переходит на новую строку
// Console.Write(переменная) - выводит переменную в консоль и остаётся на этой строке

// Console.WriteLine(1);
// Console.WriteLine(2);

// Console.Write(1);
// Console.Write(234);

// Чтение с консоли:
// Console.ReadLine() - читает строку с консоли (до тех пор, пока не будет нажат enter)

// string text = Console.ReadLine();

// Перевод строки в число:

// Convert.ToInt32(переменная) - переводит переменную в целое число (int)
// Convert.ToDouble(переменная) - переводит переменную в дробное число число (double)

// Console.WriteLine("Введите число: ");
// string text = Console.ReadLine();
// int number = Convert.ToInt32(text);

// int abc = number * number;
// Console.WriteLine("Ответ: ");
// Console.WriteLine(abc);
