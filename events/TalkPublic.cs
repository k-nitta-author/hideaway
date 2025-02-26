using System;
using Hideaway.Entities;

namespace Hideaway.Events
{
    public class TalkPublic : IEvent
    {
        public string Speaker { get; set; }
        public string Message { get; set; }
        public IEntity Entity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get; set; }


        public TalkPublic(IEntity entity, string message)
        {
            Entity = entity;
            Message = message;
        }
    }
}