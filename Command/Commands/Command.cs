namespace Command
{
    public abstract class Command : ICommand
    {
        protected Receiver _receiver;

        public Command(Receiver receiver)
        {
            _receiver = receiver;
        }

        public abstract void Execute();
    }
}
