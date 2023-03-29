using System;
using deviceNamespace;

namespace laptopNamespace
{
  public class Laptop : Device
  {
    private double memory;
    private double diametr;

    public Laptop(string nameOfDeveloper, string model, int quantity, double price, string color, double memory, double diametr) : base(nameOfDeveloper, model, quantity, price, color)
    {
      Memory = memory;
      Diametr = diametr;
    }

    public double Memory
    {
      set
      {
        try
        {
          if(value < 0)
          {
            this.memory = 1;
            throw new Exception("Wrong input for memory");
          }
          else
          {
            this.memory = value;
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0} it must be higher than 0", e.Message);
        }
      }
      get
      {
        return memory;
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
            throw new Exception("Wrong input for deametr");
          }
          else
          {
            this.diametr = value;
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0} it must be higher than 0", e.Message);
        }
      }
      get
      {
        return diametr;
      }
    }
    public override void printInfo()
    {
      Console.WriteLine("Name of developer - {0}\nModel - {1}\nQuantity - {2}\nPrice - {3}\nColor - {4}\nMemory - {5}\nDiametr - {6}\nAll price - {7}", NameOfDeveloper, Model, Quantity, Price, Color, Memory, Diametr, calculatePrice());
    }
    public override double calculatePrice()
    {
      return Quantity * Price;
    }
  }
}