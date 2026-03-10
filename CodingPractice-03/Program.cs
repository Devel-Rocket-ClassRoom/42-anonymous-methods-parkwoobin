using System;

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

Calculator lambda2 = a => a * a;


Console.WriteLine($"익명 메서드: {anonymous(5)}");
Console.WriteLine($"람다식 (블록): {lambda1(5)}");
Console.WriteLine($"람다식 (표현식): {lambda2(5)}");


delegate int Calculator(int a);
*/


/*
EventHandler handler1 = delegate
{
    Console.WriteLine("이벤트 처리됨");
};

EventHandler handler2 = (sender, e) =>
{
    Console.WriteLine("이벤트 처리됨");
};

handler1(null, EventArgs.Empty);
handler2(null, EventArgs.Empty);

delegate void EventHandler(object sender, EventArgs e);
*/
/*
GameEvent onScoreChange = delegate { };
GameEvent onGameOver = delegate { };

onScoreChange("점수 변경", 100);
onGameOver("게임 종료", 0);


onScoreChange += delegate (string name, int value)
{
    Console.WriteLine($"[이벤트] {name}: {value}");
};


onScoreChange("점수 변경", 500);

delegate void GameEvent(string eventName, int value);
*/

int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;

ProcessData(numbers, delegate (int item)
{
    sum += item;
    Console.WriteLine($"처리중 {item}, 누적: {sum}");
});

Console.WriteLine($"최종 합계: {sum}");


static void ProcessData(int[] data, Action<int> callback)
{
    foreach (int item in data)
    {
        callback(item);
    }
}





