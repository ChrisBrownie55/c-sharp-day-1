using System;
using day_1.Models;

namespace helloworld {
  class Program {

    static void Beeper() => Console.Beep(300, 200);
    static void Main(string[] args) {
      Console.Clear();
      Beeper();
      Console.WriteLine("Hello, what is your name?");
      string name = Console.ReadLine();

      if (name != null && name.ToLower() == "admin") {
        Console.WriteLine("You are now authorized to launch nukes.");
      } else {
        Console.WriteLine($"Welcome to the lab {name}.");
      }

      Console.WriteLine("How old are you?");

      int age;
      if (!Int32.TryParse(Console.ReadLine(), out age)) {
        Console.WriteLine($"That's not an age, {name}.");
        Console.WriteLine("Goodbye.");
        return;
      }
      User user = new User(name, age);

      Console.WriteLine($"Cool, that means you'll be working with the other {user.Age} year olds, {user.Name}.");
    }
  }
}
