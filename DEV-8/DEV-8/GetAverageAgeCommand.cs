namespace DEV_8
{
  /// <summary>
  /// Does "Get age" command.
  /// </summary>
  class GetAverageAgeCommand : ICommand
  {
    CommandReceiver receiver = new CommandReceiver();

    /// <summary>
    /// Implements Interface member Execute to "Get age" command.
    /// </summary>
    public void Execute()
    {
      receiver.GetAverageAge();
    }
  }
}