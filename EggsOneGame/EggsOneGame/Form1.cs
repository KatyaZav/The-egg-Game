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
                    break;
                case (Keys.C):
                    BasketR.Visible = false;
                    BasketC.Visible = true;
                    BasketU.Visible = false;
                    BasketM.Visible = false;
                    break;
                case (Keys.U):
                    BasketR.Visible = false;
                    BasketC.Visible = false;
                    BasketU.Visible = true;
                    BasketM.Visible = false;
                    break;
                case (Keys.M):
                    BasketR.Visible = false;
                    BasketC.Visible = false;
                    BasketU.Visible = false;
                    BasketM.Visible = true;
                    break;
            }
        }
    }
}
