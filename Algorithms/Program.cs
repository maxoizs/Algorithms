using System;

namespace Algorithms {
  using System.Linq;

  public class Program {
    static void Main( string[] args ) {
      ArangramWord.GetArangramWord( string.Empty, "ABCD" ).ToList();
      Console.ReadKey();
    }
  }
}