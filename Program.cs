/*
##Задача 19
Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.Clear();
Console.Write("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());
string numText = Convert.ToString(num);
   void CheckingForPolynomial (int num)
   { 
    if (numText.Length == 5)
    {
      if (numText[0] == numText[4] || numText[1] == numText[3])
        {Console.WriteLine("Данное число - палиндром");}
        else{Console.WriteLine("Данное число - не палиндром");}
    }
    else {Console.WriteLine("Вы введи не пятизначное число");}
   }
    
CheckingForPolynomial(num);
