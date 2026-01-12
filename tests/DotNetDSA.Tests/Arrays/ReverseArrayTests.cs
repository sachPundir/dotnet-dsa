using DotNetDSA.Core.Arrays;

namespace DotNetDSA.Tests.Arrays
{
  public class ReverseArrayTests
  {
    public static IEnumerable<object[]> ReverseMethods =>
      new List<object[]>
      {
        new object[] { new Func<int[], int[]>(ReverseArray.ReverseInPlace) },
        new object[] { new Func<int[], int[]>(ReverseArray.ReverseWithExtraSpace) }
      };

    [Theory]
    [MemberData(nameof(ReverseMethods))]
    public void Reverse_NormalArray_ReturnsReversed(Func<int[], int[]> reverseMethod)
    {
      int[] input = { 1, 2, 3, 4 };

      var result = reverseMethod(input);

      Assert.Equal(new[] { 4, 3, 2, 1 }, result);
    }

    [Theory]
    [MemberData(nameof(ReverseMethods))]
    public void Reverse_EmptyArray_ReturnsEmpty(Func<int[], int[]> reverseMethod)
    {
      var result = reverseMethod(Array.Empty<int>());

      Assert.Empty(result);
    }

    [Theory]
    [MemberData(nameof(ReverseMethods))]
    public void Reverse_Null_ReturnsNull(Func<int[], int[]> reverseMethod)
    {
      int[] input = null;

      var result = reverseMethod(input);

      Assert.Null(result);
    }
  }
}
