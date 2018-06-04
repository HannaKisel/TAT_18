namespace DEV_8
{
  /// <summary>
  /// Does "Get elder" command.
  /// </summary>
  class GetOldestPersonCommand : ICommand
  {
    CommandReceiver receiver = new CommandReceiver();

    /// <summary>
    /// Implements Interface member Execute to "Get elder" command.
    /// </summary>
    public void Execute()
    {
      receiver.GetEldestUser();
    }
  }
}