using DotNetDSA.Core.Common;

namespace DotNetDSA.Core.Arrays
{
  /// <summary>
  /// PROBLEM STATEMENT:
  ///
  /// Given an integer array, determine the maximum element present in the array.
  ///
  /// The algorithm must scan the array efficiently and return the largest value.
  /// If the array is null or empty, the algorithm should return null.
  ///
  /// Requirements:
  /// - The algorithm must handle null and empty arrays safely.
  /// - No built-in aggregation utilities (e.g., LINQ Max) should be used.
  /// - The solution should traverse the array only once.
  ///
  /// Examples:
  /// Input:  [3, 1, 7, 2]
  /// Output: 7
  ///
  /// Input:  [5]
  /// Output: 5
  ///
  /// Input:  []
  /// Output: null
  ///
  /// Input:  null
  /// Output: null
  ///
  /// This problem is commonly used in interviews to evaluate:
  /// - Understanding of array traversal
  /// - Initialization strategies
  /// - Edge-case handling (null / empty input)
  /// - Time and space complexity reasoning
  /// </summary>
  public static class FindMaximum
  {
    /// <summary>
    /// Finds the maximum value in the given integer array.
    /// </summary>
    /// <param name="input">
    /// The input array. Can be null or empty.
    /// </param>
    /// <returns>
    /// The maximum value if present; otherwise, null.
    /// </returns>
    /// <remarks>
    /// Time Complexity: O(n) — each element is visited once.
    /// Space Complexity: O(1) — no additional memory used.
    /// </remarks>
    public static int? Find(int[]? input)
    {
      // Guard clause:
      // If the array is null or empty, no maximum value exists.
      if (input == null || input.Length == 0)
      {
        return null;
      }

      // Initialize the maximum with the first element.
      // This avoids using sentinel values like int.MinValue.
      var max = input[0];

      // Start from index 1 since index 0 is already considered.
      for (var i = 1; i < input.Length; i++)
      {
        // Update max whenever a larger element is found.
        if (input[i] > max)
        {
          max = input[i];
        }
      }

      return max;
    }

    // Declared explicitly for learning and documentation purposes.
    public static readonly TimeComplexity Time = TimeComplexity.ON;
    public static readonly SpaceComplexity Space = SpaceComplexity.O1;
  }
}
