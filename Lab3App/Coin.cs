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

        
        public virtual void UpdateTotalValue()
        {
            if (Board != null)
            {
                ((CollectionBoard)Board).UpdateTotalValue(Value);
                Console.WriteLine($"Total Value is updated to: {Value}");
            }
        }
    }
}
