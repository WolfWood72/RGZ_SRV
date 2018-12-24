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
    public partial class AddPlaneForm : Form
    {
        public AddPlaneForm()
        {
            InitializeComponent();
        }
        private Plane MakePlane()
        {
            Int32 TimeTakeoff = (Int32)this.TimeTakeOffNumcUpDown.Value;
            Int32 TimeLanding = (Int32)this.TimeLandingNumUpDown.Value;
            Int32 LengthTakeOff = (Int32)this.LengthTakeOffNumUpDown.Value;
            Int32 FuelResidual = (Int32)this.FuelResidualNumUpDown.Value;
            Boolean Up = this.TakeOffRadioBtn.Checked;
            return new Plane(FuelResidual, TimeLanding, LengthTakeOff, TimeTakeoff, Up);
        }
        private void AddPlaneBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {

                Plane pln = MakePlane();
                if(main.airport.RunwayList.Count == 0)
                {
                    MessageBox.Show("Не создано ни одной взлетно-посадочной полосы");
                    return;
                }
                if (this.TakeOffRadioBtn.Checked && main.airport.TakeOffQueue.Count() + 1 > main.airport.MaxQuerySizeToTakeOff)
                {
                    MessageBox.Show("Количество самолетов в очереди на взлет превышает максимальное количество");
                    return;
                }
                if (this.LandigRbtn.Checked && main.airport.LandingQueue.Count() + 1 > main.airport.MaxQueryForSizeLanding)
                {
                    MessageBox.Show("Количество самолетов в очереди на посадку превышает максимальное количество");
                    return;
                }
                if (pln.LengthTakeOff > main.airport.GetMaxLengthOfRunway())
                {
                    MessageBox.Show("Максимальная длина имеющихся ВПП менше, чем длина разбега у данного самолета");
                    return;
                }
                
                main.AddPlane(pln, this.TakeOffRadioBtn.Checked ? Form1.PlaneDirection.up : Form1.PlaneDirection.down);
                this.Close();
               
            }
        }
    }
}
