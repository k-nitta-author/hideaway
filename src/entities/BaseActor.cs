

using Godot;
using Hideaway;
using Hideaway.Entities;
using Hideaway.Events;

public partial class BaseActor : CharacterBody2D, IEntity, IWalkable, IInteractor, IEventPublisher
{
    public AnimationPlayer Anim { get; set; }
    public Sprite2D Sprite { get; set; }
    public double Speed { get; set; }
    public bool IsWalking { get; set; }
    public bool CanInteract { get; set; }
    public IEventSubscriber[] Subscribers { get; set; }

    public virtual void Destroy()
    {
        
    }

    public virtual string GetWalkAnimation(Vector2 direction)
    {
        return "";
    }

    public virtual bool HasSubscribers()
    {
        return true;
    }

    public void Initialize()
    {
        
    }

    public virtual void Interact(IInteractible interactible)
    {
        
    }

    public virtual void Publish(IEvent e)
    {
        
    }

    public virtual void QueryInteraction()
    {
        
    }

    public void RegisterSubscriber(IEventSubscriber subscriber)
    {
        
    }

    public virtual void Stop()
    {
        
    }

    public virtual void Go()
    {
        
    }

    public virtual void Update(double delta)
    {
        
    }

    public virtual void Walk(double distance, Vector2 direction)
    {
        
    }
}
