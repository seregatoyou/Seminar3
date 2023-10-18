using System.Globalization;
// void IsPalindrome(int number){
//         int h = number;
//         int i = 1;
//         while(number / 10 != 0){
//             number = number / 10;
//             i++;
//         }
//         System.Console.WriteLine($"{i}");
//         if (i < 5 || i > 5){
//             System.Console.WriteLine("Число не пятизначное!");
//         }
//         else{
//             for(int j = 10; j <=100; j=j*10){
//                 int x = h % (1000*j);
//                 x = x / (100*j);
//                 int y = (h*10) % (10000/j);
//                 y = y /(1000/j);
//                 if (x != y){
//                     System.Console.WriteLine("Число не является палиндромом.");
//                 }
//             }
//             System.Console.WriteLine("Число является палиндромом.");
//         } 
// }

//using System;
using System;

public class Answer
{
    static bool IsPalindrome(int number){
      // Введите свое решение ниже
      int h = number;
        int i = 1;
        while(number / 10 != 0){
            number = number / 10;
            i++;
        }
        System.Console.WriteLine($"{i}");
        if (i < 9 || i > 9){
            System.Console.WriteLine("Число не пятизначное!");
            return false;
        }
        else{
            for(int j = 10; j <=100; j=j*10){
                int x = h % (1000*j);
                x = x / (100*j);
                int y = (h*10) % (10000/j);
                y = y /(1000/j);
                if (x != y){
                    System.Console.WriteLine("Число не является палиндромом.");
                    return false;
                }
            }
            System.Console.WriteLine("Число является палиндромом.");
            return true;
        }
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 645717546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}