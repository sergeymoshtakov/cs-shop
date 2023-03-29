using System;
using deviceNamespace;

namespace mobilePhoneNamespace
{
  public class MobilePhone : Device
  {
    private string camera;
    private double diametr;
    private string aperator;

    public MobilePhone(string nameOfDeveloper, string model, int quantity, double price, string color, string camera, double diametr, string aperator) : base(nameOfDeveloper, model, quantity, price, color)
    {
      Camera = camera;
      Diametr = diametr;
      Aperator = aperator;
    }
    public string Camera
    {
      set
      {
        try
        {
          if(value.Length != 0)
          {
            this.camera = value;
          }
          else
          {
            this.camera = " ";
            throw new Exception("Wrong input for camera");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0} it must be not empty", e.Message);
        }
      }
      get
      {
        return camera;
      }
    }
    public string Aperator
    {
      set
      {
        try
        {
          if(value.Length != 0)
          {
            this.aperator = value;
          }
          else
          {
            this.aperator = " ";
            throw new Exception("Wrong input for aperator");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0} it must be not empty", e.Message);
        }
      }
      get
      {
        return aperator;
      }
    }
    public double Diametr
    {
      set
      {
        try
        {
          if(value < 0)
          {
            this.diametr = 1;
            throw new Exception("Wrong value for diametr");
          }
          else
          {
            this.diametr = value;
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0} must be higher than 0", e.Message);
        }
      }
      get
      {
        return diametr;
      }
    }
    public override void printInfo()
    {
      Console.WriteLine("Name of developer - {0}\nModel - {1}\nQuantity - {2}\nPrice - {3}\nColor - {4}\nCamera - {5}\nDiametr - {6}\nOperator - {7}\nAll price - {8}", NameOfDeveloper, Model, Quantity, Price, Color, Camera, Diametr, Aperator, calculatePrice());
    }
    public override double calculatePrice()
    {
      if(Quantity > 3)
      {
        return Price * Quantity * 0.8;
      }
      else
      {
        return Price * Quantity;
      }
    }
  }
}