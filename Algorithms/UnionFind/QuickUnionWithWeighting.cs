using System.Collections.Generic;

namespace Algorithms.UnionFind {

  public class QuickUnionWithWeighting {
    public readonly List<int> TreeList = new List<int>();
    private readonly List<int> _weight = new List<int>();

    public QuickUnionWithWeighting( int capacity ) {
      for ( var x = 0; x < capacity; x++ ) {
        TreeList.Add( x );
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
        TreeList[rootX] = TreeList[rootY];
        _weight[rootY] += 1;

      } else {
        TreeList[rootY] = TreeList[rootX];
        _weight[rootX] += 1;
      }
    }

    public bool Connected( int x, int y ) {
      return GetRoot( x ) == GetRoot( y );
    }

    private int GetRoot( int y ) {
      while ( TreeList[y] != y ) {
        TreeList[y] = TreeList[TreeList[TreeList[y]]];
        y = TreeList[y];
      }
      return y;
    }
  }
}