using System.Collections.Generic;

namespace Algorithms {
  public class Car {
    public string Name { get; set; }
  }

  public class Vehicle {
    public string Name {
      get { return Current != null ? Current.Name : string.Empty; }
    }

    public Car Current { get; set; }
    public Vehicle Next { get; set; }
  }

  public class VehicleList {
    public Vehicle Head { get; set; }

    public void Reverse() {
      ReverseMe( Head, Head.Next );
    }

    private void ReverseMe( Vehicle current, Vehicle next ) {

      if ( next.Next == null ) {
        Head.Next = null;
        Head = next;
      } else if ( next.Next != null && next.Next != current ) {
        ReverseMe( next, next.Next );
      }

      next.Next = current;
    }


    public ICollection<string> Print() {
      var veh = Head;
      var names = new List<string>();
      while ( veh != null ) {
        names.Add( veh.Current.Name );
        veh = veh.Next;
      }
      return names;
    }
  }
}