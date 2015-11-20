using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Break_Out_C
{
    class Bersaglio : PictureBox
    {
        public Bersaglio() { }
        public Bersaglio(int locationx, int locationy)
        {
            Location = new Point(locationx, locationy);
            Image = global::Break_Out_C.Properties.Resources.nemici;
            Visible = true;
            Size = new System.Drawing.Size(100, 20);
        }
    }
}
