using System;
using System.Collections.Generic;

// README.md를 읽고 아래에 코드를 작성하세요.


int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("=== 원본 배열 출력 ===");
ForEach(x => Console.Write($"{x} "));
Console.WriteLine();

Console.WriteLine("=== 2배로 변환 ===");
int[] doubled = Transform(x => x * 2);
Console.WriteLine(string.Join(" ", doubled));

Console.WriteLine("=== 짝수만 필터링 ===");
int[] evens = Filter(x => x % 2 == 0);
Console.WriteLine(string.Join(" ", evens));

Console.WriteLine("=== 합계 계산 ===");
int sum = Reduce((acc, x) => acc + x, 0);
Console.WriteLine($"합계: {sum}");


void ForEach(Action<int> action)
{
    foreach (int number in numbers)
    {
        action(number);
    }
}

int[] Transform(Func<int, int> transformer)
{
    int[] result = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = transformer(numbers[i]);
    }
    return result;
}

int[] Filter(Func<int, bool> predicate)
{
    List<int> result = new List<int>();
    foreach (int number in numbers)
    {
        if (predicate(number))
        {
            result.Add(number);
        }
    }
    return result.ToArray();
}

int Reduce(Func<int, int, int> reducer, int initialValue)
{
    int result = initialValue;
    foreach (int number in numbers)
    {
        result = reducer(result, number);
    }
    return result;
}