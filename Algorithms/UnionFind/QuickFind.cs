using System.Collections.Generic;

namespace Algorithms.UnionFind {
  public class QuickFind {

    private readonly List<int> _route = new List<int>();

    public QuickFind( int capacity ) {
      for ( var x = 0; x < capacity; x++ ) {
        _route.Add( x );
      }
    }

    public void Union( int x, int y ) {
      if ( Connected( x, y ) ) {
        return;
      }

      var oldLink = _route[y];
      _route[y] = _route[x];

      for ( var l = 0; l < _route.Count; l++ ) {
        if ( _route[l] == oldLink ) {
          _route[l] = _route[x];
        }

      }

    }

    public bool Connected( int x, int y ) {
      return _route[x] == _route[y];
    }
  }
}
