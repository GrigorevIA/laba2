using MyLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABA2OOP
{
    public partial class Ellips : Form
    {
        public MyLib.Ellips ellips;
        Bitmap bitmap;
        Pen pen = new Pen(Color.Black, 5);
        public Ellips()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = this.pen;
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                ellips = new MyLib.Ellips(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                ShapeContainer.AddFigure(ellips);
                ellips.Draw();
                comboBox1.Items.Add(ellips.Name);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введено не число!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                ellips.MoveTo(int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введено не число!");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            ellips.DeleteF(ellips, true);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 0)
            {
                foreach (Figure f in ShapeContainer.figureList)
                {
                    if (f.Name == comboBox1.SelectedItem.ToString())
                    {
                        ellips = (MyLib.Ellips)f;
                    }
                }
            }
        }
    }
}
