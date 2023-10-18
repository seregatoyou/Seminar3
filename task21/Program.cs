// using System;
//   // Не удаляйте и не меняйте метод Main! 
// public static void Main(string[] args) {
//         int x1, x2, x3, y1, y2, y3;

//         if (args.Length >= 6) {
//             x1 = int.Parse(args[0]);
//             x2 = int.Parse(args[1]);
//             x3 = int.Parse(args[2]);
//             y1 = int.Parse(args[3]);
//             y2 = int.Parse(args[4]);
//             y3 = int.Parse(args[5]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             x1 = 3;
//             x2 = 6;
//             x3 = 8;
//             y1 = 2;
//             y2 = 1;
//             y3 = -7;
//         }

//         // Не удаляйте строки ниже
//         double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
//         Console.WriteLine($"{result:F2}");
//     }
// public class Answer
// {
//     private static double Length(int[] pointA, int[] pointB)
//     {
//       // Введите свое решение ниже
//         double total = 0;
//        int[] pointA = [x1, x2, x3];
//        int[] pointB = [y1, y2, y3];

//         for (int i = 0; i < 2; i++){
//         double sqr = Math.Pow(pointB[i] - pointA[i], 2);
//         total = total + sqr;
//         }
//         double root = Math.Sqrt(sqr);
//         return root;
//     }

//     }
int[] pointA1 = {3, 6, 8};
int[] pointB1 = {2, 1, -7};
double Length(int[] pointA, int[] pointB)
    {
        double total = 0;
        for (int i = 0; i <= 2; i++){
        
        double sq = Math.Pow(pointB1[i] - pointA1[i], 2);
        total = total + sq;
        }
        double root = Math.Sqrt(total);
        Console.WriteLine($"Расстояние между точками в пространстве: {root}");
        return root;
    }
Length(pointA1, pointB1);