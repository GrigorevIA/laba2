using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;

namespace LABA2OOP
{
    public partial class AllTasks : Form
    {
        public AllTasks()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Rectagle rectagle = new Rectagle();
            rectagle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Square square = new Square();
            square.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ellips ellips = new Ellips();
            ellips.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            circle.Show();
        }
    }
}
