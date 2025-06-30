public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Will create an array of doubles with the size of 'length'.
        // Using a for loop to iterate from 0 to length - 1
        // In each iteration,  will multiply 'number' with the current index + 1 and assign it to the current index of the array 
        // Lastly will return the array

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Will create a new list to hold the rotated values.
        // Calculate the effective rotation amount by taking the modulus of the amount with the count of the list.
        // Use a for loop to iterate through the original list, starting from the end and moving
        // backwards to the beginning, placing each element in the new list at the correct index.

        int count = data.Count;
        List<int> rotatedData = new List<int>(new int[count]);
        for (int i = 0; i < count; i++)
        {
            int newIndex = (i + amount) % count; 
            rotatedData[newIndex] = data[i]; 
        }
        data.Clear(); 
        data.AddRange(rotatedData);
    }
}
