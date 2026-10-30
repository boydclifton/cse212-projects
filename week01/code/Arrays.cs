public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    /// 
    /// 
    /// 
    public static double[] MultiplesOf(double number, int length)

    // TODO Problem 1 Start
    // Remember: Using comments in your program, write down your process for solving this problem
    // step by step before you write the code. The plan should be clear enough that it could
    // be implemented by another person.

    // Step 1: Initialize an empty container. Create a new array of 'doubles' sized 
    // exactly to the 'length' variable that was fed in.
    //
    // Step 2: Build a standard 'for' loop to act as our iteration engine. Initialize 
    // a time-keeping variable 'i' at 0, and set it to terminate when 'i' is no longer 
    // less than the 'length' of the array.
    //
    // Step 3: Inside the loop, calculate the multiple. Multiply the original 'number' 
    // by (i + 1). We add the +1 because the index starts at 0, and we want to multiply 
    // by sequential positive numbers starting at 1.
    //
    // Step 4: Assign that calculated multiple into the 'result' array at slot [i]. 
    // After the loop finishes, return the final array.

    {
        var result = new double[length];
        for (var i = 0; i < length; i++)
        {
            result[i] = number * (i + 1);
        }
        return result;
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

        /// 1. To build this method's body, we need to first figure out where to splice in the 'data' list. To do this,
        /// we initialize our first variable 'cutPoint' to evaluate to the length of the list subtracted by the amount
        /// of numbers we are rotating. 
        /// 
        /// 2. Next, we initialize the next variable 'backHalf' to evaluate to the list of integers that preceded the 
        /// cut point. We can do this with the GetRange() method, using 'cutPoint' as our 
        /// beginning index in the range and 'amount' as the number of items to be included. 
        /// 
        /// 3. Next, we initialize our 
        /// frontHalf variable to evaluate to the list of integers that follow the cut point. We use the GetRange() method 
        /// with '0' being our beginning index and 'cutPoint' being the number of integers to include. 
        /// 
        /// 4. We need to  clear the 'data' list because this is a 'void' function and we still want to rebuild a new list
        /// using the 'data' list that was passed in as a parameter.
        ///                             
        /// 
        /// 5. We use the AddRange() method to build our new list. Add the 'backHalf' list and then the 'frontHalf' list 
        /// so that the final list order is correct.
        /// 



        var cutPoint = data.Count - amount;
        var backHalf = data.GetRange(cutPoint, amount);
        var frontHalf = data.GetRange(0, cutPoint);
        data.Clear();
        data.AddRange(backHalf);
        data.AddRange(frontHalf);










    }
}
