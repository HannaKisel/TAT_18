using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_8
{
  /// <summary>
  /// Contains methods that create the necessary information
  /// </summary>
  class DataCreator
  {
    /// <summary>
    /// Find the most popular woman name or some such names from all woman names
    /// </summary>
    /// <param name="users">List of users</param>
    /// <returns>List of popular woman names</returns>
    public List<String> FindPopularWomanNames(List<User> allUsers)
    {
      var women = allUsers.Where(user => user.Gender == "F");
      if (women.ToList().Count != 0)
      {
        var femaleUsersNames = women.GroupBy(woman => woman.FirstName).
            Select(woman => new { Name = woman.Key, Count = woman.Count() });
        var maxWomanNamesRepetition = femaleUsersNames.Max(womanName => womanName.Count);
        var popularWomanName = femaleUsersNames.Where(womanName => womanName.Count == maxWomanNamesRepetition)
                                              .Select(womanName => womanName.Name);
        return popularWomanName.ToList();
      }
      else
      {
        return null;
      }
    }

    /// <summary>
    /// Counts the average age using linq
    /// </summary>
    /// <param name="AllUsers"></param>
    /// <returns></returns>
    public double CountAverageAge(List<User> AllUsers)
    {
      return AllUsers.Select(u => u.Age).Average();
    }
    public List<User> FindEldestUsers(List<User> allUsers)
    {
      int maxAge = allUsers.Max(user => user.Age);
      var eldestUsers = allUsers.Where(user => user.Age == maxAge);
      return eldestUsers.ToList();
    }
  }
}