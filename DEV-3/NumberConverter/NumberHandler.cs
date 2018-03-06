using System;
using System.Collections;
using System.Text;

namespace NumberConverter
{
  class NumberHandler
  {
    private int systemBase;

    public int Number { get; set; }

    public int SystemBase
    {
      get
      {
        return systemBase;
      }
      set
      {
        if (value < 2 || value > 20)
        {
          throw new ArgumentException();
        }
        systemBase = value;
      }
    }

    public NumberHandler(int number, int systemBase)
    {
      Number = number;
      SystemBase = systemBase;
    }

    /// <summary>
    /// method converts the number to the required number system
    /// </summary>
    /// <returns></returns>
    public string ConvertNumber()
    {
      StringBuilder newNumber = new StringBuilder();
      ArrayList arrayOfResidues = new ArrayList();

      arrayOfResidues = CalculateRemainderOfDivision();
      arrayOfResidues.Reverse();

      if (systemBase > 10)
      {
        foreach (int el in arrayOfResidues)
        {
          if (el >= 10)
          {
            newNumber.Append(ConvertNumberIntoLetter(el));
          }
          else
          {
            newNumber.Append(el);
          }
        }
      }
      else
      {
        foreach (int el in arrayOfResidues)
        {
          newNumber.Append(el);
        }
      }
      return newNumber.ToString();
    }

    /// <summary>
    /// This method calculates the remainders from the division into the base of the required number system
    /// </summary>
    /// <returns></returns>
    private ArrayList CalculateRemainderOfDivision()
    {
      ArrayList newNumber = new ArrayList();
      while (Number != 0)
      {
        newNumber.Add(Number % SystemBase);
        Number = Number / systemBase;
      }
      return newNumber;
    }

    /// <summary>
    /// This method converts a number greater than 9 into the corresponding letter
    /// </summary>
    /// <returns>letter corresponding to the entered number</returns>
    private char ConvertNumberIntoLetter(int el)
    {
      return (char)('A' + el - 10);
    }
  }
}