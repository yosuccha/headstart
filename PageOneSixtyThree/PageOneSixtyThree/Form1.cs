using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PageOneSixtyThree
{
    public partial class Form1 : Form
    {
        Elephant lucinda;
        Elephant lloyd;
        Elephant swap;

        public Form1()
        {
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

            InitializeComponent();
        }

        private void lloydButton_Click(object sender, EventArgs e)
        {
            lloyd.WhoAmI();
        }

        private void lucindaButton_Click_1(object sender, EventArgs e)
        {
            lucinda.WhoAmI();
        }

        private void swapButton_Click(object sender, EventArgs e)
        {
            swap = lucinda;
            lucinda = lloyd;
            lloyd = swap;
            MessageBox.Show("Objects Swapped");
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lloyd = lucinda;
            lloyd.EarSize = 4321;
            lloyd.WhoAmI();
        }
    }
}
