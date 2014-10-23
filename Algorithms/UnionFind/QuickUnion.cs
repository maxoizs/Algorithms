namespace Algorithms.UnionFind {
  public class QuickUnion:DumpMe {

    public QuickUnion( int capacity ) {
      for ( var x = 0; x < capacity; x++ ) {
        Route.Add( x );
      }
    }

    public void Union( int x, int y ) {
      if ( Connected( x, y ) ) {
        return;
      }

      Route[GetRoot( y )] = Route[GetRoot( x )];
    }

    public bool Connected( int x, int y ) {
      return GetRoot( x ) == GetRoot( y );
    }

    private int GetRoot( int y ) {
      while ( Route[y] != y ) {
        y = Route[y];
      }
      return y;
    }
  }
}