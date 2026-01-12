

namespace DotNetDSA.Core.Common
{
  /// <summary>
  /// Represents the worst-case time complexity (Big-O notation)
  /// of an algorithm.
  ///
  /// This enum is used strictly for documentation and learning
  /// purposes and does not participate in runtime logic.
  /// </summary>
  public enum TimeComplexity
  {
    /// <summary>
    /// O(1) — Constant time.
    ///
    /// The execution time does not change with input size.
    /// Example: accessing an array element by index.
    /// </summary>
    O1,



    /// <summary>
    /// O(log n) — Logarithmic time.
    ///
    /// The execution time grows logarithmically as the input size increases.
    /// Common in divide-and-conquer algorithms such as binary search.
    /// </summary>
    OLogN,



    /// <summary>
    /// O(n) — Linear time.
    ///
    /// The execution time grows proportionally with the input size.
    /// Example: iterating through an array once.
    /// </summary>
    ON,



    /// <summary>
    /// O(n log n) — Linearithmic time.
    ///
    /// Common in efficient sorting algorithms such as merge sort
    /// and quicksort (average case).
    /// </summary>
    ONLogN,



    /// <summary>
    /// O(n²) — Quadratic time.
    ///
    /// Typically occurs in algorithms with nested loops
    /// iterating over the same data set.
    /// </summary>
    ON2,



    /// <summary>
    /// O(n³) — Cubic time.
    ///
    /// Often found in algorithms with three nested loops,
    /// such as certain dynamic programming or matrix operations.
    /// </summary>
    ON3
  }

}
