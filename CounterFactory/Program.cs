using System;

// README.md를 읽고 아래에 코드를 작성하세요.

CounterFactory factory = new CounterFactory();


Console.WriteLine("=== 단순 카운터 ===");
Func<int> simpleCounter = factory.CreateSimpleCounter();
for (int i = 0; i < 5; i++)
{
    Console.Write($"{simpleCounter()} ");
}

Console.WriteLine("\n=== 스텝 카운터 (step=3) ===");
Func<int> stepCounter = factory.CreateStepCounter(3);
for (int i = 0; i < 4; i++)
{
    Console.Write($"{stepCounter()} ");
}

Console.WriteLine("\n=== 범위 카운터 (1~3) ===");
Func<int> boundedCounter = factory.CreateBoundedCounter(1, 3);
for (int i = 0; i < 7; i++)
{
    Console.Write($"{boundedCounter()} ");
}

Console.WriteLine("\n=== 리셋 가능 카운터 ===");
Func<int> getCount;
Action increment;
Action reset;
factory.CreateResettableCounter(out increment, out reset, out getCount);

Console.Write($"호출: ");
for (int i = 0; i < 3; i++)
{
    increment();
    Console.Write($"{getCount()} ");
}

reset();

Console.Write($"\n리셋: ");
for (int i = 0; i < 2; i++)
{
    increment();
    Console.Write($"{getCount()} ");
}
Console.WriteLine();



class CounterFactory
{
    public Func<int> CreateSimpleCounter()
    {
        int count = 0;
        return () => ++count;
    }

    public Func<int> CreateStepCounter(int step)
    {
        int count = 0;
        return () => count += step;
    }
    public Func<int> CreateBoundedCounter(int min, int max)
    {
        int count = min;
        return () =>
        {
            int result = count;
            count++;
            if (count > max)
            {
                count = min;
            }
            return result;
        };
    }
    public void CreateResettableCounter(out Action increment, out Action reset, out Func<int> getCount)
    {
        int count = 0;
        increment = () => count++;
        reset = () => count = 0;
        getCount = () => count;
    }
}
