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

        // PLAN:
        // 1. Create a new array of doubles with size 'length'
        // 2. Loop through the array from index 0 to length-1
        // 3. For each index i, calculate the multiple: number * (i + 1)
        // 4. Store each calculated multiple in the array at index i
        // 5. Return the completed array

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

        // PLAN:
        // To rotate a list right means taking elements from the end and moving them to the beginning.
        //
        // Strategy using list slicing:
        // 1. Calculate the split point: where to split the list
        //      Split point = data.Count - amount
        //      Elements from split point to end will move to the beginning
        //      Elements from beginning to split point will move to the end
        //
        // 2. Extract the elements that move to front
        //      This is from index (data.Count - amount) to the end
        //      Use GetRange(data.Count - amount, amount)
        //
        // 3. Extract the elements that move to back
        //      This is from index 0 to (data.Count - amount)
        //      Use GetRange(0, data.Count - amount)
        //
        // 4. Clear the original list
        //
        // 5. Add the right part first (they go to the beginning)
        //
        // 6. Add the left part second (they go to the end)
        //
        int splitPoint = data.Count - amount;

        // Extract the parts that need to be rearranged
        List<int> rightPart = data.GetRange(splitPoint, amount);
        List<int> leftPart = data.GetRange(0, splitPoint);

        // Clear the original list and rebuild it in the rotated order
        data.Clear();
        data.AddRange(rightPart);
        data.AddRange(leftPart);
    }
}
