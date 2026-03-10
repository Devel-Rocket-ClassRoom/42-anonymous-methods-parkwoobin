using System;

// README.md를 읽고 아래에 코드를 작성하세요.


/*
Calculator calc = delegate (int a) { return a * a; };
Console.WriteLine(calc(5)); // 25

Calculator lambda = (int a) => a * a;
Console.WriteLine(lambda(5)); // 25

delegate int Calculator(int a);
*/

/*
int factor = 3;

Func<int, int> multiplier = delegate (int a) { return a * factor; };
Console.WriteLine(multiplier(10));
*/

/*
int factor = 2;

Func<int, int> multiplier = delegate (int n) { return n * factor; };

Console.WriteLine($"factor = 2일 때: {multiplier(5)}"); // 20

factor = 10;
Console.WriteLine($"factor = 10일 때: {multiplier(5)}"); // 100
*/


/*
int counter = 0;

Action increment = delegate () { counter++; Console.WriteLine($"현재 카운터: {counter}"); };
increment();
increment();
increment();
Console.WriteLine($"최종 카운터: {counter}"); // 3
*/




Func<int> counter1 = CreateCounter();
Func<int> counter2 = CreateCounter();

Console.WriteLine($"CreateCounter");
counter1();
Console.WriteLine($"counter1: {counter1()}");
Console.WriteLine($"counter1: {counter1()}");
Console.WriteLine($"counter2: {counter2()}");
Console.WriteLine($"counter2: {counter2()}");

static Func<int> CreateCounter()
{
    int count = 0;
    return delegate () { count++; return count; };
}







