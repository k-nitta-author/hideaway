namespace Hideaway.Events
{
    public interface IEventBusPublisher
    {
        void Publish(IEvent e);
    }
}