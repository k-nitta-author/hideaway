using System;
using Godot;
using Hideaway.Entities;

namespace Hideaway.Events
{
    public class ItemGet : IEvent
    {
        public string Name { get; set; }
        public IEntity Entity { get; set; }
        public string ItemName { get; set; }
        public string Source { get; set; }

        public ItemGet(string name, IEntity entity, string itemName, string source)
        {
            Name = name;
            Entity = entity;
            ItemName = itemName;
            Source = Source;
        }
    }
}