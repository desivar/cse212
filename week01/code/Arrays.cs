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
        // Implementation for producing multiples of the given number
        double[] multiples = new double[length];
        for (int i = 0; i < length; i++) {
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
        // Implementation for rotating the list to the right
        int count = data.Count;
        amount = amount % count; // Ensure amount is within the bounds of the list length

        // Use list slicing to get the two parts
        List<int> rotated = new List<int>(count);
        rotated.AddRange(data.GetRange(count - amount, amount)); // Last 'amount' elements
        rotated.AddRange(data.GetRange(0, count - amount)); // First 'count - amount' elements

        // Modify the existing list
        for (int i = 0; i < count; i++) {
            data[i] = rotated[i];
        }
    }
}
