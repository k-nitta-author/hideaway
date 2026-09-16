using Godot;
using Hideaway.Events;

public partial class Game : Node2D
{
    EventBus eventBus = new EventBus(); // an instance of the event bus to pass to children

    [Export(PropertyHint.FilePath)]
    string stageFilePath;

    Stage stage;

    // bind game to children to give reference
    void BindGame(Game game){}

    public override void _Ready()
    {
        stage = LoadStageFrom(stageFilePath)
        .Setup(this)
        .WithPlayerAt(Vector2.Zero);

        AddChild(stage);
    }

    Stage LoadStageFrom(string FilePath){ return GD.Load<PackedScene>(FilePath).Instantiate<Stage>(); }

    void UnloadStage()
    {
        RemoveChild(stage);
        stage = null;
    }    

}
