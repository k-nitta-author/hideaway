namespace Hideaway.Entities
{
    public interface IInteractor
    {
        bool CanInteract {get; set;} // is true if entity can interact at all; useful for cutscenes

        void QueryInteraction(); // check if entity can interact at the moment

        void Interact(IInteractible interactible);

        
    }
}