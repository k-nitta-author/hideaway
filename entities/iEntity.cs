using Godot;

namespace Hideaway.Entities
{
    // The Entity interface
    // designed according to event-driven architecture
    public interface IEntity
    {

        Vector2 Position { get; set;} // the position of the entity when event takes place

        void Initialize();
        void Update(double delta);
        void Destroy(); // destroys the entity, preferably after emitting a despawn event

    }
}