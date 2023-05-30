
// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите количество чисел: ");
//         int m = int.Parse(Console.ReadLine());

//         int count = 0;

//         for (int i = 0; i < m; i++)
//         {
//             Console.Write($"Введите число {i + 1}: ");
//             int num = int.Parse(Console.ReadLine());

//             if (num > 0)
//             {
//                 count++;
//             }
//         }

//         Console.WriteLine($"Количество чисел больше 0: {count}");

//         Console.ReadLine();
//     }
// }

// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         double b1, k1, b2, k2;

        
//         Console.Write("Введите b1: ");
//         b1 = double.Parse(Console.ReadLine());
//         Console.Write("Введите k1: ");
//         k1 = double.Parse(Console.ReadLine());
//         Console.Write("Введите b2: ");
//         b2 = double.Parse(Console.ReadLine());
//         Console.Write("Введите k2: ");
//         k2 = double.Parse(Console.ReadLine());

        
//         double x = (b2 - b1)/(k1 - k2);
//         double y = k1 * x + b1;

        
//         Console.WriteLine($"Точка пересечения: ({x}; {y})");
//     }
// }