using System;

namespace deviceNamespace
{
  public abstract class Device
  {
    private string nameOfDeveloper;
    private string model;
    private int quantity;
    private double price;
    private string color;

    public Device(string nameOfDeveloper, string model, int quantity, double price, string color)
    {
      NameOfDeveloper = nameOfDeveloper;
      Model = model;
      Quantity = quantity;
      Price = price;
      Color = color;
    }
    
    public string NameOfDeveloper
    {
      set
      {
        try
        {
          if(value.Length != 0)
          {
            this.nameOfDeveloper = value;
          }
          else
          {
            this.nameOfDeveloper = " ";
            throw new Exception("Wrong input for name of developer");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0} it must be not empty", e.Message);
        }
      }
      get
      {
        return nameOfDeveloper;
      }
    }
    public string Model
    {
      set
      {
        try
        {
          if(value.Length != 0)
          {
            this.model = value;
          }
          else
          {
            this.model = " ";
            throw new Exception("Wrong input for model");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0} it must be not empty", e.Message);
        }
      }
      get
      {
        return model;
      }
    }
    public int Quantity
    {
      set
      {
        try
        {
          if(value < 0)
          {
            this.quantity = 1;
            throw new Exception("Wrong input for quantity");
          }
          else
          {
            this.quantity = value;
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0} it must be higher than 0", e.Message);
        }
      }
      get
      {
        return quantity;
      }
    }
    public double Price
    {
      set
      {
        try
        {
          if(value < 0)
          {
            this.price = 1;
            throw new Exception("Wrong input for price");
          }
          else
          {
            this.price = value;
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0} it must be higher than 0", e.Message);
        }
      }
      get
      {
        return price;
      }
    }
    public string Color
    {
      set
      {
        try
        {
          if(value.Length != 0)
          {
            this.color = value;
          }
          else
          {
            this.color = " ";
            throw new Exception("Wrong input for color");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0} it must be not empty", e.Message);
        }
      }
      get
      {
        return color;
      }
    }
    public string getNameOfDeveloper()
    {
      return nameOfDeveloper;
    }
    public string getModel()
    {
      return model;
    }
    public int getQuantity()
    {
      return quantity;
    }
    public double getPrice()
    {
      return price;
    }
    public string getColor()
    {
      return color;
    }
    public void setNameOfDeveloper(string nameOfDeveloper)
    {
      try
      {
        if(nameOfDeveloper.Length != 0)
        {
          this.nameOfDeveloper = nameOfDeveloper;
        }
        else
        {
          this.nameOfDeveloper = " ";
          throw new Exception("Wrong input for name of developer");
        }
      }
      catch(Exception e)
      {
        Console.WriteLine("{0} it must be not empty", e.Message);
      }
    }
    public void setModel(string model)
    {
      try
      {
        if(model.Length != 0)
        {
          this.model = model;
        }
        else
        {
          this.model = " ";
          throw new Exception("Wrong input for model");
        }
      }
      catch(Exception e)
      {
        Console.WriteLine("{0} it must be not empty", e.Message);
      }
    }
    public void setQuantity(int quantity)
    {
      try
      {
        if(quantity < 0)
        {
          this.quantity = 1;
          throw new Exception("Wrong input for quantity");
        }
        else
        {
          this.quantity = quantity;
        }
      }
      catch(Exception e)
      {
        Console.WriteLine("{0} it must be higher than 0", e.Message);
      }
    }
    public void setPrice(double price)
    {
      try
      {
        if(price < 0)
        {
          this.price = 1;
          throw new Exception("Wrong input for price");
        }
        else
        {
          this.price = price;
        }
      }
      catch(Exception e)
      {
        Console.WriteLine("{0} it must be higher than 0", e.Message);
      }
    }
    public void setColor(string color)
    {
      try
      {
        if(color.Length != 0)
        {
          this.color = color;
        }
        else
        {
          this.color = " ";
          throw new Exception("Wrong input for color");
        }
      }
      catch(Exception e)
      {
        Console.WriteLine("{0} it must be not empty", e.Message);
      }
    }
    public abstract void printInfo();
    public abstract double calculatePrice();
  }
}