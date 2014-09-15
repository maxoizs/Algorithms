using Algorithms;
using NUnit.Framework;

namespace AlgorithmsTest {

  [TestFixture]
  public class SearchListTest {
    private readonly int[] _list = new[] { 1, 3, 4, 6, 8, 9, 11, 14, 16, 17, 23, 27, 32, 39, 40, 45, 51, 57, 69 ,70 };

    [Test]
    public void Test_IfNumber_NotExists_Exist() {
      var number = SearchList.Search( _list, 5 );
      Assert.That( number, Is.EqualTo( -1 ) );
    }

    [Test]
    [TestCase( 1 )]
    [TestCase( 3 )]
    [TestCase( 8 )]
    [TestCase( 69 )]
    [TestCase( 70 )]
    public void Test_IfNumber_Exists_ReturnIt( int value ) {
      var number = SearchList.Search( _list, value );
      Assert.That( number, Is.EqualTo( value ) );
    }
  }
}