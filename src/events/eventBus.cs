using System;
using Godot;

namespace Hideaway.Events
{
    public partial class EventBus : Node
    {
        public static EventBus Instance { get; private set; }

        public override void _Ready()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else
            {
                GD.PrintErr("There should only be one instance of EventBus");
            }
        }

        public void Emit(string eventName, Variant data)
        {
            EmitSignal(eventName, data);
        }

    }
}