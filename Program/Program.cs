using System;
using System.Collections.Generic;

public static class Utility
{
    // 1.1 Сортировка массива целых чисел (алгоритм сортировки пузырьком)
    public static int[] SortArray(int[] array)
    {
        if (array == null)
            throw new ArgumentNullException(nameof(array));

        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Обмен
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }

    // 1.2 Проверка является ли строка палиндромом
    public static bool IsPalindrome(string str)
    {
        if (str == null)
            throw new ArgumentNullException(nameof(str));

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

    // 1.3 Вычисление факториала для целого числа
    public static long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("Факториал не определен для отрицательных чисел.", nameof(n));

        else if (n > 24)
            throw new ArgumentException("Факториал зашел за лимит.", nameof(n));

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }


    // 1.4 Число Фибоначчи на указанной позиции
    public static long Fibonacci(int n)
    {
        if (n < 0)
            throw new ArgumentException("Индекс не может быть отрицательным.", nameof(n));

        if (n == 0) return 0;
        if (n == 1) return 1;

        long a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }


    // 1.5 Поиск подстроки в строке
    public static int IndexOfSubstring(string str, string substring)
    {
        if (str == null || substring == null)
            throw new ArgumentNullException("Строки не могут быть null.");

        return str.IndexOf(substring, StringComparison.Ordinal);
    }

    // 1.6 Проверка является ли число простым
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    // 1.7 Инверсия числа с проверкой на переполнение
    public static int ReverseInteger(int x)
    {
        int reversed = 0;
        while (x != 0)
        {
            int digit = x % 10;
            x /= 10;

            // Проверка на переполнение
            if (reversed > int.MaxValue / 10 || (reversed == int.MaxValue / 10 && digit > 7)) return 0;
            if (reversed < int.MinValue / 10 || (reversed == int.MinValue / 10 && digit < -8)) return 0;

            reversed = reversed * 10 + digit;
        }
        return reversed;
    }

    // 1.8 Преобразование числа в римские цифры
    public static string ToRoman(int num)
    {
        if (num <= 0 || num > 3999)
            throw new ArgumentException("Число должно быть в диапазоне от 1 до 3999.", nameof(num));

        var romanNumerals = new Dictionary<int, string>
    {
        {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
        {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
        {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"},
        {1, "I"}
    };

        string result = "";

        foreach (var item in romanNumerals)
        {
            while (num >= item.Key)
            {
                result += item.Value;
                num -= item.Key;
            }
        }

        return result;
    }


    static void Main()
    {

    }
}
