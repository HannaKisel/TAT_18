namespace EqualSymbols
{
  /// <summary>
  /// This class contains a method that works with a string
  /// </summary>
  class WorkerWithString
  {
    /// <summary>
    /// This method counts the maximum number of identical consecutive characters in a string
    /// </summary>
    /// <param name="characterSequence">original character sequence</param>
    /// <returns> The maximum number of identical consecutive characters in a string </returns>
    public int DetermineMaxOfRepetitions(string characterSequence)
    {
      int maxRepetitions = 0;
      for (int i = 0; i < (characterSequence.Length - 1); i++)
      {
        int counter = 0;
        char firstSymbol = characterSequence[i];
        for (int j = i + 1; j < characterSequence.Length; j++)
        {
          char nextSymbol = characterSequence[j];
          if (firstSymbol == nextSymbol)
          {
            counter++;
          }
          else
          {
            break;
          }
        }
        if (maxRepetitions < counter)
        {
          maxRepetitions = counter;
        }
      }
      return maxRepetitions + 1;
    }
  }
}