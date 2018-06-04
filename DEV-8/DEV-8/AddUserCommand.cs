using System;
using System.Collections.Generic;

namespace DEV_8
{
  /// <summary>
  /// Does "Add user" command.
  /// </summary>
  class AddUserCommand : ICommand
  {
    CommandReceiver receiver = new CommandReceiver();
    List<User> AllUsers = new List<User>();
    WorkerWithJSON workJSON = new WorkerWithJSON();

    private void Receier_SameLastNameHappend(object sender, CoincidenceOfTheSurnamesEventArgs eventArgs)
    {
      AllUsers = workJSON.Deserialized();
      string sameLastName = eventArgs.LastName;
      Console.WriteLine(sameLastName);
      Console.WriteLine($"Similar last name " + sameLastName + " has detected. Namesake is");
      List<User> listOfNamesakes = new List<User>();
      foreach (User u in AllUsers)
      {
        if (u.SecondName == sameLastName)
        {
          u.VriteInformationToConsole();
          listOfNamesakes.Add(u);
        }
      }
      workJSON.SerializedToListOfNamesakes(listOfNamesakes);
    }

    /// <summary>
    /// Implements Interface member Execute to "Add user" command.
    /// </summary>
    public void Execute()
    {
      receiver.SameLastNamesHappened += Receier_SameLastNameHappend;
      receiver.AddUser();
    }
  }
}