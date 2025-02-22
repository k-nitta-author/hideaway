using Hideaway.Entities;
using Hideaway.Events;
using Godot;

namespace Hideway.Events
{
    public class DespawnEvent : IEvent
    {
        public IEntity Entity { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Vector2 Position {get; set;} // Position of the entity when it despawns

        // Constructor
        public DespawnEvent(IEntity entity)
        {
            Entity = entity; // the entity the despawns
            Position = entity.Position; // the entity's position
            
        }
    }
}