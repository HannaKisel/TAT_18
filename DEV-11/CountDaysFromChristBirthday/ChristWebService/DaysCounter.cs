using System;
using System.Web.Services;

namespace ChristWebService
{
  /// <summary>
  /// this class contains a method that counts the number of days from 
  /// the birth of Christ until the entered date
  /// </summary>
  [WebService(Description = "This web-service counts days from Christ birthday to your entered date", Namespace = tempuriNamespace)]
  public class DaysCounter
  {
    const string tempuriNamespace = "http://tempuri.org/";

    /// <summary>
    /// The method that counts the number of days from the birth of Christ until the date you entered
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    [WebMethod]
    public int CountDays(DateTime date)
    {
      DateTime dateOfChristBirthday = new DateTime(0001, 1, 1);
      return (int)(date - dateOfChristBirthday).TotalDays;
    }
  }
}