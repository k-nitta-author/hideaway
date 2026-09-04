using System.Reflection.Metadata;
using Hideaway.Commands;
using Hideaway.Entities;


namespace Hideaway.Events
{
    public interface IEvent
    {
        IEntity Entity {get; set;}

        string Name {get; set;}


    }
}