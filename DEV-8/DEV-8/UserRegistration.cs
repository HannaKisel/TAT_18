using System;

namespace DEV_8
{
  /// <summary>
  /// This class contains a method that creates a new user with the entered parameters
  /// </summary>
  class UserRegistration
  {
    /// <summary>
    /// Method that creates a new user with the entered parameters
    /// </summary>
    /// <returns>new user</returns>
    public User ReadNewUser()
    {
      Console.WriteLine("Enter user's first name");
      string firstName = Console.ReadLine();
      Console.WriteLine("Enter user's second name");
      string secondName = Console.ReadLine();
      Console.WriteLine("Enter user's gender(M or F)");
      string gender = Console.ReadLine();
      Console.WriteLine("Enter user's age");
      int age = int.Parse(Console.ReadLine());
      return new User(firstName, secondName, gender, age);
    }
  }
}