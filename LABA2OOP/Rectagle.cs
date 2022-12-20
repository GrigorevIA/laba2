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
    public partial class Rectagle : Form
    {
        public MyLib.Rectagle rectagle;
        Bitmap bitmap;
        Pen pen = new Pen(Color.Black, 5);
        public Rectagle()
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
                rectagle = new MyLib.Rectagle(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text));
                ShapeContainer.AddFigure(rectagle);
                rectagle.Draw();
                comboBox1.Items.Add(rectagle.Name);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введено не число!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                rectagle.MoveTo(int.Parse(textBox5.Text), int.Parse(textBox6.Text));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введено не число!");
            }
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                rectagle.ch_w(int.Parse(textBox7.Text));
                rectagle.ch_h(int.Parse(textBox8.Text));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введено не число!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rectagle.DeleteF(rectagle, true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 0)
            {
                foreach (Figure f in ShapeContainer.figureList)
                {
                    if (f.Name == comboBox1.SelectedItem.ToString())
                    {
                        rectagle = (MyLib.Rectagle)f;
                    }
                }
            }
        }
    }
}
