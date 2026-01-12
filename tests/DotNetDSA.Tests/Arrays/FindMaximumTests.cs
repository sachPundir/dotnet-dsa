using DotNetDSA.Core.Arrays;

namespace DotNetDSA.Tests.Arrays;

/// <summary>
/// Unit tests for the <see cref="FindMaximum"/> class.
/// These tests validate correct behavior for normal inputs
/// as well as edge and boundary conditions.
/// </summary>
public class FindMaximumTests
{
  /// <summary>
  /// Verifies that the maximum value is correctly identified
  /// when the input array contains multiple elements.
  /// </summary>
  [Fact]
  public void Find_NormalArray_ReturnsMax()
  {
    // Arrange:
    // A typical array with multiple values.
    var input = new[] { 3, 1, 7, 2 };

    // Act:
    var result = FindMaximum.Find(input);

    // Assert:
    Assert.Equal(7, result);
  }



  /// <summary>
  /// Verifies that the single element is returned as the maximum
  /// when the array contains exactly one value.
  /// </summary>
  [Fact]
  public void Find_SingleElement_ReturnsThatElement()
  {
    // Arrange:
    // An array containing only one element.
    var input = new[] { 5 };

    // Act:
    var result = FindMaximum.Find(input);

    // Assert:
    Assert.Equal(5, result);
  }



  /// <summary>
  /// Verifies that a null result is returned when the input
  /// array is empty, since no maximum value exists.
  /// </summary>
  [Fact]
  public void Find_EmptyArray_ReturnsNull()
  {
    // Arrange:
    // An empty array has no maximum value.
    var input = Array.Empty<int>();

    // Act:
    var result = FindMaximum.Find(input);

    // Assert:
    Assert.Null(result);
  }



  /// <summary>
  /// Verifies that a null result is returned when the input
  /// array itself is null.
  /// </summary>
  [Fact]
  public void Find_Null_ReturnsNull()
  {
    // Arrange:
    // A null array should be handled safely without exceptions.
    int[]? input = null;

    // Act:
    var result = FindMaximum.Find(input);

    // Assert:
    Assert.Null(result);
  }
}
