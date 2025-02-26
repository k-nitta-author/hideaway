namespace Hideaway.Events
{
    public interface IEventBusSubscriber
    {
        // Subscribe to the event bus
        void Subscribe(IEventBusPublisher eventBus);
    
        // Unsubscribe from the event bus
        void Unsubscribe(IEventBusPublisher eventBus);
    }
}