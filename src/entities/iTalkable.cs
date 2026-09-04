namespace Hideaway.Entities
{
    // for entities that can talk
    public interface ITalkable
    {
        // talk
        // meant to create and output a talk event
        void Talk(string dialogue);
    }
}