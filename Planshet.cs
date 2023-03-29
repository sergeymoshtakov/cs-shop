using System;
using deviceNamespace;

namespace planshetNamespace
{
  public class Planshet : Device
  {
    private string camera;
    private double diametr;

    public Planshet(string nameOfDeveloper, string model, int quantity, double price, string color, string camera, double diametr) : base(nameOfDeveloper, model, quantity, price, color)
    {
      Camera = camera;
      Diametr = diametr;
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
      Console.WriteLine("Name of developer - {0}\nModel - {1}\nQuantity - {2}\nPrice - {3}\nColor - {4}\nCamera - {5}\nDiametr - {6}\nAll price - {7}", NameOfDeveloper, Model, Quantity, Price, Color, Camera, Diametr, calculatePrice());
    }
    public override double calculatePrice()
    {
      if(Quantity > 3)
      {
        return Price * Quantity * 0.9;
      }
      else if(Quantity > 5)
      {
        return Price * Quantity * 0.6;
      }
      else
      {
        return Price * Quantity;
      }
    }
  }
}