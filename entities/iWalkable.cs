namespace Hideaway.Entities
{
    public interface IWalkable
    {
        double Speed {get; set;}
        double PositionX { get; set; }
        double PositionY { get; set; }

        void Walk(float distance);
        void Stop();
        bool IsWalking { get; }
    }
}