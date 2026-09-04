namespace Hideaway.Entities
{
    public interface IJumpable
    {

        int JumpStrength {get; set;}

        int JumpHeight {get; set;}

        bool IsJumping {get; set;}

        public void Jump(); // the basic jump method
    }
}