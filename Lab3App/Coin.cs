using System;
namespace Lab3App
{
    public class Coin : Treasure
    {
        public int Value { get; set; }

        public Coin(string description, int score, int value) : base(description, score)
        {
            Value = value;
        }

        public override void Display()
        {
            Console.WriteLine($"{GetType().Name} {Description} is displayed");
        }

        // Use consistent method name with the base class
        public override void UpdateTotalScore()
        {
            if (Board != null)
            {
                ((CollectionBoard)Board).UpdateTotalValue(Value);
            }
        }
    }
}
