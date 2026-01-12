using DotNetDSA.Core.Arrays;

namespace DotNetDSA.Tests.Arrays
{
  public class ReverseArrayTests
  {
    [Fact]
    public void Execute_NormalArray_ReturnsReversed()
    {
      int[] input = { 1, 2, 3, 4 };

      var result = ReverseArray.Execute(input);

      Assert.Equal(new[] { 4, 3, 2, 1 }, result);
    }

    [Fact]
    public void Execute_EmptyArray_ReturnsEmpty()
    {
      var result = ReverseArray.Execute(Array.Empty<int>());

      Assert.Empty(result);
    }

    [Fact]
    public void Execute_Null_ReturnsNull()
    {
      int[] input = null;

      var result = ReverseArray.Execute(input);

      Assert.Null(result);
    }
  }
}
