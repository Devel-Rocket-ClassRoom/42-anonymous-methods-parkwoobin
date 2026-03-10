using System;

// README.md를 읽고 아래에 코드를 작성하세요.

/*
static int Square(int a)
{
    return a * a;
}

Calculator calc = Square;

Console.WriteLine(calc(5));

delegate int Calculator(int a);
*/


/*
Transformer square = delegate (int x) { return x * x; };
Console.WriteLine($"3의 제곱: {square(3)}");

Transformer cube = delegate (int x) { return x * x * x; };
Console.WriteLine($"3의 세제곱: {cube(3)}");

delegate int Transformer(int a);
*/

/*
Func<int, int> doubler = delegate (int x) { return x * 2; };
Console.WriteLine($"{doubler(10)}");

Action<string> logger = delegate (string msg) { Console.WriteLine($"[LOG] {msg}"); };
logger("작업 시작");
*/


/*
SimpleDelegate handler = delegate
{
    Console.WriteLine($"매개변수를 사용하지 않습니다.");
};

handler(100, "테스트");

delegate void SimpleDelegate(int a, string b);
*/


EventHandler onClick = delegate
{
    Console.WriteLine($"클릭 이벤트 발생!");
};

onClick(null, EventArgs.Empty);

delegate void EventHandler(object sender, EventArgs e);







