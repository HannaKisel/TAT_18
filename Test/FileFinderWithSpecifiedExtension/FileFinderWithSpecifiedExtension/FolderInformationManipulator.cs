using System.Collections.Generic;
using System.Text;

namespace FileFinderWithSpecifiedExtension
{
  class FolderInformationManipulator
  {
    public string FilePath { get; private set; }

    public FolderInformationManipulator(string filePath)
    {
      FilePath = filePath;
    }

    public List<string> GetFilesWithSpecifiedExtension(string specifiedExtension)
    {
      StringBuilder filesList = new StringBuilder();
      return ;
    }   
  }
}