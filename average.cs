using System;

//The program will caulculate how many numbers of 1,2,3 or more digits are entered by the user since the user type "end"

public class Average{
	public static void Main(){
		double oneDigit=0, twoDigits, threeDigits=0, moreThreeDigits;
		string endWord;
		Console.Write("Insert a mark: ");
		endWord=Console.ReadLine();
		while(endWord!="end")
		{ 
			twoDigits=Convert.ToDouble(endWord);
			threeDigits++;  
			oneDigit+=twoDigits;  
			Console.Write("Insert a mark: ");
			endWord=Console.ReadLine();
		}
		if(threeDigits!=0)
		{
			moreThreeDigits=oneDigit/twoDigits;  
		Console.WriteLine("The average is {0}.",moreThreeDigits);
		}
	}
}
