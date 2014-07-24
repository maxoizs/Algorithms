using System.Collections.Generic;

namespace Algorithms.UnionFind {
  public class QuickFind {

    private readonly List<int> _route = new List<int>();

    public QuickFind( int capacity ) {
      for ( var x = 0; x < capacity; x++ ) {
        this._route.Add( x );
      }
    }

    public void Union( int x, int y ) {
      if ( this.Connected( x, y ) ) {
        return;
      }

      var oldLink = this._route[y];
      this._route[y] = this._route[x];

      for ( var l = 0; l < this._route.Count; l++ ) {
        if ( this._route[l] == oldLink ) {
          this._route[l] = this._route[x];
        }

      }

    }

    public bool Connected( int x, int y ) {
      return this._route[x] == this._route[y];
    }
  }
}
