using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsOneGame
{
    public partial class Form1 : Form
    {
        enum Basket
        {
            topLeft,
            downLeft,
            topRight,
            downRight
        };

        int Count = 0;
        int GoodCount = 0;
        Basket BasketActive = Basket.downLeft; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.R):
                    BasketR.Visible = true;
                    BasketC.Visible = false;
                    BasketU.Visible = false;
                    BasketM.Visible = false;
                    BasketActive = Basket.topLeft;
                    break;
                case (Keys.C):
                    BasketR.Visible = false;
                    BasketC.Visible = true;
                    BasketU.Visible = false;
                    BasketM.Visible = false;
                    BasketActive = Basket.downLeft;
                    break;
                case (Keys.U):
                    BasketR.Visible = false;
                    BasketC.Visible = false;
                    BasketU.Visible = true;
                    BasketM.Visible = false;
                    BasketActive = Basket.topRight;
                    break;
                case (Keys.M):
                    BasketR.Visible = false;
                    BasketC.Visible = false;
                    BasketU.Visible = false;
                    BasketM.Visible = true;
                    BasketActive = Basket.downRight;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GoodCount == 3)
            {
                timer1.Interval = 1500;
                timer2.Interval = 1700;
                timer3.Interval = 1700;
                timer4.Interval = 1700;
                timer5.Interval = 1700;
            }
            if (GoodCount == 7)
            {
                timer1.Interval = 1200;
                timer2.Interval = 1500;
                timer3.Interval = 1500;
                timer4.Interval = 1500;
                timer5.Interval = 1500;
            }

            var rnd = new Random();
            var number = rnd.Next(1, 5);

            switch(number)
            {
                case (1):
                    ballUpLeftFirst.Visible = true;
                    timer2.Enabled = true;
                    break;
                case (2):
                    ballDownLeftFirst.Visible = true;
                    timer3.Enabled = true;
                    break;
                case (3):
                    ballUpRightFirst.Visible = true;
                    timer4.Enabled = true;
                    break;
                case (4): 
                    ballDownRightFirst.Visible = true;
                    timer5.Enabled = true;
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ballUpLeftSecond.Visible == true)
            {
                ballUpLeftSecond.Visible = false;
                if (BasketActive != Basket.topLeft)
                {
                    Count++;
                    label2.Text = Count + "";
                }
                else GoodCount++;
            }

            if (ballUpLeftFirst.Visible == true)
            {
                ballUpLeftFirst.Visible = false;
                ballUpLeftSecond.Visible = true;
            }

            if (ballUpLeftSecond.Visible == false && ballUpLeftFirst.Visible == false)
                timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (ballDownLeftSecond.Visible == true)
            {
                ballDownLeftSecond.Visible = false;
                if (BasketActive != Basket.downLeft)
                {
                    Count++;
                    label2.Text = Count + "";
                }
                else GoodCount++;
            }

            if (ballDownLeftFirst.Visible == true)
            {
                ballDownLeftFirst.Visible = false;
                ballDownLeftSecond.Visible = true;
            }

            if (ballDownLeftSecond.Visible == false && ballDownLeftFirst.Visible == false)
                timer3.Enabled = false;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (ballUpRightSecond.Visible == true)
            {
                ballUpRightSecond.Visible = false;
                if (BasketActive != Basket.topRight)
                {
                    Count++;
                    label2.Text = Count + "";
                }
                else GoodCount++;
            }

            if (ballUpRightFirst.Visible == true)
            {
                ballUpRightFirst.Visible = false;
                ballUpRightSecond.Visible = true;
            }

            if (ballUpRightFirst.Visible == false && ballUpRightSecond.Visible == false)
                timer4.Enabled = false;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (ballDownRightSecond.Visible == true)
            {
                ballDownRightSecond.Visible = false;
                if (BasketActive != Basket.downRight)
                {
                    Count++;
                    label2.Text = Count + "";
                }
                else GoodCount++;
            }

            if (ballDownRightFirst.Visible == true)
            {
                ballDownRightFirst.Visible = false;
                ballDownRightSecond.Visible = true;
            }

            if (ballDownRightFirst.Visible == false && ballDownRightSecond.Visible == false)
                timer5.Enabled = false;
        }
    }
}
