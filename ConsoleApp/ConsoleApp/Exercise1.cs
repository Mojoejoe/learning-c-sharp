using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Napisati program koji pronalazi sumu brojeva koje korisnik unosi preko konzole.
//Korisnik, na početku, zadaje koliko brojeva želi da sabira.

public class Exercise1
{
  void Main(string[] args) {
    Console.WriteLine("Koliko brojeva zelite da saberete?");
    int sumNumber = Convert.ToInt16(Console.ReadLine());  //ne znam koliko je ovo pametno :D
    int sum = 0;
    for (int i = 0; i < sumNumber; i++) {
      string s = Console.ReadLine();
      sum += Convert.ToInt16(s);
    }
    Console.WriteLine("Suma je {0}", sum);
    Console.ReadLine();
  }  
}
