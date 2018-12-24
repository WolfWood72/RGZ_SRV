using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RGZ_SRV
{
    public class Airport
    {
        public Int32 MaxQueryForSizeLanding { get; set; }
        public Int32 MaxQuerySizeToTakeOff { get; set; }
        public static Int32 MinIntervalBetweenLanding { get; set; }
        List<Plane> _EndStatusPlane = new List<Plane>();
        public List<Plane> EndStatusPlane
        {
            get
            {
                return _EndStatusPlane;
            }
            set
            {
                _EndStatusPlane = value;
            }
        }
        List<Runway> _RunwayList = new List<Runway>();
        public List<Runway> RunwayList
        {
            get
            {
                return _RunwayList;
            }
            set
            {
                _RunwayList = value;
            }
        }

        PlaneQueue _TakeOffQueue = new PlaneQueue();

        public PlaneQueue TakeOffQueue
        {
            get { return _TakeOffQueue; }
            set { _TakeOffQueue = value; }
        }

        PlaneQueue _LandingQueue = new PlaneQueue();
        public PlaneQueue LandingQueue
        {
            get
            {
                return _LandingQueue;
            }
            set
            {
                _LandingQueue = value;
            }
        }




        public void AddRunway(Runway runway)
        {
            _RunwayList.Add(runway);
        }

        public void RemoveRunway(int index)
        {
            foreach (Runway r in _RunwayList)
            {
                if (r.Number == index)
                {
                    _RunwayList.Remove(r);
                    break;
                }
            }
            //RunwayList.RemoveAt(index);
        }
        public void AddToTakeOffQueue(Plane plane)
        {
            foreach (var runway in _RunwayList)
            {
                if (runway.LengthRunway >= plane.LengthTakeOff)
                {
                    _TakeOffQueue.AddPlane(plane);
                    break;
                }
            }

        }
        public void RemoveFromTakeOff(Int32 Number)
        {
            _TakeOffQueue.RemovePlane(Number);
        }

        public void AddToLandingQueue(Plane plane)
        {
            foreach (var runway in _RunwayList)
            {
                if (runway.LengthRunway >= plane.LengthTakeOff)
                {
                    _LandingQueue.AddPlane(plane);
                    break;
                }
            }

        }
        public void RemoveFromLandingQueue(Int32 Number)
        {

            _LandingQueue.RemovePlane(Number);
        }
        public void RemovePlane(Int32 Number)
        {
            if (_TakeOffQueue.ContainsPlane(Number))// Удалить из очереди на взлет
                _TakeOffQueue.RemovePlane(Number);
            else if (_LandingQueue.ContainsPlane(Number))// Удалить из очереди на посадку
                _LandingQueue.RemovePlane(Number);
            else
            {
                //Удалить из ВПП
                var selected = _RunwayList.Where(t => t.CurrentPlane != null).Where(t => t.CurrentPlane.Number == Number);
                foreach (var VPP in selected)
                {
                    VPP.CurrentPlane = null;
                }

            }

        }
        public Runway GetRunway(Int32 number)
        {
            try
            {
                return this._RunwayList[number];
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public Boolean HaveFreeRunways()
        {
            return _RunwayList.Where(t => t.Status == Runway.RunwayStatusCode.Free).Count() != 0;
        }
        public Boolean HavePlanesInQueues()
        {
            return _TakeOffQueue.Count() + _LandingQueue.Count() != 0;
        }

        public void DistributePlanesOnRunways()
        {
            while (this.HaveFreeRunways() && this.HavePlanesInQueues())
            {
                Plane plane;
                if (_LandingQueue.Count() != 0) // Сперва распределяем самолеты ожидающие посадки
                    plane = _LandingQueue.PopPlane();
                else if (_TakeOffQueue.Count() != 0) // Затем самолеты ожидающие взлета
                    plane = _TakeOffQueue.PopPlane();
                else // Если очереди пусты, то ничего не делаем
                    break;

                foreach (var runway in _RunwayList)
                {
                    if (runway.Status == Runway.RunwayStatusCode.Free)
                    {
                        runway.TakeInPlane(plane);
                        break;
                    }
                }

            }
        }
        public Int32 GetMaxLengthOfRunway()
        {
            return _RunwayList.Count == 0 ? 0 : _RunwayList.Max(t => t.LengthRunway);
        }

        public void UpdateStatus()
        {
            foreach (var runway in _RunwayList)
            {
                if (runway.WaitTime == TimeCounter.Time)
                {
                    Runway.RunwayStatusCode CurStatus = runway.Status;
                    if (CurStatus == Runway.RunwayStatusCode.Busy)
                    {
                        Plane plane = runway.TakeOffPlane();
                        _EndStatusPlane.Add(plane);
                    }
                    else if (CurStatus == Runway.RunwayStatusCode.Wait)
                        runway.MakeFree();


                }
            }
        }
        public void ResetAirport()
        {
            TimeCounter.Time = 0;
            foreach(var runway in _RunwayList)
            {
                runway.Status = Runway.RunwayStatusCode.Free;
                runway.WaitTime = 0;
                runway.CurrentPlane = null;
            }

        }

    }
}
