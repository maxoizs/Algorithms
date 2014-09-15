using System.Collections.Generic;

namespace Algorithms.UnionFind {

  public class QuickUnion {
    public readonly List<int> TreeList = new List<int>();

    public QuickUnion( int capacity ) {
      for ( var x = 0; x < capacity; x++ ) {
        TreeList.Add( x );
      }
    }

    public void Union( int x, int y ) {
      if ( Connected( x, y ) ) {
        return;
      }

      TreeList[GetRoot( y )] = TreeList[GetRoot( x )];
    }

    public bool Connected( int x, int y ) {
      return GetRoot( x ) == GetRoot( y );
    }

    private int GetRoot( int y ) {
      while ( TreeList[y] != y ) {
        y = TreeList[y];
      }
      return y;
    }
  }
}