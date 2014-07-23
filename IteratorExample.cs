using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProject
{
  public class IteratorExample
  {
    public void TestIterators()
    {
      List<int> myList = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
      HashSet<int> mySet = new HashSet<int> { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
      for (int i = 0; i < myList.Count; i++)
        Console.Write("{0} ", myList[i]);
      Console.WriteLine();

      IEnumerator<int> pi = mySet.GetEnumerator();
      while (pi.MoveNext())
      {
        int x = pi.Current;
        Console.Write("{0} ", x);
      }
      Console.WriteLine();

      foreach (int x in myList)
        Console.Write("{0} ", x);
      Console.WriteLine();


      MyIntList myIntList = new MyIntList { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
      IEnumerator<int> px = myIntList.GetEnumerator(x => 0 == x % 3);
      while ( px.MoveNext())
        Console.Write("{0} ", px.Current);
      Console.WriteLine();
      // displays 3 9 6 3

      foreach(int x in myIntList)
        Console.Write("{0} ", x);
      Console.WriteLine();
      // displays 3 1 4 1 5 9 2 6 5 3 5

      Console.ReadKey();
    }
  }
}
