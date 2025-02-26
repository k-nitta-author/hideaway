using Hideaway.Entities;

namespace Hideaway.Events
{
    public class ExitStage : IEvent
    {
        public string Name { get; set; }
        public IEntity Entity { get; set ; }
        public string PreviousStage { get; set; }
        public string NextStage { get; set; }

        public ExitStage(string name, IEntity entity, string previousStage, string nextStage)
        {
            Name = name;
            Entity = entity;
            PreviousStage = previousStage;
            NextStage = nextStage;
        }
    }

}