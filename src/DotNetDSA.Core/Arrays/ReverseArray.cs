using DotNetDSA.Core.Common;

namespace DotNetDSA.Core.Arrays
{
  public static class ReverseArray
  {
    /// <summary>
    /// Reverses an array in-place using two pointers.
    /// </summary>
    /// <remarks>
    /// Time Complexity: O(n)
    /// Space Complexity: O(1)
    /// </remarks>
    public static int[] ReverseInPlace(int[] input)
    {
      if (input == null || input.Length <= 1)
        return input;

      int left = 0;
      int right = input.Length - 1;

      while (left < right)
      {
        (input[left], input[right]) = (input[right], input[left]);
        left++;
        right--;
      }

      return input;
    }

    /// <summary>
    /// Reverses an array by creating a new array.
    /// </summary>
    /// <remarks>
    /// Time Complexity: O(n)
    /// Space Complexity: O(n)
    /// </remarks>
    public static int[] ReverseWithExtraSpace(int[] input)
    {
      if (input == null)
        return null;

      var result = new int[input.Length];

      for (int i = 0; i < input.Length; i++)
      {
        result[i] = input[input.Length - 1 - i];
      }

      return result;
    }

    public static readonly TimeComplexity Time = TimeComplexity.ON;
    public static readonly SpaceComplexity SpaceInPlace = SpaceComplexity.O1;
    public static readonly SpaceComplexity SpaceExtra = SpaceComplexity.ON;
  }
}
