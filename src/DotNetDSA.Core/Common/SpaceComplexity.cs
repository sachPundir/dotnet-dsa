
namespace DotNetDSA.Core.Common
{
  /// <summary>
  /// Represents the worst-case space complexity (Big-O notation)
  /// of an algorithm.
  ///
  /// This enum is used strictly for documentation and learning
  /// purposes and does not participate in runtime logic.
  /// </summary>
  public enum SpaceComplexity
  {
    /// <summary>
    /// O(1) — Constant space.
    ///
    /// The algorithm uses a fixed amount of extra memory
    /// regardless of the input size.
    /// </summary>
    O1,

    /// <summary>
    /// O(log n) — Logarithmic space.
    ///
    /// The algorithm uses additional memory proportional
    /// to the logarithm of the input size.
    /// Common in recursive algorithms with balanced calls.
    /// </summary>
    OLogN,

    /// <summary>
    /// O(n) — Linear space.
    ///
    /// The algorithm uses extra memory proportional
    /// to the input size.
    /// </summary>
    ON
  }
}
