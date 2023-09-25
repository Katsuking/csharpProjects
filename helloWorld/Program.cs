using System;
using inheritance;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello world");

      // inheritance
      Pig myPiggiy = new Pig();
      Dog myDoggy = new Dog();
      myPiggiy.animalSound();
      myPiggiy.Sleep();
      myDoggy.animalSound();
    }

  }

}