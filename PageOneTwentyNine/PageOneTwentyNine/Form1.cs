using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PageOneTwentyNine
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;

        }
        public Form1()
        {
            InitializeComponent();

            joe = new Guy();
            joe.Name = "Joe";
            joe.Cash = 50;
            
            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;

            UpdateForm();
           }


        private void bankToJoeButton_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("The bank is out of money.");
            }
            
        }

        private void bobToBankButton_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeToBobButton_Click(object sender, EventArgs e)
        {
            joe.GiveCash(bob.ReceiveCash(10));
            ;
            UpdateForm();
        }

        private void bobToJoeButton_Click(object sender, EventArgs e)
        {
            bob.GiveCash(joe.ReceiveCash(5));
            ;
            UpdateForm();
        }
    }
}
