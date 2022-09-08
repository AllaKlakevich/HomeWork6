// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// int[] CreateArray(int size){
//     int[] array = new int[size];
//         for(int i=0; i<size; i++){
//         Console.Write("Введите число: " );
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }     
// return array; 
// }

// int CountPositiv(int[] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//         if(array[i] > 0) count++;
//     }
// return count;
// }

// Console.Write("Введите число М: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = CreateArray(size);
// int count = CountPositiv(array);
// Console.WriteLine($"Количество положительных чисел в массиве: {count}");


// // Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// //  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Function(double b1, double b2, double k1, double k2){
    double x = (b2 - b1)/(k1 - k2);
    double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения двух прямых имеет координаты: x {x} и y {y}");
}


Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Function(b1, b2, k1, k2);
