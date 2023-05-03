using System;
using System.Collections;
using System.Collections.Generic;

namespace PrimeSifting.Models
{
  public class PrimeSifter
  {
  //get; set; constructor:
    public int Number { get; set; }
    public List<int> PrimeList { get; set;}
    public List<int> RemoveNonPrimes(int number)
    {
      Number = number;  //5
      List<int> inputList = new List<int> {};
      List<int> nonPrimeList = new List<int> {};
      for (int n = 2; n <= Number; n++)
      {
        inputList.Add(n);   //[2,3,4,5]
      }
      foreach (int element in inputList)
      {
        for (int n = 2; n <= Number; n++)
        {
          if (element % n == 0 && element > n)
          {
            nonPrimeList.Add(element); //[4]
          } 
        }
      }
      foreach (int nonPrime in nonPrimeList)
      {
        inputList.Remove(nonPrime); //[2,3,5]
      }
      return inputList;
    }
  }
}