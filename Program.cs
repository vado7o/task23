// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();
Console.WriteLine("Задача 23: программа, выдающая таблицу кубов чисел от 1 до введённого числа\n");

while(true) {
Console.WriteLine("Введите целое число:\n");
if(int.TryParse(Console.ReadLine(), out int number)) {
    for(int i = 0; i <= number; i++) {
        Console.WriteLine(i + "^3 = " + Math.Pow(i, 3));
    }
    break;
} else Console.WriteLine("Некорректно введено число!\n");
}
