using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinderWithSpecifiedExtension
{
  class EntryPoint
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter file path: ");
      string filePath = Console.ReadLine();
      FolderInformationManipulator folderInformationManipulator = new FolderInformationManipulator(filePath);
      List<string> fileList = new List<string>();
      fileList = folderInformationManipulator.GetFilesWithSpecifiedExtension(args[0]);

    }
  }
}
