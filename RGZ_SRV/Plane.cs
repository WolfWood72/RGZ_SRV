using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGZ_SRV
{
    public class Plane
    {
        public enum PlaneStatusCode {  InQueueTakeOff, Takeoff, InFlight,  InQueueLanding, Landing, OnGroud };
        static Int32 Counter;
        public Int32 Number;
        public Int32 TimeTakeoff { get; set; } //Время взлета в секундах
        public Int32 TimeLanding { get; set; } //Время посадки в секундах
        public Int32 LengthTakeOff { get; set; } // Длина разбега
        public Int32 FuelResidual { get; set; } // Остаток топлива
        public Int32 WaitTime { get; set; }
        public PlaneStatusCode Status { get; set; }
        public Plane(Int32 FuelResidual, Int32 TimeLanding,
                     Int32 LengthTakeOff, Int32 TimeTakeoff)
        {
            this.Number = ++Counter;
            this.TimeLanding = TimeLanding;
            this.TimeTakeoff = TimeTakeoff;
            this.LengthTakeOff = LengthTakeOff;
            this.FuelResidual = FuelResidual;
            this.WaitTime = -1;            
        }
        public Plane(Int32 FuelResidual, Int32 TimeLanding,
             Int32 LengthTakeOff, Int32 TimeTakeoff, Boolean Up)
        {
            this.Number = ++Counter;
            this.TimeLanding = TimeLanding;
            this.TimeTakeoff = TimeTakeoff;
            this.LengthTakeOff = LengthTakeOff;
            this.FuelResidual = FuelResidual;
            this.WaitTime = -1;
            this.Status = Up ? PlaneStatusCode.InQueueTakeOff : PlaneStatusCode.InQueueLanding;
        }


        public static PlaneStatusCode GetNextStatus(PlaneStatusCode CurrStatus)
        {
            PlaneStatusCode NextStatus;
            switch(CurrStatus)
            {
                case PlaneStatusCode.InFlight:
                    NextStatus = PlaneStatusCode.InFlight;
                    break;
                case PlaneStatusCode.OnGroud:
                    NextStatus = PlaneStatusCode.OnGroud;
                    break;
                case PlaneStatusCode.InQueueTakeOff:
                    NextStatus = PlaneStatusCode.Takeoff;
                    break;
                case PlaneStatusCode.InQueueLanding:
                    NextStatus = PlaneStatusCode.Landing;
                    break;
                case PlaneStatusCode.Takeoff:
                    NextStatus = PlaneStatusCode.InFlight;
                    break;
                case PlaneStatusCode.Landing:
                    NextStatus = PlaneStatusCode.OnGroud;
                    break;
                default:
                    NextStatus = CurrStatus;
                    break;
                    
            }

            return NextStatus;
        }

        public override string ToString()
        {
            return String.Format("FuelResidual = {0} \t TimeTakeoff = {1} \t TimeLanding = {2} \t LengthTakeOff = {3} \t", FuelResidual.ToString(), TimeTakeoff.ToString(), TimeLanding.ToString(), LengthTakeOff.ToString());
        }

        public string GetStringProperty()
        {
            return String.Format("Остаток топлива={0} Время взлета={1}  Время посадки={2} Длина разбега={3}", FuelResidual.ToString(), TimeTakeoff.ToString(), TimeLanding.ToString(), LengthTakeOff.ToString());

        }

    }
}
 