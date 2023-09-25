namespace inheritance;

// in this case, interface will do the job
// interface Animal
// {
//   void animalSound();
//   void Sleep();
// }

public abstract class Animal
{
  public virtual void animalSound()
  {
    Console.WriteLine("The animal make a sound");
  }

  // or you can use abstract method
  public abstract void Sleep();
}


// inheritance dir から Animalクラスの継承
class Pig : Animal
{
  public override void animalSound()
  {
    Console.WriteLine("The pig: what?");
  }

  public override void Sleep()
  {
    Console.WriteLine("Piggy Sleeping...");
  }
}

// Derived class (child)
class Dog : Animal
{
  public override void animalSound()
  {
    Console.WriteLine("The dog says: bow wow");
  }

  public override void Sleep()
  {
    Console.WriteLine("Doggy Sleeping...");
  }
}