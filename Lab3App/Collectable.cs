using System;
using System.Collections.Generic;


namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        public string Description { get; set; }
        public CollectionBoard Board { get; set; }

        protected Collectable(string description)
        {
            Description = description;
        }

        public virtual void AddMe(List<Collectable> collectables)
        {
            if (collectables.Contains(this))
            {
                collectables.Remove(this);
                Console.WriteLine($"{GetType().Name} {Description} is removed");
            }
            else
            {
                collectables.Add(this);
                Console.WriteLine($"{GetType().Name} {Description} is added");
            }
        }


    }
}
