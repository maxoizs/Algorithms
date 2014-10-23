using Algorithms;
using NUnit.Framework;

namespace AlgorithmsTest {
  [TestFixture]
  public class ReverseListTest {
    private readonly int[] _list = new[] { 1, 3, 4, 6, 8, 9, 11, 14, 16, 17, 23, 27, 32, 39, 40, 45, 51, 57, 69, 70 };

    [Test]
    public void Test_ReverseList() {
      var bm = new Vehicle { Current = new Car { Name = "BMW" } };
      var vol = new Vehicle { Current = new Car { Name = "Volvo" } };
      var fiat = new Vehicle { Current = new Car { Name = "Fiat" } };
      var seat = new Vehicle { Current = new Car { Name = "Seat" } };
      var mercedes = new Vehicle { Current = new Car { Name = "Mercedes" } };
      var ford = new Vehicle { Current = new Car { Name = "Ford" } };
      bm.Next = vol;
      vol.Next = fiat;
      fiat.Next = seat;
      seat.Next = mercedes;
      mercedes.Next = ford;

      var list = new VehicleList { Head = bm };
      list.Reverse();
      Assert.That( list.Head.Name, Is.EqualTo( ford.Name ) );
      Assert.That( list.Head.Next.Name, Is.EqualTo( mercedes.Name ) );
      Assert.That( list.Head.Next.Next.Name, Is.EqualTo( seat.Name ) );
      Assert.That( list.Head.Next.Next.Next.Name, Is.EqualTo( fiat.Name ) );
      Assert.That( list.Head.Next.Next.Next.Next.Name, Is.EqualTo( vol.Name ) );
      Assert.That( list.Head.Next.Next.Next.Next.Next.Name, Is.EqualTo( bm.Name ) );
      Assert.That( list.Head.Next.Next.Next.Next.Next.Next, Is.Null );
    }
  }
}