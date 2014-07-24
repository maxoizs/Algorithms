using System.Collections.Generic;

namespace Algorithms.UnionFind {

  public class QuickUnion {
    private readonly List<int> _route = new List<int>();

    public QuickUnion( int capacity ) {
      for ( var x = 0; x < capacity; x++ ) {
        _route.Add( x );
      }
    }

    public void Union( int x, int y ) {
      if ( Connected( x, y ) ) {
        return;
      }

      _route[GetRoot( x )] = _route[GetRoot( y )];
    }

    public bool Connected( int x, int y ) {
      return GetRoot( x ) == GetRoot( y );
    }

    private int GetRoot( int y ) {
      while ( _route[y] != y ) {
        y = _route[y];
      }
      return y;
    }
  }
}