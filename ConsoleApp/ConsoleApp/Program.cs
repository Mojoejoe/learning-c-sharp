using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp {
  class Program {
    static void Main(string[] args) {

      //GetUserData(); 
      //ExerciseOne();
      ExerciseTwo();
    }


    //Napisati program koji pronalazi sumu brojeva koje korisnik unosi preko konzole.
    //Korisnik, na poèetku, zadaje koliko brojeva želi da sabira.
    public static void ExerciseOne() {
    Console.WriteLine("Koliko brojeva zelite da saberete?");
      int sumNumber = Convert.ToInt16(Console.ReadLine());         
      int sum = 0;
      for (int i = 0; i < sumNumber; i++) {
        string s = Console.ReadLine();
        sum += Convert.ToInt16(s);
      }
      Console.WriteLine("Suma je {0}", sum);
      Console.ReadLine();
    }

    //Napisati program koji pronalazi najveæi broj meðu pozitivnim brojevima koje
    //korisnik unosi preko konzole. Za kraj unosa se koristi 0.
    public static void ExerciseTwo() {
      Console.WriteLine("Unesite niz brojeva iz kojih zelite da se nadje maksimum");
      int unos=1;
      int max = 0;
      while (unos != 0) {
        string s = Console.ReadLine();
        unos = Convert.ToInt32(s);
        if (unos > max) {
          max = unos;
        }        
      }
      Console.WriteLine("Najveci broj u nizu je {0}", max);
      Console.ReadLine();
    }

    private static void GetUserData() {

      Console.WriteLine("Write your name");
      string name = Console.ReadLine();
      Console.WriteLine("Write your age");
      string age = Console.ReadLine();

      Console.WriteLine("Hello {0} you are {1} years old!", name, age);
      Console.ReadLine();
    }
  }
}
