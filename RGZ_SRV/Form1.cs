using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_SRV
{

    public partial class   Form1 : Form
    {
       public  Airport airport = new Airport();
        public enum PlaneDirection { up, down}
        Dictionary<Runway.RunwayStatusCode, string> RunwayViewStatus = new Dictionary<Runway.RunwayStatusCode, string>();
        Dictionary<Plane.PlaneStatusCode , string> PlaneViewStatus = new Dictionary<Plane.PlaneStatusCode, string>();
        public Form1()
        {
            InitializeComponent();
            RunwayViewStatus.Add(Runway.RunwayStatusCode.Busy, "Занято");
            RunwayViewStatus.Add(Runway.RunwayStatusCode.Wait, "Ожидание");
            RunwayViewStatus.Add(Runway.RunwayStatusCode.Free, "Свободно");
            PlaneViewStatus.Add(Plane.PlaneStatusCode.InFlight, "Взлетел");
            PlaneViewStatus.Add(Plane.PlaneStatusCode.InQueueLanding, "Очередь на посадку");
            PlaneViewStatus.Add(Plane.PlaneStatusCode.InQueueTakeOff, "Очередь на взлет");
            PlaneViewStatus.Add(Plane.PlaneStatusCode.Landing, "Посадка");
            PlaneViewStatus.Add(Plane.PlaneStatusCode.OnGroud, "Приземлился");
            PlaneViewStatus.Add(Plane.PlaneStatusCode.Takeoff, "Взлет");
            TimerLabel.Text = "00:00:00";
            airport.MaxQueryForSizeLanding = 10;
            airport.MaxQuerySizeToTakeOff = 10;
            TimeCounter.Time = 0;
        }
        public void RefreshViewOfAirport()
        {
            DGW_runway.Rows.Clear();
            dGW_Plane.Rows.Clear();
            dGW_PlaneEnd.Rows.Clear();
            foreach (var runway in airport.RunwayList)
                if (runway.CurrentPlane == null)
                    DGW_runway.Rows.Add(runway.Number, runway.LengthRunway, RunwayViewStatus[runway.Status], FormatTime(runway.WaitTime));
                else
                    DGW_runway.Rows.Add(runway.Number, runway.LengthRunway,RunwayViewStatus[runway.Status], FormatTime(runway.WaitTime), runway.CurrentPlane.Number, runway.CurrentPlane.GetStringProperty(), PlaneViewStatus[runway.CurrentPlane.Status]);
            foreach (var plane in airport.LandingQueue.PlaneList)
            {
                if (plane.Value.Status == Plane.PlaneStatusCode.InQueueLanding || plane.Value.Status == Plane.PlaneStatusCode.InQueueTakeOff)
                    dGW_Plane.Rows.Add(plane.Value.Number, plane.Value.TimeTakeoff, plane.Value.TimeLanding, plane.Value.LengthTakeOff, plane.Value.FuelResidual, PlaneViewStatus[plane.Value.Status]);
                
            }
            foreach (var plane in airport.TakeOffQueue.PlaneList)
            {
                if (plane.Value.Status == Plane.PlaneStatusCode.InQueueLanding || plane.Value.Status == Plane.PlaneStatusCode.InQueueTakeOff)
                    dGW_Plane.Rows.Add(plane.Value.Number, plane.Value.TimeTakeoff, plane.Value.TimeLanding, plane.Value.LengthTakeOff, plane.Value.FuelResidual, PlaneViewStatus[plane.Value.Status]);

            }
            foreach(var plane in airport.EndStatusPlane)
            {
                dGW_PlaneEnd.Rows.Add(plane.Number, plane.TimeTakeoff, plane.TimeLanding, plane.LengthTakeOff, plane.FuelResidual, PlaneViewStatus[plane.Status]);
            }

        }
        public void AddPlane(Plane plane, PlaneDirection direction)
        {
            Func<PlaneDirection, String> PlaneStatus = d => PlaneViewStatus[d == PlaneDirection.up ? Plane.PlaneStatusCode.InQueueTakeOff : Plane.PlaneStatusCode.InQueueLanding];
            //dGW_Plane.Rows.Insert(0, plane.Number, plane.TimeTakeoff, plane.TimeLanding, plane.LengthTakeOff, plane.FuelResidual, PlaneStatus(direction));
            if (direction == PlaneDirection.up)
                airport.AddToTakeOffQueue(plane);
            else
                airport.AddToLandingQueue(plane);
            RefreshViewOfAirport();
            //TODO Сделать проверку на то, что не добавляется самолет с длиной разбега большей чем максимальная длина ВПП
        }
        public void DeletePlane()
        {
            if (dGW_Plane.Rows.Count != 0)
            {
                int number = (int)dGW_Plane.CurrentRow.Cells[0].Value;
                airport.RemovePlane(number);
                // dGW_Plane.Rows.RemoveAt(dGW_Plane.CurrentCell.RowIndex);
                RefreshViewOfAirport();
            }
        }
        public void AddRunway(Runway runway)
        {
            //DGW_runway.Rows.Insert(0, runway.Number, runway.LengthRunway, RunwayViewStatus[Runway.RunwayStatusCode.Free]);
            
            airport.AddRunway(runway);
            RefreshViewOfAirport();
        }
        public void DeleteRunway()
        {
            if (DGW_runway.Rows.Count != 0)
            {
                int number = (int)DGW_runway.CurrentRow.Cells[0].Value;
                var runway = airport.GetRunway(number);
                if(runway.CurrentPlane != null)
                for (int v = 0; v < dGW_Plane.Rows.Count; v++)
                {
                    if ((int)dGW_Plane[0, v].Value  == runway.CurrentPlane.Number)
                    {
                        dGW_Plane.Rows.RemoveAt(v);
                        break;
                    }
                }
               
                runway.CurrentPlane = null;
                runway = null;
                // airport(number);
                //  DGW_runway.Rows.RemoveAt(DGW_runway.CurrentCell.RowIndex);
                RefreshViewOfAirport();

            }
        }
        public String FormatTime(Int64 Time)
        {
            Int64 s = Time % 60;
            Int64 m = Time / 60 % 60;
            Int64 h = Time / 60 / 60 % 24;
            return String.Format("{0:D2}:{1:D2}:{2:D2}", h.ToString(), m.ToString(), s.ToString());
        }
        public String FormatTime(Int32 Time)
        {
            Int32 s = Time % 60;
            Int32 m = Time / 60 % 60;
            Int32 h = Time / 60 / 60 % 24;
            return String.Format("{0:D2}:{1:D2}:{2:D2}", h.ToString(), m.ToString(), s.ToString());
        }

        public void RefreshTimeLabel(Int64 Time)
        {
            TimerLabel.Text = FormatTime(Time);
        }
        public void ResetAirportState()
        {

        }



        private void AddPlaneBtn_Click(object sender, EventArgs e)
        {
            var PlaneForm = new AddPlaneForm();
            PlaneForm.Owner = this;
            PlaneForm.ShowDialog();
  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
                TimeCounter.Time++;
                RefreshTimeLabel(TimeCounter.Time);

                ///Распределить самолеты в очереди по свободным ВПП
                airport.DistributePlanesOnRunways();
                ///Обновляем статусы ВПП и самолетов на них
                ///
                airport.UpdateStatus();
                RefreshViewOfAirport();
       
            }

        private void TimerStart_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
            AddRunwayBtn.Enabled = false;
            DeleteRunwayBtn.Enabled = false;
            MinIntervalBetweenLAndingNumUpDown.Enabled = false;
        }

        private void TimerStop_button_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void TimerReset_button_Click(object sender, EventArgs e)
        {
        
            TimeCounter.Time = 0;
            TimerLabel.Text = "00:00:00";
            timer1.Stop();
            airport.ResetAirport();
            MinIntervalBetweenLAndingNumUpDown.Enabled = true;
            AddRunwayBtn.Enabled = true;
            DeleteRunwayBtn.Enabled = true;
            RefreshViewOfAirport();

        }

        private void DeletePlaneBtn_Click(object sender, EventArgs e)
        {
            DeletePlane();
            RefreshViewOfAirport();
        }

        private void AddRunwayBtn_Click(object sender, EventArgs e)
        {
            var RunwayForm = new AddRunwayForm();
            RunwayForm.Owner = this;
            RunwayForm.ShowDialog();
        }

        private void DeleteRunwayBtn_Click(object sender, EventArgs e)
        {
            DeleteRunway();
            RefreshViewOfAirport();
        }

        private void MaxQuerySizeForTakeOFFnumUpDown_ValueChanged(object sender, EventArgs e)
        {
            airport.MaxQuerySizeToTakeOff = (Int32)((NumericUpDown)sender).Value;
        }

        private void MaxQUerySizeForLandingNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            airport.MaxQueryForSizeLanding = (Int32)((NumericUpDown)sender).Value;
        }

        private void MinIntervalBetweenLAndingNumUpDown_ValueChanged(object sender, EventArgs e)
        {
            Airport.MinIntervalBetweenLanding = (Int32)((NumericUpDown)sender).Value;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var c = new Credits();
            c.Show();
        }
    }
}
