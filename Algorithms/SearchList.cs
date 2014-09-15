using System.Collections.Generic;

namespace Algorithms {
  public class SearchList {
    public static int Search( IReadOnlyList<int> list, int number ) {
      var low = 0;
      var high = list.Count - 1;
      var mid = high / 2;
      while ( low < high && number != list[mid] ) {
        mid = ( high + low ) / 2;
        if ( number > list[mid] ) {
          low = mid + 1;
        } 
        else {
          high = mid - 1;
        }
      }

      if ( number == list[low] ) {
        return list[low];
      }
      if ( number == list[high] ) {
        return list[high];
      }

      return number == list[mid] ? list[mid] : -1;
    }
  }
}
