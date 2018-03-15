using System;
using System.Text.RegularExpressions;

namespace XMLFileParser
{
  class FileParser
  {
    public void ParseContains(string containsOfFile)
    {
      string openTagPattern = @"(<.[^(/><.)]+>)";
      while (Regex.IsMatch(containsOfFile, openTagPattern));
      {
        string foundTag = Regex.Match(containsOfFile, openTagPattern).ToString();
        string tagName = GetTagName(foundTag);
        string clozedTagName= GetTagName(tagName);
        int startOfBody = containsOfFile.IndexOf(foundTag) + foundTag.Length;
        int endOfBody= containsOfFile.IndexOf(clozedTagName) + clozedTagName.Length;
        string body = containsOfFile.Substring(startOfBody, endOfBody);

        XMLContains contains = new XMLContains(tagName);
        AddAttrIntoElement(foundElement, newXmlElement);
        if (Regex.IsMatch(foundTagBody, openTagPattern))
        {
          DepthXMLParse(newXmlElement, foundTagBody);
          xmlString = RemoveParsedBody(bodyStartPoint, bodyEndPoint, foundElement, tagName, xmlString);
        }
        else
        {
          newXmlElement.SetBody(foundTagBody);
          xmlString = RemoveParsedBody(bodyStartPoint, bodyEndPoint, foundElement, tagName, xmlString);
        }
        headElement.AddNested(newXmlElement);
        /*if(Regex.IsMatch(body, openTagPattern))
        {
          ParseContains(body);
          
        }
        else
        {

        }*/
      }
    }
   
    private string GetTagName(string foundTag)
    {
      if(foundTag.IndexOf(" ") < 0)
      {
        int endOfSubstring = (foundTag.IndexOf("<"));
        return (foundTag.Substring(1, endOfSubstring - 1));
      }
      else
      {
        int endOfSubstring = (foundTag.IndexOf(" "));
        return (foundTag.Substring(1, endOfSubstring - 1));
      }
    }

    private string GetCloseTag(string tagName)
    {
      return ("</" + tagName + ">");
    }
  }
}