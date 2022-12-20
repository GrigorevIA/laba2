using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLib
{
    public class Square : Rectagle
    {
        public Square(int x, int y, int w) : base(x, y, w, w)
        { 
        }
    }
}
