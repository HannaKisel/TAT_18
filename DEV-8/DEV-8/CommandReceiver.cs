using System;
using System.Collections.Generic;

namespace DEV_8
{
  /// <summary>
  /// Contains methods for commands
  /// </summary>
  class CommandReceiver
  {
    CommandInvoker commandInvoker = new CommandInvoker();
    public event EventHandler<CoincidenceOfTheSurnamesEventArgs> SameLastNamesHappened;
    List<User> AllUsers = new List<User>();
    WorkerWithJSON workJSON = new WorkerWithJSON();
    DataCreator dataCreator = new DataCreator();

    /// <summary>
    /// Invokes event SameLastNamesHappened.
    /// </summary>
    /// <param name="eventArgs">Event arguments.</param>
    public virtual void OnSameLastNamesHappened(CoincidenceOfTheSurnamesEventArgs eventArgs)
    {
      SameLastNamesHappened?.Invoke(this, eventArgs);
    }

    /// <summary>
    /// This method add new user
    /// </summary>
    public void AddUser()
    {
      AllUsers = workJSON.Deserialized();
      UserRegistration createNewUser = new UserRegistration();
      User newUser = createNewUser.ReadNewUser();
      AllUsers.Add(newUser);
      bool namesakesFound = false;
      foreach (User u in AllUsers)
      {
        if (u.SecondName == newUser.SecondName)
        {
          namesakesFound = true;
        }
      }
      if (namesakesFound == true)
      {
        CoincidenceOfTheSurnamesEventArgs args = new CoincidenceOfTheSurnamesEventArgs();
        args.LastName = newUser.SecondName;
        OnSameLastNamesHappened(args);
      }
      workJSON.Serialized(AllUsers);
    }

    /// <summary>
    /// This method gets average age of users
    /// </summary>
    public void GetAverageAge()
    {
      AllUsers = workJSON.Deserialized();
      Console.WriteLine(dataCreator.CountAverageAge(AllUsers));
    }

    /// <summary>
    ///  This method gets eldest users of all
    /// </summary>
    public void GetEldestUser()
    {
      AllUsers = workJSON.Deserialized();
      foreach (User elderUser in dataCreator.FindEldestUsers(AllUsers))
      {
        Console.WriteLine(elderUser.FirstName + " " + elderUser.SecondName + "; Age is " + elderUser.Age);
      }
    }

    /// <summary>
    /// This method gets popular woman names
    /// </summary>
    public void GetPopularWomanName()
    {
      AllUsers = workJSON.Deserialized();
      if (dataCreator.FindPopularWomanNames(AllUsers) != null)
      {
        Console.WriteLine("Popular woman name: ");
        foreach (string name in dataCreator.FindPopularWomanNames(AllUsers))
        {
          Console.WriteLine(name);
        }
      }
      else
      {
        Console.WriteLine("There no womans");
      }
    }
  }
}