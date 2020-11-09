using System;

//The program will calculate how many numbers of 1,2,3 or more digits are entered by the user until the user types "end"

class digits
{
 static void Main()
 {	
    int oneDigit = 0, twoDigits = 0, threeDigits = 0, moreThreeDigits = 0;
    Console.Write("Insert a number: ");
    string endWord = Console.ReadLine();
    while(endWord!="end")
    {
        int inputNumber = Convert.ToInt32(endWord);
        if(inputNumber != 0)
        {

        if(inputNumber/10 == 0)
            oneDigit ++;  
            else 
                if (inputNumber/100 == 0)
                    twoDigits ++;  
                    else
                        if (inputNumber/1000 == 0)
                            threeDigits ++;  
                            else
                                moreThreeDigits++;  
        }
      endWord = Console.ReadLine();
    }

Console.WriteLine("one: {0} two: {1} three: {2} more: {3}", oneDigit, twoDigits, threeDigits, moreThreeDigits); 

 }
}

