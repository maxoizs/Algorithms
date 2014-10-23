using System;
using System.Collections.Generic;

namespace Algorithms {
  using System.Linq;

  public class ArangramWord {

    public static IEnumerable<string> GetArangramWord( string first, string word ) {
      if ( string.IsNullOrEmpty( word ) ) {
        yield return first;
      }

      for ( var x = 0; x < word.Length; x++ ) {
        var newfirst =first+ word[x];
        var newword = word.Remove( x, 1 );
        
        foreach ( var str in GetArangramWord( newfirst, newword ).Distinct() ) {
          Console.WriteLine( str );
          yield return str ;
        }
      }
    }
  }
}
