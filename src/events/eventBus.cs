using Godot;

namespace Hideaway.Events
{
    public partial class EventBus : Node
    {

        public void Emit(string eventName, Variant data)
        {
            EmitSignal(eventName, data);
        }

    }
}