using Algorithms.UnionFind;

using NUnit.Framework;

namespace AlgorithmsTest {
  [TestFixture]
  public class QuickUnionWithWeightingTest {
    private QuickUnionWithWeighting _quickFind;

    [TestFixtureSetUp]
    public void Setup() {
      _quickFind = new QuickUnionWithWeighting( 10 );
    }

    [Test]
    public void Test_ShouldConnectPoints() {
      _quickFind.Union( 4, 3 );
      _quickFind.Union( 3, 8 );
      _quickFind.Union( 6, 5 );
      _quickFind.Union( 9, 4 );
      _quickFind.Union( 2, 1 );
      Assert.That( _quickFind.Connected( 8, 9 ), Is.True );
      Assert.That( _quickFind.Connected( 5, 4 ), Is.False );

      _quickFind.Union( 5, 0 );
      _quickFind.Union( 7, 2 );
      _quickFind.Union( 6, 1 );
      _quickFind.Union( 7, 3 );
      Assert.That( _quickFind.Connected( 4, 3 ), Is.True );
      Assert.That( _quickFind.Connected( 4, 8 ), Is.True );
      Assert.That( _quickFind.Connected( 1, 3 ), Is.True );
    }
  }
}