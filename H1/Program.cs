// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
 Console.Write("Введите пятизначное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Проверяем, является ли число палиндромом
        bool isPalindrome = IsPalindrome(number);

        // Выводим результат
        if (isPalindrome)
            Console.WriteLine("Число является палиндромом.");
        else
            Console.WriteLine("Число не является палиндромом.");

        Console.ReadLine();
    

    static bool IsPalindrome(int number)
    {
        // Преобразуем число в строку
        string str = number.ToString();

        // Проверяем, является ли строка палиндромом
        int left = 0;
        int right = str.Length - 1;

        while (left < right)
        {
            if (str[left] != str[right])
                return false;

            left++;
            right--;
        }

        return true;
    }


