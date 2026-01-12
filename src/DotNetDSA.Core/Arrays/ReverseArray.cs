using DotNetDSA.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetDSA.Core.Arrays
{
  public static class ReverseArray
  {
    /// <summary>
    /// Reverses the given array in-place.
    /// </summary>
    /// <remarks>
    /// Time Complexity: O(n)
    /// Space Complexity: O(1)
    /// </remarks>
    public static int[] Execute(int[] input)
    {
      if (input == null
          || input.Length <= 1)
      {
        return input;
      }

      var left = 0;
      var right = input.Length - 1;

      while (left < right)
      {
        (input[left], input[right]) = (input[right], input[left]);
        left++;
        right--;
      }

      return input;
    }

    public static readonly TimeComplexity Time = TimeComplexity.ON;
    public static readonly SpaceComplexity Space = SpaceComplexity.O1;
  }
}
