using Hideaway.Events;

namespace Hideaway
{
    public interface IEventPublisher
    {
        IEventSubscriber[] Subscribers { get; set; }

        void Publish(IEvent e); // publish event and notify all subscribers about it
        bool HasSubscribers(); // check if there are any subscribers
    }
}