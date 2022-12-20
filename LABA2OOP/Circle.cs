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
    public partial class Circle : Form
    {
        public MyLib.Circle circle;
        Bitmap bitmap;
        Pen pen = new Pen(Color.Black, 5);
        public Circle()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            Init.pen = this.pen;
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 0)
            {
                foreach (Figure f in ShapeContainer.figureList)
                {
                    if (f.Name == comboBox1.SelectedItem.ToString())
                    {
                        circle = (MyLib.Circle)f;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                circle = new MyLib.Circle(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                circle.Draw();
                ShapeContainer.AddFigure(circle);
                comboBox1.Items.Add(circle.Name);
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
                circle.MoveTo(int.Parse(textBox5.Text), int.Parse(textBox6.Text));
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
                circle.ch_w(int.Parse(textBox7.Text));
                circle.ch_h(int.Parse(textBox7.Text));
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введено не число!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            circle.DeleteF(circle, true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count != 0)
            {
                foreach (Figure f in ShapeContainer.figureList)
                {
                    if (f.Name == comboBox1.SelectedItem.ToString())
                    {
                        circle = (MyLib.Circle)f;
                    }
                }
            }
        }
    }
}
