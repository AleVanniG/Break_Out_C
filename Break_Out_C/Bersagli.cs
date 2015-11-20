using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Break_Out_C
{
    class Bersagli : List<Bersaglio>
    {
        public Bersagli()
        {

        }

        public PictureBox Collision(PictureBox immagine)
        {
            foreach(Bersaglio x in this)
            {    
                if (x.Bounds.IntersectsWith(immagine.Bounds))
                {
                    this.Remove(x);
                    return x;
                }
            }
            return null;
        }

        public Bersagli(int sizeForm) : this()
        {
            int startX = 10, startY = 30;
            int var = 0;
            for (int i = 0; i < 3; i++)
            {
                var = 0;
                while (var < sizeForm)
                {
                   
                    Add(new Bersaglio(var+startX , startY ));
                  
                    var += startX + 100;
                }
                startY = startY+30;
           }
        }
    }
}
