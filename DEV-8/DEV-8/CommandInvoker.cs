using System.Collections.Generic;

namespace DEV_8
{
  /// <summary>
  /// Set a list of commands, then run it.
  /// </summary>
  class CommandInvoker
  {
    private List<ICommand> listCommands = new List<ICommand>();

    /// <summary>
    /// Set command to list of commands.
    /// </summary>
    /// <param name="command">Command to be set.</param>
    public void SetCommand(ICommand command)
    {
      listCommands.Add(command);
    }

    /// <summary>
    /// Run commands from list.
    /// </summary>
    public void Run()
    {
      foreach (ICommand command in listCommands)
      {
        command.Execute();
      }
      listCommands.Clear();
    }
  }
}