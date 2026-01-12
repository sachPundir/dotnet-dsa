using DotNetDSA.Core.Common;

namespace DotNetDSA.Core.Arrays
{
  /// <summary>
  /// PROBLEM STATEMENT:
  ///
  /// Given an integer array, reverse the elements of the array.
  ///
  /// The reversal can be performed using different approaches,
  /// each demonstrating different space–time trade-offs.
  ///
  /// Requirements:
  /// - The algorithm must handle null and empty arrays safely.
  /// - The order of elements must be completely reversed.
  /// - No built-in reversal utilities (e.g., LINQ or Array.Reverse) should be used.
  ///
  /// Examples:
  /// Input:  [1, 2, 3, 4]
  /// Output: [4, 3, 2, 1]
  ///
  /// Input:  []
  /// Output: []
  ///
  /// Input:  null
  /// Output: null
  ///
  /// Approaches demonstrated in this class:
  /// 1. In-place reversal using the two-pointer technique (O(1) extra space).
  /// 2. Reversal using an auxiliary array (O(n) extra space).
  ///
  /// This problem is commonly used in interviews to evaluate:
  /// - Understanding of array indexing
  /// - Pointer manipulation
  /// - Space vs time trade-offs
  /// - Defensive coding practices
  /// </summary>
  public static class ReverseArray
  {
    /// <summary>
    /// Reverses the given array in-place using the two-pointer technique.
    /// </summary>
    /// <param name="input">
    /// The input array to reverse.
    /// This parameter may be null or contain zero or one element.
    /// </param>
    /// <returns>
    /// The same array instance reversed in-place,
    /// or null if the input array is null.
    /// </returns>
    /// <remarks>
    /// Time Complexity: O(n)
    ///
    /// Space Complexity: O(1)
    ///
    /// This approach modifies the original array and does not
    /// allocate any additional memory.
    /// </remarks>
    public static int[]? ReverseInPlace(int[]? input)
    {
      // Guard clause:
      // If the array is null or contains fewer than two elements,
      // no reversal is required.
      if (input == null || input.Length <= 1)
      {
        return input;
      }

      // Initialize two pointers at the beginning and end of the array.
      var left = 0;
      var right = input.Length - 1;

      // Swap elements while moving the pointers inward.
      while (left < right)
      {
        (input[left], input[right]) = (input[right], input[left]);
        left++;
        right--;
      }

      return input;
    }



    /// <summary>
    /// Reverses the given array by creating a new array.
    /// </summary>
    /// <param name="input">
    /// The input array to reverse.
    /// This parameter may be null.
    /// </param>
    /// <returns>
    /// A new array containing the elements of the input array
    /// in reversed order, or null if the input array is null.
    /// </returns>
    /// <remarks>
    /// Time Complexity: O(n)
    ///
    /// Space Complexity: O(n)
    ///
    /// This approach preserves the original array but requires
    /// additional memory proportional to the input size.
    /// </remarks>
    public static int[]? ReverseWithExtraSpace(int[]? input)
    {
      // Guard clause:
      // If the array is null, no reversal can be performed.
      if (input == null)
      {
        return null;
      }

      // Allocate a new array to hold the reversed elements.
      var result = new int[input.Length];

      // Copy elements from the input array to the result
      // in reverse order.
      for (var i = 0; i < input.Length; i++)
      {
        result[i] = input[input.Length - 1 - i];
      }

      return result;
    }



    /// <summary>
    /// Declares the worst-case time complexity shared
    /// by the reversal algorithms in this class.
    /// </summary>
    public static readonly TimeComplexity Time = TimeComplexity.ON;



    /// <summary>
    /// Declares the worst-case space complexity of the
    /// in-place reversal approach.
    /// </summary>
    public static readonly SpaceComplexity SpaceInPlace = SpaceComplexity.O1;



    /// <summary>
    /// Declares the worst-case space complexity of the
    /// extra-space reversal approach.
    /// </summary>
    public static readonly SpaceComplexity SpaceExtra = SpaceComplexity.ON;
  }
}
