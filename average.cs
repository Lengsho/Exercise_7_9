using System;

//The program will caulculates the average of a set of marks, until the user types "end"
public class Average{
	public static void Main(){
		double number1=0, number2, number3=0, average;
		string endWord;
		Console.Write("Insert a mark: ");
		endWord=Console.ReadLine();	 
		while(endWord!="end")
		{ 
			number2=Convert.ToDouble(s);
			number3++;  
			number1+=number2;  
			Console.Write("Insert a mark: ");
			endWord=Console.ReadLine();
		}
		if(number3!=0)
		{
			average=number1/number3;  
			Console.WriteLine("The average is {0}.",average);
		}
	}
}
