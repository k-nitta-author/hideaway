namespace Hideaway.Events
{
    public interface IEventSubscriber
    {
        void SubscribeTo(IEventPublisher publisher);
        void UnsubscribeFrom(IEventPublisher publisher);
    }
}