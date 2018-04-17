using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_8
{
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
    /// This class count average age of users
    /// </summary>
    /// <param name="AllUsers"></param>
    /// <returns></returns>
    public double CountAverageAge(List<User> AllUsers)
    {
      return AllUsers.Select(u => u.Age).Average();
    }

    /// <summary>
    /// This method finds the oldest users
    /// </summary>
    /// <param name="allUsers"></param>
    /// <returns></returns>
    public List<User> FindEldestUsers(List<User> allUsers)
    {
      int maxAge = allUsers.Max(user => user.Age);
      var eldestUsers = allUsers.Where(user => user.Age == maxAge);
      return eldestUsers.ToList();
    }
  }
}