using Algorithms.UnionFind;
using NUnit.Framework;

namespace AlgorithmsTest {

  [TestFixture]
  public class QuickFindTest {
    private QuickFind _quickFind;

    [TestFixtureSetUp]
    public void Setup() {
      _quickFind = new QuickFind( 10 );
    }

    [Test]
    public void Test_Exam() {
      //3-6 3-1 4-9 7-8 3-0 8-3 
      _quickFind.Union( 3, 6 );
      _quickFind.Union( 3, 1 );
      _quickFind.Union( 4, 9 );
      _quickFind.Union( 7, 8 );
      _quickFind.Union( 3, 0 );
      _quickFind.Union( 8, 3 );
      _quickFind.Dump();
      Assert.That( _quickFind.Connected( 3, 6 ), Is.True );
    }

    [Test]
    public void Test_ShouldConnectPoints() {
      _quickFind.Union( 3, 4 );
      _quickFind.Union( 3, 8 );
      _quickFind.Union( 5, 6 );
      _quickFind.Union( 9, 4 );
      _quickFind.Union( 1, 2 );
      Assert.That( _quickFind.Connected( 8, 9 ), Is.True );
      Assert.That( _quickFind.Connected( 0, 5 ), Is.False );

      _quickFind.Union( 0, 5 );
      Assert.That( _quickFind.Connected( 0, 5 ), Is.True );

      _quickFind.Union( 7, 2 );
      _quickFind.Union( 6, 1 );
      Assert.That( _quickFind.Connected( 6, 2 ), Is.True );
      Assert.That( _quickFind.Connected( 6, 7 ), Is.True );
    }
  }
}