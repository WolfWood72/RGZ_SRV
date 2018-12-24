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
    public partial class Credits : Form
    {
        public Credits()
        {
            InitializeComponent();
            label1.Text = "Имитатор системы управления аэропортом\nАвтор: Дрозин И.А. \nНГТУ ФПМИ ПМИМ-71\n 2018 г.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
