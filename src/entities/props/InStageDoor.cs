using Godot;
using System;
using Hideaway.Events;
using Hideaway.Entities.Props;

public partial class InStageDoor : Area2D, IEventBusPublisher, IProp
{
    public AnimationPlayer Anim { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Sprite2D Sprite { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Destroy()
    {
        throw new NotImplementedException();
    }

    public void Initialize()
    {
        throw new NotImplementedException();
    }

    public void Publish(IEvent e)
    {
        throw new NotImplementedException();
    }

    public void Update(double delta)
    {
        throw new NotImplementedException();
    }
}
