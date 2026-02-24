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
