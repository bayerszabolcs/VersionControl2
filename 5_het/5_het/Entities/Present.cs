using _5_het.Abstractions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_het.Entities
{
    class Present : Toy
    {
        public SolidBrush Present1Color { get; set; }
        public SolidBrush Present2Color { get; set; }
        public Present(Color box, Color ribbon)
        {
            Present1Color = new SolidBrush(box);
            Present2Color = new SolidBrush(ribbon);

        }
        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(Present1Color, 0, 0, Width, Height);
            g.FillRectangle(Present2Color, 0, Height/5, Width, Height / 4);
            g.FillRectangle(Present2Color, Width/5, 0, Width / 3, Height);

        }
    }
}
