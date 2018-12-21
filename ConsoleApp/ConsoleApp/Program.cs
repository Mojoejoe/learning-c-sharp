using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp {
  class Program {
    static void Main(string[] args) {

      GetUserData();
      Console.ReadLine();     
      
    }

    private static void GetUserData() {

      Console.WriteLine("Write your name");
      string name = Console.ReadLine();
      Console.WriteLine("Write your age");
      string age = Console.ReadLine();

      Console.WriteLine("Hello {0} you are {1} years old!",name,age);
    }
  }
}
