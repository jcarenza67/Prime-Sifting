using System;
using System.Collections;
using System.Collections.Generic;
using PrimeSifting.Models;

namespace PrimeSifting
{
  public class Program
  {
    public static void Main()
    {
      // code goes here
      Console.WriteLine("Enter a number to see a list of primes:");
      int number = int.Parse(Console.ReadLine());
      PrimeSifter newPrimeSifter = new PrimeSifter();
      List<int> primeList = newPrimeSifter.RemoveNonPrimes(number);
      foreach(int element in primeList)
      {
        Console.WriteLine(element);
      }
      
    }
  }
}