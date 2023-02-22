using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }
        int itemCount = 5;
        float MainTimer1 = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            MainTimer.Start();
                {
                foreach (PictureBox pictureBox in panel1.Controls)
                {
                    pictureBox.BackColor = Color.Transparent;
                    label1.Text = "Вам необходимо найти предметы: " + itemCount.ToString() + " яблок!";
                }
                }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            itemCount--;
            if (itemCount <= 0)
            {
                MainTimer.Stop();
                MessageBox.Show("Вы нашли все предметы", "Поздравляем!");
            }
            else label1.Text = "Вам осталось найти " + itemCount.ToString() + " яблок!";

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            itemCount--;
            if (itemCount <= 0)
            {
                MainTimer.Stop();
                MessageBox.Show("Вы нашли все предметы", "Поздравляем!");

            }
            else label1.Text = "Вам осталось найти " + itemCount.ToString() + " яблок!";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            itemCount--;
            if (itemCount <= 0)
            {
                MainTimer.Stop();
                MessageBox.Show("Вы нашли все предметы", "Поздравляем!");
            }
            else label1.Text = "Вам осталось найти " + itemCount.ToString() + " яблок!";

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            itemCount--;
            if (itemCount <= 0)
            {
                MainTimer.Stop();
                MessageBox.Show("Вы нашли все предметы", "Поздравляем!");

            }
            else label1.Text = "Вам осталось найти " + itemCount.ToString() + " яблок!";

               
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            itemCount--;
            if (itemCount <= 0)
            {
                MainTimer.Stop();
                MessageBox.Show("Вы нашли все предметы", "Поздравляем!");
                
            }
            else label1.Text = "Вам осталось найти " + itemCount.ToString() + " яблок!";
        }
       
        
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            MainTimer1++;
            float timerg = MainTimer1 / 100;
            
            
            TimeLbl.Text = "Прошло: " + timerg.ToString();

            string temp = @"C:\Users\Melis\test.txt";

            using (StreamWriter writer = new StreamWriter(temp, false))
            {
                writer.WriteLine("Вы прошли игру за " + timerg);

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           /* MainTimer.Enabled = true;
            MainTimer.Start();*/
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            /*MainTimer.Stop();
            MainTimer.Enabled = false;*/
        }

      

        

        
    }
}
