using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DEV_8
{
  class WorkerWithJSON
  {
    private const string pathToJsonFileWithUsers = @"D:\TAT_18\TAT_18\DEV-8\ListOfUsers.json";
    private const string pathToJsonFileWithNamesakes = @"D:\TAT_18\TAT_18\DEV-8\ListOfTheNamesakes.json";

    /// <summary>
    /// Writes to the list of users
    /// </summary>
    /// <param name="users"></param>
    public void Serialized(List<User> users)
    {
      //List<User> users = CreateList();
      string serialized = JsonConvert.SerializeObject(users);
      using (StreamWriter file = new StreamWriter(pathToJsonFileWithUsers))
      {
        file.Write(serialized);
      }
    }

    /// <summary>
    /// Writes to the list of Namesakes
    /// </summary>
    /// <param name="users"></param>
    public void SerializedToListOfNamesakes(List<User> users)
    {
      //List<User> users = CreateList();
      string serialized = JsonConvert.SerializeObject(users);
      using (StreamWriter file = new StreamWriter(pathToJsonFileWithNamesakes))
      {
        file.Write(serialized);
      }
    }

    /// <summary>
    /// Writes to the collection
    /// </summary>
    /// <returns></returns>
    public List<User> Deserialized()
    {
      List<User> usersFromFile = new List<User>();
      usersFromFile = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(pathToJsonFileWithUsers));
      return usersFromFile;
    }
  }
}