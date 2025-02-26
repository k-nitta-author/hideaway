using System;
using Godot;
using Hideaway.Entities;

namespace Hideaway.Events
{
    public class ItemGive : IEvent
    {
        public string Name { get; set; }
        public IEntity Entity { get; set; }
        public string ItemName { get; set; }
        public string Target { get; set; }

        public ItemGive(string name, IEntity entity, string itemName, string target)
        {
            Name = name;
            Entity = entity;
            ItemName = itemName;
            Target = target;
        }
    }
}