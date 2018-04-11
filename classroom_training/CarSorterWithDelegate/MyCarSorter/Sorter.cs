namespace MyCarSorter
{
  class Sorter
  {
    public int CompareByBrand(Car firstCar, Car secondCar)
    {
      if (firstCar.Brand == null)
      {
        if (secondCar.Brand == null)
        {
          return 0;
        }
        else
        {
          return -1;
        }
      }
      else
      {
        if (secondCar.Brand == null)
        {
          return 1;
        }
        else
        {
          return firstCar.Brand.CompareTo(secondCar.Brand);
        }
      }
    }

    public int CompareByModel(Car firstCar, Car secondCar)
    {
      if (firstCar.Model == null)
      {
        if (secondCar.Model == null)
        {
          return 0;
        }
        else
        {
          return -1;
        }
      }
      else
      {
        if (secondCar.Model == null)
        {
          return 1;
        }
        else
        {
          return firstCar.Model.CompareTo(secondCar.Model);
        }
      }
    }
  }
}