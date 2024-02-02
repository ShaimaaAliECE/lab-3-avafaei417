using System;
namespace Lab3App
{
    public class CollectionBoard
    {
        public int TotalScore { get; set; }
        public int TotalValue { get; set; }

        public void UpdateTotalScore(int score)
        {
            TotalScore += score;
        }

        public void UpdateTotalValue(int value)
        {
            TotalValue += value;
        }

        public void Display()
        {
            Console.WriteLine($"Total Score: {TotalScore}");
            Console.WriteLine($"Total Value: {TotalValue}");
        }
    }
}
