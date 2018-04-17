using System;
using System.Collections.Generic;

namespace DEV_8
{
  /// <summary>
  /// This class contains all possible commands
  /// </summary>
  class CommandReciever
  {
    List<User> AllUsers = new List<User>();
    WorkerWithJSON workJSON = new WorkerWithJSON();
    DataCreator dataCreator = new DataCreator();

    /// <summary>
    /// This method add new user
    /// </summary>
    public void AddUser()
    {
      AllUsers = workJSON.Deserialized();// эта строка должна быть в каждом методе, она будет каждый раз считывать пользователей из файла в текущий момент. предпологается, что в файле всегда изначально кто-то есть
      UserRegistration createNewUser = new UserRegistration();
      AllUsers.Add(createNewUser.ReadNewUser());
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