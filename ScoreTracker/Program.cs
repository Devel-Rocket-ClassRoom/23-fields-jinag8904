using System;

ScoreTracker math = new ScoreTracker("math");
math.ShowScore();
Console.WriteLine();
math.SetScore(85);
math.AddBonus(10);
math.AddBonus(20);
math.SetScore(101);
Console.WriteLine();
math.ShowScore();

class ScoreTracker
{
    const int maxScore = 100;
    const int minScore = 0;
    readonly string subject;
    private int score = 0;
    private int bonusCount = 0;

    public ScoreTracker(string sub)
    {
        subject = sub;
    }

    public void SetScore(int score)
    {
        if(score < 0 || score > 100)
        {
            Console.WriteLine("점수는 0 ~ 100 사이여야 합니다.");
        }

        else
        {
            this.score = score;
            Console.WriteLine($"점수를 {this.score}점으로 설정했습니다.");
        }
    }

    public void AddBonus(int bonus)
    {
        score += bonus;
        if(score > 100)
        {
            score = 100;
        }
        bonusCount++;
        Console.WriteLine($"{bonus}점 보너스 적용! 현재 점수: {score}점");
    }

    public void ShowScore()
    {
        Console.WriteLine($"=== {subject} ===");
        Console.WriteLine($"점수: {score}/{maxScore}\n보너스 적용 횟수: {bonusCount}");
    }
}



