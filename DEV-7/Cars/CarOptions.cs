using System;

namespace Cars
{
  public class CarOptions
  {
    public string Brand { get; set; }
    public string Model { get; set; }
    public string CarcaseType { get; set; }
    public string TransmissionType { get; set; }
    public string EngineType { get; set; }
    public string EngineSize { get; set; }
    public string EnginePower { get; set; }
    public string ClimateControle { get; set; }
    public string CabinType { get; set; }

    public void GetOptionsToConsole()
    {
      Console.WriteLine(Brand + " - "
         + Model + " - "
         + CarcaseType + " - "
         + TransmissionType + " - "
         + EngineType + " - "
         + EngineSize + " - "
         + EnginePower + " - "
         + ClimateControle + " - "
         + CabinType);
    }
  }
}