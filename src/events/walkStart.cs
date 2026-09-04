using Hideaway.Entities;

namespace Hideaway.Events
{

    // emitted when an entity starts walking
    public class WalkStart: IEvent
    {
        // The entity that started walking
        public IEntity Entity { get; set; }
        public string Name { get; set; }


        // Constructor
        public WalkStart(IEntity entity)
        {
            this.Entity = entity;
        }
    }
}