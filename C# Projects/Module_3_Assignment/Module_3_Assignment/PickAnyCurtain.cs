using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_3_Assignment
{
    public partial class PickAnyCurtain : Form
    {
        bool chose;
        public PickAnyCurtain()
        {
            InitializeComponent();
            chose = false;

        }

        private void curtain5_Click(object sender, EventArgs e)
        {
            if (chose == false)
            {
                this.prize.Text = "You won a Million Dollars!";
                chose = true;
            } else if (chose == true)  
                this.prize.Text = "You can only make one choice"; 
            
        }

        private void curtain7_Click(object sender, EventArgs e)
        {
            if (chose == false)
            {
                this.prize.Text = "You won 50 Dollars!";
                chose = true;
            }else if (chose == true) 
                this.prize.Text = "You can only make one choice";
            
        }

        private void curtain9_Click(object sender, EventArgs e)
        {
            if (chose == false)
            {
                this.prize.Text = "You won 70,000 Dollars!";
                chose = true;  
            }else if (chose == true)  
                this.prize.Text = "You can only make one choice";
              
            
        }
    }
}
