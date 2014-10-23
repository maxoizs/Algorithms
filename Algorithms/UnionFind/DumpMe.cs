using System.Collections.Generic;
using System.Diagnostics;

namespace Algorithms.UnionFind {
  public class DumpMe {
    internal readonly List<int> Route = new List<int>();

    public void Dump() {
      Debug.WriteLine( string.Join( ", ", Route ) );
      Debug.Flush();
    }
  }
}