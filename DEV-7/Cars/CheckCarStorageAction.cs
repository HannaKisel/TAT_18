namespace Cars
{
  class CheckCarStorageAction : ICommand
  {
    CommandReceiver receiver = new CommandReceiver();

    public void Execute()
    {
      receiver.GiveSuitableMachines();
    }
  }
}