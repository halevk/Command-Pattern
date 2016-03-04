namespace CommandPattern
{
    public class RemoteController
    {
        public ITvCommand Command { private set; get; }

        public RemoteController(ITvCommand command)
        {
            this.Command = command;
        }

        public void ExecuteCommand(TV tv)
        {
            Command.Execute(tv);
        }

        public void ChangeCommand(ITvCommand command)
        {
            Command = command;
        }
    }
}