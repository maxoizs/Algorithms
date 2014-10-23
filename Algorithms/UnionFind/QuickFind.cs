namespace Algorithms.UnionFind {
  public class QuickFind : DumpMe {
    public QuickFind( int capacity ) {
      for ( var x = 0; x < capacity; x++ ) {
        this.Route.Add( x );
      }
    }

    public void Union( int p, int q ) {
      if ( Connected( p, q ) ) {
        return;
      }

      var oldLink = this.Route[p];
      this.Route[p] = this.Route[q];

      for ( var l = 0; l < this.Route.Count; l++ ) {
        if ( this.Route[l] == oldLink ) {
          this.Route[l] = this.Route[q];
        }

      }

    }

    public bool Connected( int x, int y ) {
      return this.Route[x] == this.Route[y];
    }
  }
}
