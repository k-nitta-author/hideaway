namespace Hideaway.Entities
{
    public interface IEntity
    {
        void Initialize();
        void Update(float delta);
        void Destroy();
    }
}