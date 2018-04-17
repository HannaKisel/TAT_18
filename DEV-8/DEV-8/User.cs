using System;

namespace DEV_8
{
  /// <summary>
  /// this class is the essence of the user
  /// </summary>
  class User// if "class" replace to "struct" it doesn't work. Why!??
  {
    private string firstName;
    private string secondName;
    private string gender;
    private int age;

    public string FirstName
    {
      get => firstName;
      set
      {
        if (value.Length > 0 || string.Empty.Equals(value))
        {
          firstName = value;
        }
        else
        {
          throw new FormatException("String is empty");
        }
      }
    }

    public string SecondName
    {
      get => secondName;
      set
      {
        if (value.Length > 0 || string.Empty.Equals(value))
        {
          secondName = value;
        }
        else
        {
          throw new FormatException("String is empty");
        }
      }
    }

    public string Gender
    {
      get => gender;
      set
      {
        if (value.Length > 0 || string.Empty.Equals(value))
        {
          gender = value;
        }
        else
        {
          throw new FormatException("String is empty");
        }
      }
    }

    public int Age
    {
      get
      {
        return age;
      }
      set
      {
        if (value <= 0)
        {
          throw new FormatException("Amount should be positive");
        }
        age = value;
      }
    }

    public User(string firstName, string secondName, string gender, int age)
    {
      FirstName = firstName;
      SecondName = secondName;
      Gender = gender;
      Age = age;
    }

    public void VriteInformationToConsole()
    {
      Console.WriteLine("first name is {0} \n second name is {1}\n gender is {2}\n age is {3}" + firstName, secondName, gender, age);
    }
  }
}