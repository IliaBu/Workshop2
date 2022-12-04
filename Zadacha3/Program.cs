/* Задача 3: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да  */

Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 7 == 0 && number1 % 23 == 0 ) {
Console.WriteLine(Convert.ToString(number1) + " -> да");
}
else {
Console.WriteLine(Convert.ToString(number1) + " -> нет");
}