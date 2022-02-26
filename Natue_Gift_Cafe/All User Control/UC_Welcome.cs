using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Natue_Gift_Cafe.All_User_Control
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (num == 0)
            {
                LableBanner.Location = new Point(94,367);
                LableBanner.ForeColor = Color.Orange;
                num++;
            }
            else if(num==1)
            {
                LableBanner.Location = new Point(166, 367);
                LableBanner.ForeColor = Color.Green;
                num++;
            }
            else if (num == 2)
            {
                LableBanner.Location = new Point(268, 367);
                LableBanner.ForeColor = Color.RoyalBlue;
                num = 0;
            }

        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
