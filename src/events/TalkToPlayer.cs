using System;
using Hideaway.Entities;

namespace Hideaway.Events
{
    public class TalkToPlayer : IEvent
    {
        public string Speaker { get; set; }
        public string Message { get; set; }
        public IEntity Entity { get; set; }
        public string Name { get; set; }


        public TalkToPlayer(IEntity entity, string message)
        {
            Entity = entity;
            Message = message;
        }
    }
}