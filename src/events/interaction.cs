using Hideaway.Entities;

namespace Hideaway.Events
{
    public class InteractionEvent : IEvent
    {
        public IEntity Entity { get; set; }
        public string Name { get; set; }

        public InteractionEvent(IEntity entity, string name)
        {
            Entity = entity;
            Name = name;
        }
    }
}