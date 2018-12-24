using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_SRV
{

    //  public class PlaneComparer : IComparer
    //  {
    //      // Call CaseInsensitiveComparer.Compare with the parameters reversed.
    //      int IComparer.Compare(Object x, Object y)
    //      {
    //          int t = ((Plane)y).FuelResidual - ((Plane)x).FuelResidual;
    //          return  t == 0? 1 : t;
    //      }
    //  }

    public class DuplicateKeyComparer<TKey>
            :
         IComparer<TKey> where TKey : IComparable
    {
        #region IComparer<TKey> Members

        public int Compare(TKey x, TKey y)
        {
            int result = x.CompareTo(y);

            if (result == 0)
                return 1;   // Handle equality as beeing greater
            else
                return result;
        }

        #endregion
    }



    public class PlaneQueue
    {
        SortedList<Int32, Plane> _PlaneList = new SortedList<Int32, Plane>(new DuplicateKeyComparer<int>());

        public SortedList<Int32, Plane> PlaneList
        {
            get { return _PlaneList; }
            set { _PlaneList = PlaneList; }
        }
        public void AddPlane(Plane plane)
        {
          
            _PlaneList.Add(plane.FuelResidual, plane);
        }

        public Plane PopPlane()
        {
            Plane temp = _PlaneList.First().Value;
            _PlaneList.RemoveAt(0);
            return temp;
        }
        public bool IsEmpty()
        {
            return _PlaneList.Count == 0;
        }
        public void RemovePlane(Int32 Number)
        {
            for (int t = 0; t < _PlaneList.Count; t++)
            {
                if (_PlaneList.ElementAt(t).Value.Number == Number)
                {
                    _PlaneList.RemoveAt(t);
                }
            }
        }
        public Boolean ContainsPlane(int Number)
        {
            return _PlaneList.Values.Where(t => t.Number == Number).Count() != 0;
        }
        public Int32 Count()
        {
            return _PlaneList.Count;
        }
    }
}
