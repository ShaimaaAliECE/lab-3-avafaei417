using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score { get; set; }

        protected Treasure(string description, int score) : base(description)
        {
            Score = score;
        }

        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            UpdateTotalScore();
        }

        // Marked as virtual to allow override in derived classes
        public virtual void UpdateTotalScore()
        {
            if (Board != null)
            {
                ((CollectionBoard)Board).UpdateTotalScore(Score);
            }
        }
    }
}
