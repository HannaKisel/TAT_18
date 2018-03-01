namespace EqualSymbols
{
  /// <summary>
  /// This class contains a method that works with a string
  /// </summary>
  class Sequence
  {
    public string CurrentSequence { get; private set; }

    public Sequence(string sequence)
    {
      CurrentSequence = sequence;
    }

    /// <summary>
    /// This method counts the maximum number of identical consecutive characters in a string
    /// </summary>
    /// <param name="characterSequence">original character sequence</param>
    /// <returns> The maximum number of identical consecutive characters in a string </returns>
    public int DetermineMaxOfRepetitions()
    {
      int maxRepetitions = 0;
      int counter = 0;
      char firstSymbol = CurrentSequence[0];
      for (int i = 1; i < CurrentSequence.Length - 1; i++)
      {
        if (firstSymbol == CurrentSequence[i + 1])
        {
          counter++;
        }
        else
        {
          firstSymbol = CurrentSequence[i + 1];
          counter = 0;
        }
        if (maxRepetitions < counter)
        {
          maxRepetitions = counter;
        }
      }
      return maxRepetitions;
    }
  }
}