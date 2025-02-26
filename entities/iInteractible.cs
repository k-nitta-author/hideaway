namespace Hideaway.Entities
{
    public interface IInteractible: IEntity
    {
        bool Interactible {get; set;} // whether a given entitiy is interactible

        public void Interact(); // the entity's interact function
        
    }
}