using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    public User()
    {
    }

    public void VriteInformationToConsole()
    {
      Console.WriteLine(" first name is " + FirstName + " \n second name is " + SecondName + "\n gender is " + Gender + "\n age is " +Age);
    }
  }
}