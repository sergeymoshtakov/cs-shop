using System;
using System.Collections.Generic;
using deviceNamespace;
using laptopNamespace;
using shopNamespace;
using planshetNamespace;

class Program {
  public static void Main (string[] args) {
    List<Device> devices = new List<Device>();
    Laptop l = new Laptop("Samsung", "XD", 4, 22412.11, "black", 12322, 123);
    Shop s = new Shop(devices);
    s.add(l);
    s.printAll();
    s.search();
    Planshet p = new Planshet("Mitsubishu", "dsg", 5, 26782.11, "red", "XD", 427.5);
    s.add(p);
    s.delete();
    s.printAll();
  }
}