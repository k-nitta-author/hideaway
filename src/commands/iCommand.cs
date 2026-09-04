namespace Hideaway.Commands{

    // The Command interface
    public interface ICommand
    {
        void Execute(Godot.Node target);
        
        void Undo(Godot.Node target);
    }

}