using System;
using System.Text;

namespace StringCreator
{
  /// <summary>
  /// This class contains methods that work with a string
  /// </summary>
  public class Line
  {
    private string currentLine;

    public string CurrentLine
    {
      get
      {
        return currentLine;
      }
      set
      {
        if (value.Length == 0)
        {
          throw new ArgumentException(); 
        }
        currentLine = value;
      }
    }

    public Line(string line)
    {
      CurrentLine = line;
    }

    /// <summary>
    /// This method creates a new string of characters from the source row with even indices
    /// </summary>
    /// <returns> A new line of characters from the source row with even indices</returns>
    public string GetSymbolsByEvenPositions()
    {
      StringBuilder newLine = new StringBuilder();
      for (int i = 0; i < CurrentLine.Length; i = i + 2)
      {
        newLine.Append(CurrentLine[i]);
      }
      return newLine.ToString();
    }
  }
}