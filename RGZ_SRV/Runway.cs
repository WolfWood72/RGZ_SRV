using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_SRV
{
    public class Runway
    {
        public enum RunwayStatusCode { Free, Busy, Wait };

        static Int32 Counter = 0;
        public Int32 Number;
        public Int32 LengthRunway { get; set; }
        public Plane CurrentPlane { get; set; }
        public RunwayStatusCode Status { get; set; }
        public Int32 WaitTime { get; set; }
        public Runway(Int32 LengthRunway )
        {
            Number = Counter++;
            this.LengthRunway = LengthRunway;
        }


        public void TakeInPlane(Plane plane)
        {
            this.CurrentPlane = plane;
            this.Status = RunwayStatusCode.Busy;
            this.WaitTime = TimeCounter.Time + (plane.Status == Plane.PlaneStatusCode.InQueueLanding ? plane.TimeLanding : plane.TimeTakeoff);
            this.CurrentPlane.Status = Plane.GetNextStatus(this.CurrentPlane.Status);
        }

        public Plane TakeOffPlane()
        {
            this.CurrentPlane.Status = Plane.GetNextStatus(this.CurrentPlane.Status);
            Plane temp_plane = this.CurrentPlane;
            this.CurrentPlane = null;
            if (Airport.MinIntervalBetweenLanding == 0)
            {
                this.Status = RunwayStatusCode.Free;
            }
            else
            {
                this.Status = RunwayStatusCode.Wait;
                this.WaitTime = TimeCounter.Time + Airport.MinIntervalBetweenLanding;
            }
            return temp_plane;
        }
        public void MakeFree()
        {
            this.Status = RunwayStatusCode.Free;

        }

        public RunwayStatusCode GetNextStatus(RunwayStatusCode CurrStatus)
        {
            RunwayStatusCode NextStatus;
            switch (CurrStatus)
            {
                case RunwayStatusCode.Free:
                    NextStatus = RunwayStatusCode.Busy;
                    break;
                case RunwayStatusCode.Busy:
                    NextStatus = RunwayStatusCode.Wait;
                    break;
                case RunwayStatusCode.Wait:
                    NextStatus = RunwayStatusCode.Free;
                    break;
                default:
                    NextStatus = CurrStatus;
                    break;

            }

            return NextStatus;
        }
        public RunwayStatusCode GetNextStatus()
        {
    
            return GetNextStatus(this.Status);
        }
    }
}
