// Напишете программу, которая принимает на вход координаты (X и Y), 
// причем Х ≠ 0 и Y ≠ 0 и выдает номер четверти плоскости,
// в которой находится эта точка

Console.Clear();
Console.Write("Введите X: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0){
    Console.WriteLine("1");
}else if(x < 0 && y > 0){
    Console.WriteLine("2");
}else if(x < 0 && y < 0){
    Console.WriteLine("3");
}else if(x > 0 && y > 0){
    Console.WriteLine("4");
}else if(x == 0 && y == 0){
    Console.WriteLine("На оси");
}