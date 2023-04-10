
// Reverse String
using CreateCar;
using System;

Ford myCar = new Ford();
myCar.Year = 2007;
myCar.Accelerate();
var myCarAge = myCar.Age(2023);
Console.WriteLine(myCarAge);

var myString = ReverseString("erehwon");
Console.WriteLine(myString);

// Remove Duplicates
var noDups = Removeduplicate("Derriicck");
Console.WriteLine(noDups);

// 2D array to 1D array
int[,] int2DArray = { { 1, 4, 2, 8, 10 }, { 3, 6, 8, 13, 20 } };
var mySingleArray = MultiToSingle(int2DArray);
Console.WriteLine(mySingleArray);

// Convert Number to String
ConvertNumbersToString();


string ReverseString(string str)
{
    char[] charArray = str.ToCharArray();
    Array.Reverse(charArray);
    string reverseString = new string(charArray);
    return reverseString;
}

string Removeduplicate(string str)
{
    string result = null;
    string strName = str;
    string resultName = string.Empty;
    var unique = new HashSet<char>(strName);
    foreach (char c in unique)
    {
        result += c;
    }
    return result;
}

int[] MultiToSingle(int[,] array)
{

    int idx = 0;
    
    //Getting the no of rows of 2d array 
    int NoOfRows = array.GetLength(0);

    //Getting the no of columns of the 2d array
    int NoOfColumns = array.GetLength(1);

    //Creating 1d Array by multiplying NoOfRows and NoOfColumns
    int[] single = new int[NoOfRows * NoOfColumns];

    //Assigning the elements to 1d Array from 2d array
    try
    {

        for (int y = 0; y < NoOfColumns; y++)
        {
            for (int x = 0; x < NoOfRows; x++)
            {
                single[idx] = array[x, y];
                idx++;
            }
        }

        //Display singleArray elements
        Console.WriteLine("Single Array Elements : ");
        foreach (int item in single)
        {
            Console.Write(item + " ");
        }

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }

    return single;
}
void ConvertNumbersToString()
{
    Console.WriteLine("Please Enter a Number from 1 to 6");
    int aNumber = int.Parse(Console.ReadLine());

    switch (aNumber)
    {
        case 1:
            Console.WriteLine("Your Number is: One");
            break;
        case 2:
            Console.WriteLine("Your Number is: Two");
            break;
        case 3:
            Console.WriteLine("Your Number is: Three");
            break;
        case 4:
            Console.WriteLine("Your Number is: Four");
            break;
        case 5:
            Console.WriteLine("Your Number is: Five");
            break;
        case 6:
            Console.WriteLine("Your Number is: Six");
            break;
        default:
            Console.WriteLine("You Did Not Enter a Number between 1 and 6");
            break;
    }

}

