using System;
using System.Data;

// 1.
Player pc = new Player();
pc.ShowStatus();

Console.WriteLine();

// 2.
Character ch = new Character();
ch.name = "용사";
ch.level = 10;

Console.WriteLine($"{ch.name}\n{ch.level}");
Console.WriteLine();

// 3.
Character2 ch2 = new Character2();
ch2.SetInfo("용사", 10);
ch2.ShowInfo();
Console.WriteLine();

// 4.
Player2 pc2 = new Player2();
pc2.ShowStatus();
Console.WriteLine();

// 5.
Say.Hi();
Console.WriteLine();

// 6.
Schedule.PrintWeekDays();
Console.WriteLine();

// 7.
DefaultValues.ShowDefaults();
Console.WriteLine();

// 8.
Counter counter1 = new Counter();
Counter counter2 = new Counter();
Counter counter3 = new Counter();
Console.WriteLine();

// 9.
Player3 p1 = new Player3("용사");
Player3 p2 = new Player3("마법사");
Player3 p3 = new Player3("궁수");
Console.WriteLine(p1.name);
Console.WriteLine(p2.name);
Console.WriteLine(p3.name);
Console.WriteLine($"총 플레이어 수: {Player3.totalCount}");
Console.WriteLine();

// 10.
GameConfig gc = new GameConfig();
gc.ShowConfig();
Console.WriteLine();

// 11.
Example ex = new Example();
ex.ShowValues();
Console.WriteLine();

// 12.
Player4 player = new Player4();
player.SetInfo("용사", 10);
player.ShowInfo();
Console.WriteLine();

// 13.
Person p = new Person();
p.ShowProfile();
Console.WriteLine();

// 14.
GameCharacter gc1 = new GameCharacter("용사", 15);
GameCharacter gc2 = new GameCharacter("마법사", 25);
gc1.ShowInfo();
Console.WriteLine();
gc2.ShowInfo();
Console.WriteLine();
gc2.Attack(30);
gc2.Attack(50);
gc2.Attack(50);
Console.WriteLine();
GameCharacter.ShowTotalCharacters();

// 14.
class GameCharacter
{
    private string name;
    private int currentHP;
    private int attack = 100;

    private static int characterCount = 0;

    private readonly int maxHP = 100;
    private const int minHP = 0;


    public GameCharacter(string name, int attack)
    {
        this.name = name;
        this.attack = attack;
        this.currentHP = maxHP;
        characterCount++;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"=== {name} ===");
        Console.WriteLine($"체력: {currentHP}/{maxHP}");
        Console.WriteLine($"공격력: {attack}");
    }

    public void Attack(int damage)
    {
        currentHP -= damage;

        if (currentHP < minHP)
        {
            currentHP = 0;
        }

        Console.WriteLine($"{name}이(가) {damage} 데미지를 받음! 남은 체력: {currentHP}");
    }

    public static void ShowTotalCharacters()
    {
        Console.WriteLine("총 캐릭터 수: " + characterCount);
    }
}

// 13.
class Person
{
    private string name = "홍길동";
    private const int Age = 21;
    private readonly string nickName = "길동이";
    private string[] websites = { "네이버", "구글" };

    public void ShowProfile()
    {
        Console.Write($"이름: {name}\n나이: {Age}\n닉네임: {nickName}\n사이트: ");
        foreach (string s in websites)
        {
            Console.Write(s);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

// 12.
class Player4
{
    private string name;
    private int level;

    public void SetInfo(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"이름: {name}\n레벨: {level}");
    }
}

// 11.
class Example
{
    const double Pi = 3.14159;
    readonly DateTime createdAt;

    public Example()
    {
        createdAt = DateTime.Now;
    }

    public void ShowValues()
    {
        Console.WriteLine($"원주율: {Pi}\n생성 시간: {createdAt}");
    }
}


// 10.
class GameConfig
{
    readonly string version = "1.0.0";
    readonly int maxPlayers;

    public GameConfig()
    {
        maxPlayers = 4;
    }

    public void ShowConfig()
    {
        Console.WriteLine($"버전: {version}\n최대 플레이어: {maxPlayers}");
    }
}

// 9.
class Player3
{
    public string name;
    public static int totalCount;

    public Player3(string name)
    {
        this.name = name;
        totalCount++;
    }
}

// 8.
class Counter
{
    public static int count;

    public Counter()
    {
        count++;
        Console.WriteLine($"현재 카운트: {count}");
    }
}

// 7.
class DefaultValues
{
    static int number;
    static bool flag;
    static string text;

    static public void ShowDefaults()
    {
        Console.WriteLine($"number: {number}\nflag: {flag}\ntext: {((text==null) ? "null" : text)}");
    }
}

// 6.
class Schedule
{
    static string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

    static public void PrintWeekDays()
    {
        foreach (string s in days)
        {
            Console.Write($"{s}\t");
        }

        Console.WriteLine();
    }
}

// 5.
class Say
{
    static string message = "안녕하세요.";

    static public void Hi()
    {
        message = "반갑습니다.";
        Console.WriteLine(message);
    }
}

// 4.
class Player2
{
    string name = "이름없음";
    int health = 100;
    int level = 1;

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}\n체력: {health}\n레벨: {level}");
    }
}

// 3.
class Character2
{
    private string name;
    private int level;

    public void SetInfo(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"이름: {name}\n레벨: {level}");
    }
}

// 2.
class Character
{
    public string name;
    public int level;
}

// 1.
class Player
{
    string name;
    int health;

    public void ShowStatus()
    {
        Console.WriteLine($"이름: {name}\n체력: {health}");
    }
}