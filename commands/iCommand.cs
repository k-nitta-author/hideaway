namespace Hideaway.Commands{

    // The Command interface
    public interface ICommand
    {
        void Execute();
        void Undo();
    }

}