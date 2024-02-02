using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        protected Tool(string description) : base(description)
        {
        }

        public virtual void DoAction()
        {
            Console.WriteLine($"{GetType().Name} is used");
        }

        public override void AddMe(List<Collectable> collectables)
        {
            base.AddMe(collectables);
            DoAction();
        }
    }
}
