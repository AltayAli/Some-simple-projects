using System;

public class MyLibrary
{
    public int[,] myArray;
    public int[,] GetElementsFromArray()
    {
        return myArray;
    }

    public bool isLocatedIn(int[,] newArray)
    {
        bool isHere = false;

        if (isEqual(myArray, newArray))
        {
            isHere = true;
        }

        return isHere;
    }
    public bool isEqual(int[,] firstArray, int[,] SecondArray)
    {
        bool isEqualArrays = false;
       
        for (int i = 0; i <= firstArray.GetLength(0) - SecondArray.GetLength(0); i++)
        {
            for (int j = 0; j <= firstArray.GetLength(1) - SecondArray.GetLength(1); j++)
            {
                int[,] array = Contain(firstArray, i, j, SecondArray.GetLength(0), SecondArray.GetLength(1));
                int count = 0;
                for (int h = 0; h < array.GetLength(0); h++)
                {
                    for (int f = 0; f < array.GetLength(1); f++)
                    {
                        
                        if (array[h, f] == SecondArray[h, f])
                        {
                            count++;
                        }
                    }
                }
                if (count == SecondArray.Length)
                {
                    isEqualArrays = true;
                }
            }
        }

        return isEqualArrays;
    }
    public int[,] Contain(int[,] array, int rowIndex, int colIndex, int rowLength, int colLength)
    {
        int[,] resultArray = new int[rowLength, colLength];

        int RowCount = 0;
        for (int i = rowIndex; i < rowIndex + rowLength; i++)
        {
            int colCount = 0;
            for (int j = colIndex; j < colIndex + colLength; j++)
            {
                resultArray[RowCount, colCount] = array[i, j];
                colCount++;
            }
            RowCount++;
        }
        return resultArray;
    }
}
