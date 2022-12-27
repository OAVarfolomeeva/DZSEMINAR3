Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int num4 = number / 10 % 10;
int num5 = number % 10;
int nul = number / 10000;
        
 if (nul < 1 || nul > 9)
    {
        Console.WriteLine("Это не пятизначное число");
    }
    else if  (num1 == num5 && num2 == num4)
    {
        Console.WriteLine("Это палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
            