using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace My_Litle_WT
{
    public partial class SlotMachine : Form
    {
        Random rnd = new Random();
        Form1 mainForm;
        bool isGambling = false;

        public SlotMachine(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }

        void ShowMoney()
        {
            this.moneyLabel.Text = Convert.ToString(mainForm.money) + "$";
        }

        private void RollMachine(object sender, EventArgs e)
        {
            if (mainForm.money >= 50)
            {
                if (!isGambling)
                {
                    isGambling = true;
                    mainForm.money -= 50;
                    ShowMoney();
                    int num = rnd.Next(1, 101);
                    if (num <= 40)
                    {
                        mainForm.money += 150;
                        resultLabel.Text = "You WIN!";
                        resultLabel.BackColor = Color.Lime;

                    }
                    else
                    {
                        resultLabel.BackColor = Color.Red;
                        resultLabel.Text = "You LOSE!";
                    }

                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 3000;
                    timer.Tick += (s, args) =>
                    {
                        resultLabel.Text = "";
                        resultLabel.BackColor = Color.DarkGray;
                        isGambling = false;
                        timer.Stop();
                    };
                    timer.Start();
                    ShowMoney();
                }
            }
            else
            {
                MessageBox.Show("недостатньо коштів","Error",MessageBoxButtons.OK,MessageBoxIcon.Hand);  
            }

        }

        private void SlotMachine_Load(object sender, EventArgs e)
        {
            ShowMoney();
        }
    }
}
