using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.


/*
Calculator anonymous = delegate (int a)
{
    return a * a;
};

Calculator lambda1 = (int a) =>
{
    return a * a;
};

Console.WriteLine($"익명 메서드: {anonymous(5)}");
Console.WriteLine($"람다식: {lambda1(5)}");


delegate int Calculator(int a);
*/

/*
int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

List<int> evenNumbers = Filter(numbers, n => n % 2 == 0);
Console.WriteLine("짝수: " + string.Join(", ", evenNumbers));

List<int> oddNumbers = Filter(numbers, n => n > 5);
Console.WriteLine("5보다 큰 수: " + string.Join(", ", oddNumbers));

static List<int> Filter(int[] source, Func<int, bool> predicate)
{
    List<int> result = new List<int>();
    foreach (int number in source)
    {
        if (predicate(number))
        {
            result.Add(number);
        }
    }
    return result;
}
*/

int factor = 10;

Func<int, int> normalMethod = delegate (int a)
{
    return a * factor;
};

Func<int, int> staticMethod = static delegate (int n) { return n * 2; };

Console.WriteLine($"{normalMethod(5)}");
Console.WriteLine($"{staticMethod(5)}");







