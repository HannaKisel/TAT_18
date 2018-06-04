namespace DEV_8
{
  /// <summary>
  /// Does "Get popular woman name" command.
  /// </summary>
  class GetMostPopularWomanNameCommand : ICommand
  {
    CommandReceiver receiver = new CommandReceiver();

    /// <summary>
    /// Implements Interface member Execute to "Get popular woman name" command.
    /// </summary>
    public void Execute()
    {
      receiver.GetPopularWomanName();
    }
  }
}