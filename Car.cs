using ConsoleApp;
namespace ConsoleApp{
abstract class Car 
{
  public abstract String carmodel();
  public abstract String carHorsepower();
  public abstract String carPrice();
  public abstract String carFuelConsumption();
  
}

class Ford : Car
{
  public override String carmodel()
  {
       return "Ford F-150";
  }
  public override String carHorsepower()
  {
       return "400";
  }
  public override String carPrice()
  {
       return "2.7 Million birr";
  }
  public override String carFuelConsumption()
  {
       return "Gasoline";
  }
  private string mileage = "18 KM/Litre"; // encapsulation
  public string Mileage                   // property to access the hidden
  {
      get{return mileage;}
  }
}

class Tesla : Car
{
  public override String carmodel()
  {
       return "Tesla model X";
  }
  public override String carHorsepower()
  {
       return "670";
  }
  public override String carPrice()
  {
       return "6 Million birr";
  }
  public override String carFuelConsumption()
  {
       return "Electric";
  }
  private string mileage = "300KM"; // encapsulation
  public string Mileage                   // property to access the hidden
  {
      get{return mileage;}
  }
}
class Toyota : Car
{
  public override String carmodel()
  {
       return "Toyota Land Cruiser";
  }
  public override String carHorsepower()
  {
       return "381";
  }
  public override String carPrice()
  {
       return "6 Million birr";
  }
  public override String carFuelConsumption()
  {
       return "Gasoline";
  }
  private string mileage = "13 KM/Litre"; // encapsulation
  public string Mileage                   // property to access the hidden
  {
      get{return mileage;}
  }
}
}

