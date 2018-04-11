namespace MyCarSorter
{
  /// <summary>
  /// This class represents the essence of the car and describes its essence
  /// </summary>
  class Car
  {
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Volume { get; set; }

    public Car(string brand, string model, int volume)
    {
      Brand = brand;
      Model = model;
      Volume = volume;
    }
  }
}