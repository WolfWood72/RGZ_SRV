using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGZ_SRV
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

        //  PlanQueue  pq = new PlanQueue();
        //  pq.AddPlane(new Plane(1, 1, 1, 1));
        //  pq.AddPlane(new Plane(2, 2, 2, 2));
        //  pq.AddPlane(new Plane(3, 1, 1, 1));
        //  pq.AddPlane(new Plane(3, 2, 2, 2));
        //  pq.AddPlane(new Plane(4, 4, 4, 4));
        //
        //  Plane p;
        //  while (!pq.IsEmpty())
        //  {
        //      p = pq.PopPlane();
        //      
        //      Console.WriteLine(p.ToString());
        //     
        //
        //  }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
