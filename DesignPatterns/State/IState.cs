namespace DesignPatterns.State
{
    public interface IState
    {
        public void Action(CustomerContext customerContext, decimal amount);
        
    }
}
