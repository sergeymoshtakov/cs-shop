using System;
using System.Collections.Generic;
using deviceNamespace;

namespace shopNamespace
{
  public class Shop
  {
    private List<Device> devices = new List<Device>();
    public Shop(List<Device> devices)
    {
      Devices = devices;
    }
    public List<Device> Devices
    {
      set
      {
        try
        {
          if(value != null)
          {
            this.devices = value;
          }
          else
          {
            throw new Exception("Wrong value for devices");
          }
        }
        catch(Exception e)
        {
          Console.WriteLine("{0} must be not null", e.Message);
        }
      }
      get
      {
        return devices;
      }
    }
    public void add(Device a)
    {
      devices.Add(a);
    }
    public void printAll()
    {
      foreach(var device in devices)
        {
          device.printInfo();
        }
    }
    public void search()
    {
      Console.WriteLine("Which criterium would you like to find: \n1 - producer\n2 - model\n3 - quantity\n4 - price\n5 - color");
      int answ = Convert.ToInt32(Console.ReadLine());
      switch(answ)
      {
        case 1:
          Console.WriteLine("Enter name: ");
          string name = Console.ReadLine();
          if(devices.Exists(d => d.NameOfDeveloper == name))
          {
            devices.Find(d => d.NameOfDeveloper == name).printInfo();
          }
          else
          {
            Console.WriteLine("Sorry, there is no such element");
          }
          break;
      case 2:
        Console.WriteLine("Enter model: ");
        string model = Console.ReadLine();
        if(devices.Exists(d => d.Model == model))
          {
            devices.Find(d => d.Model == model).printInfo();
          }
          else
          {
            Console.WriteLine("Sorry, there is no such element");
          }
        break;
      case 3:
        Console.WriteLine("Enter quantity: ");
        int q = Convert.ToInt32(Console.ReadLine());
        if(devices.Exists(d => d.Quantity == q))
          {
            devices.Find(d => d.Quantity == q).printInfo();
          }
          else
          {
            Console.WriteLine("Sorry, there is no such element");
          }
        break;
      case 4:
        Console.WriteLine("Enter price: ");
        double p = Convert.ToDouble(Console.ReadLine());
        if(devices.Exists(d => d.Price == p))
          {
            devices.Find(d => d.Price == p).printInfo();
          }
          else
          {
            Console.WriteLine("Sorry, there is no such element");
          }
        break;
      case 5:
        Console.WriteLine("Enter color: ");
        string color = Console.ReadLine();
        if(devices.Exists(d => d.Color == color))
          {
            devices.Find(d => d.Color == color).printInfo();
          }
          else
          {
            Console.WriteLine("Sorry, there is no such element");
          }
        break;
      default:
        Console.WriteLine("Wrong input");
        break;
      }
    }
    public void delete()
    {
      Console.WriteLine("Which criterium would you like to delete: \n1 - producer\n2 - model\n3 - quantity\n4 - price\n5 - color");
      int answ = Convert.ToInt32(Console.ReadLine());
      switch(answ)
      {
        case 1:
          Console.WriteLine("Enter name: ");
          string name = Console.ReadLine();
          if(devices.Exists(d => d.NameOfDeveloper == name))
          {
            devices.RemoveAll(d => d.NameOfDeveloper == name);
          }
          else
          {
            Console.WriteLine("Sorry, there is no such element");
          }
          break;
      case 2:
        Console.WriteLine("Enter model: ");
        string model = Console.ReadLine();
        if(devices.Exists(d => d.Model == model))
          {
            devices.RemoveAll(d => d.Model == model);
          }
          else
          {
            Console.WriteLine("Sorry, there is no such element");
          }
        break;
      case 3:
        Console.WriteLine("Enter quantity: ");
        int q = Convert.ToInt32(Console.ReadLine());
        if(devices.Exists(d => d.Quantity == q))
          {
            devices.RemoveAll(d => d.Quantity == q);
          }
          else
          {
            Console.WriteLine("Sorry, there is no such element");
          }
        break;
      case 4:
        Console.WriteLine("Enter price: ");
        double p = Convert.ToDouble(Console.ReadLine());
        if(devices.Exists(d => d.Price == p))
          {
            devices.RemoveAll(d => d.Price == p);
          }
          else
          {
            Console.WriteLine("Sorry, there is no such element");
          }
        break;
      case 5:
        Console.WriteLine("Enter color: ");
        string color = Console.ReadLine();
        if(devices.Exists(d => d.Color == color))
          {
            devices.RemoveAll(d => d.Color == color);
          }
          else
          {
            Console.WriteLine("Sorry, there is no such element");
          }
        break;
      default:
        Console.WriteLine("Wrong input");
        break;
      }
    }
  }
}