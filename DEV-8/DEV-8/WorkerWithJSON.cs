using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DEV_8
{
  /// <summary>
  /// This class work with JSON file
  /// </summary>
  class WorkerWithJSON
  {
    private const string pathToJsonFileWithUsers = @"D:\TAT_18\TAT_18\DEV-8\ListOfUsers.json";

    /// <summary>
    /// This method writes to a file from the list of users
    /// </summary>
    /// <param name="users">list of users</param>
    public void Serialized(List<User> users)
    {
      string serialized = JsonConvert.SerializeObject(users);
      using (StreamWriter file = new StreamWriter(pathToJsonFileWithUsers))
      {
        file.Write(serialized);
      }
    }

    /// <summary>
    /// This method is written to the user list
    /// </summary>
    /// <returns>list of users</returns>
    public List<User> Deserialized()
    {
      List<User> usersFromFile = new List<User>();
      usersFromFile = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(pathToJsonFileWithUsers));
      return usersFromFile;
    }
  }
}