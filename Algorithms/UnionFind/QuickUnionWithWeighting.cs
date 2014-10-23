using System.Collections.Generic;

namespace Algorithms.UnionFind {

  public class QuickUnionWithWeighting: DumpMe {
    private readonly List<int> _weight = new List<int>();

    public QuickUnionWithWeighting( int capacity ) {
      for ( var x = 0; x < capacity; x++ ) {
        this.Route.Add( x );
        _weight.Add( 1 );
      }
    }

    public void Union( int x, int y ) {
      var rootY = GetRoot( y );
      var rootX = GetRoot( x );
      if ( rootX == rootY ) {
        return;
      }

      if ( _weight[rootY] > _weight[rootX] ) {
        this.Route[rootX] = this.Route[rootY];
        _weight[rootY] += 1;

      } else {
        this.Route[rootY] = this.Route[rootX];
        _weight[rootX] += 1;
      }
    }

    public bool Connected( int x, int y ) {
      return GetRoot( x ) == GetRoot( y );
    }

    private int GetRoot( int y ) {
      while ( this.Route[y] != y ) {
        this.Route[y] = this.Route[this.Route[this.Route[y]]];
        y = this.Route[y];
      }
      return y;
    }
  }
}