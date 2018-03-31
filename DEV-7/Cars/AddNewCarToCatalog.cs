namespace Cars
{
  class AddNewCarToCatalog : ICommand
  {
    CommandReceiver receiver = new CommandReceiver();

    public void Execute()
    {
      receiver.AddCarToCatalog();
    }
  }
}