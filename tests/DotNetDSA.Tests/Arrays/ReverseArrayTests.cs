using DotNetDSA.Core.Arrays;

namespace DotNetDSA.Tests.Arrays
{
  /// <summary>
  /// Unit tests for the <see cref="ReverseArray"/> class.
  ///
  /// These tests validate that different reversal implementations
  /// behave consistently for normal, edge, and boundary cases.
  /// </summary>
  public class ReverseArrayTests
  {
    /// <summary>
    /// Provides all array reversal implementations to be tested.
    ///
    /// Each method must conform to the same behavioral contract:
    /// - Return the reversed array for valid input
    /// - Return an empty array for empty input
    /// - Return null for null input
    /// </summary>
    public static IEnumerable<object[]> ReverseMethods =>
        new List<object[]>
        {
                new object[] { new Func<int[]?, int[]?>(ReverseArray.ReverseInPlace) },
                new object[] { new Func<int[]?, int[]?>(ReverseArray.ReverseWithExtraSpace) }
        };



    /// <summary>
    /// Verifies that a normal array is reversed correctly
    /// regardless of the underlying implementation.
    /// </summary>
    /// <param name="reverseMethod">
    /// The reversal implementation under test.
    /// </param>
    [Theory]
    [MemberData(nameof(ReverseMethods))]
    public void Reverse_NormalArray_ReturnsReversed(Func<int[]?, int[]?> reverseMethod)
    {
      // Arrange:
      // A typical array with multiple elements.
      var input = new[] { 1, 2, 3, 4 };

      // Act:
      var result = reverseMethod(input);

      // Assert:
      Assert.Equal(new[] { 4, 3, 2, 1 }, result);
    }



    /// <summary>
    /// Verifies that an empty array remains empty
    /// after applying the reversal operation.
    /// </summary>
    /// <param name="reverseMethod">
    /// The reversal implementation under test.
    /// </param>
    [Theory]
    [MemberData(nameof(ReverseMethods))]
    public void Reverse_EmptyArray_ReturnsEmpty(Func<int[]?, int[]?> reverseMethod)
    {
      // Arrange:
      // An empty array contains no elements to reverse.
      var input = Array.Empty<int>();

      // Act:
      var result = reverseMethod(input);

      // Assert:
      Assert.Empty(result);
    }



    /// <summary>
    /// Verifies that a null input array is handled safely
    /// and results in a null output.
    /// </summary>
    /// <param name="reverseMethod">
    /// The reversal implementation under test.
    /// </param>
    [Theory]
    [MemberData(nameof(ReverseMethods))]
    public void Reverse_Null_ReturnsNull(Func<int[]?, int[]?> reverseMethod)
    {
      // Arrange:
      // A null array should not cause an exception.
      int[]? input = null;

      // Act:
      var result = reverseMethod(input);

      // Assert:
      Assert.Null(result);
    }
  }
}
