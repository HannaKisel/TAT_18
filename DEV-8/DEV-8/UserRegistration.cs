using System;

namespace DEV_8
{
  class UserRegistration
  {
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