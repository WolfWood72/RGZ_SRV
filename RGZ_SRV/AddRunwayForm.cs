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
    public partial class AddRunwayForm : Form
    {
        public AddRunwayForm()
        {
            InitializeComponent();
        }
        private Runway MakeRunway()
        {
            Int32 Length = (Int32)this.LengthNumUpDown.Value;
            return new Runway(Length);
        }

        private void AddRunwayBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                Runway pln = MakeRunway();
                main.AddRunway(pln);
                this.Close();
            }
        }
    }
}
