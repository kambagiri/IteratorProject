using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProject
{
  public class MyIntList : IList<int>
  {
    public List<int> MyList = new List<int>();
    public MyIntList() {  }
    
    public void Add(int item) { MyList.Add(item); }

    public IEnumerator<int> GetEnumerator()
    {
        return new Enumerator1(MyList);
       
       /* var NewList = new MyList().GetEnumerator();   // tried to implement in new way, couldn't succeed. So, used your iterator help 
        while(NewList.MoveNext())
        {
            Console.WriteLine(NewList.GetEnumerator());
        }*/
    }

    public IEnumerator<int> GetEnumerator(Func<int, bool> filter)
    {
        /*var NewList = new MyList().Where(filter).GetEnumerator();   // tried to implement in new way, couldn't succeed. So, used your iterator help 
         while(NewList.MoveNext())
        {
            Console.WriteLine(NewList.GetEnumerator());
        */
        return new Enumerator1(filter, MyList);
    }

    #region iList methods not implemented
    public int IndexOf(int item)
    {
      throw new NotImplementedException();
    }

    public void Insert(int index, int item)
    {
      throw new NotImplementedException();
    }

    public void RemoveAt(int index)
    {
      throw new NotImplementedException();
    }

    public int this[int index]
    {
      get
      {
        throw new NotImplementedException();
      }
      set
      {
        throw new NotImplementedException();
      }
    }

    public void Clear()
    {
      throw new NotImplementedException();
    }

    public bool Contains(int item)
    {
      throw new NotImplementedException();
    }

    public void CopyTo(int[] array, int arrayIndex)
    {
      throw new NotImplementedException();
    }

    public int Count
    {
      get { throw new NotImplementedException(); }
    }

    public bool IsReadOnly
    {
      get { throw new NotImplementedException(); }
    }

    public bool Remove(int item)
    {
      throw new NotImplementedException();
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }
    #endregion
  }
}
