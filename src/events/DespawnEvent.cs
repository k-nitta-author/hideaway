using Hideaway.Entities;
using Hideaway.Events;
using Godot;
using System.Reflection.Metadata.Ecma335;

namespace Hideway.Events
{
    public class DespawnEvent : IEvent
    {
        public IEntity Entity { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public Vector2 Position {get; set;} // Position of the entity when it despawns
        public string Name { get; set; }

        // Constructor
        public DespawnEvent(IEntity entity, string name)
        {
            Entity = entity; // the entity the despawns
            Position = entity.Position; // the entity's position
            Name = name;

        }
    }
}