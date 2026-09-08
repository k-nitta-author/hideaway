using Godot;
using Hideaway.Events;

public partial class Game : Node2D
{
    EventBus eventBus = new EventBus(); // an instance of the event bus to pass to children

    // bind game to children to give reference
    private void BindGame(Game game){}


}
