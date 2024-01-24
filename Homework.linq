<Query Kind="Program" />

using System;
using System.Linq;
using System.Collections;
using System.Globalization;


namespace Homework
{
  class Program
  {
    static void Main(string[] args)
    {
          List<int> numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		  Console.WriteLine(FindMiddleElement(numbers));
		  Console.WriteLine(LargestNumber(numbers));
		  
    }
	public static List<int> FindMiddleElement(List<int> list)
	{
		int listLength = list.Count;
		int middleIndex = listLength/2;
		
		if(listLength % 2 == 0)
		{
			return new List<int> {list[middleIndex - 1], list[middleIndex]};
		}
		else 
		{
			return new List<int> {list[middleIndex]};
		}
	}
	
	public static int LargestNumber(List<int> list)
	{
		int largest = int.MinValue;
		foreach(int num in list){
			largest = Math.Max(num, largest);
		} 
		return largest;
	}
  }
}