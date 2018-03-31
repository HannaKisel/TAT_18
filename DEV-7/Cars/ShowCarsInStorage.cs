namespace Cars
{
  class ShowCarsInStorage : ICommand
  {
    CommandReceiver receiver = new CommandReceiver();

    public void Execute()
    {
      receiver.ShowCars();
    }
  }
}