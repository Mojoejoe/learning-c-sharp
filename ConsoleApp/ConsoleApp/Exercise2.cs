using System;

//Napisati program koji pronalazi najveći broj među pozitivnim brojevima koje
//korisnik unosi preko konzole. Za kraj unosa se koristi 0.

public class Exercise2
{	
  static void Main(string[] args) {
    Console.WriteLine("Unesite niz brojeva iz kojih zelite da se nadje maksimum");
    int unos = 1;
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
}
