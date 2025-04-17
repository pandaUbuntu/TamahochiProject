using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using My_Litle_WT.Properties;
using System.Timers;

using WMPLib;
using System.IO;

namespace My_Litle_WT
{
    public partial class Form1 : Form
    {
        bool isDoing = false;
        public int money { get; set; } = 0;
        public bool pixStatus { get; set; } = false;
        public bool aiStatus { get; set; } = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void addBar(ProgressBar progressBar,int toAdd)
        {
            if (toAdd + progressBar.Value < 100)
            { progressBar.Value += toAdd; }
            else { progressBar.Value = 100; }
        }
        private void decreaseBar(ProgressBar progressBar, int toAdd)
        {
            if ( progressBar.Value - toAdd > 0)
            { progressBar.Value -= toAdd; }
            else { progressBar.Value = 0; }
        }

        public void warnMes(string warn)
        {
            MessageBox.Show(warn, "Нагадування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void defMes(string text)
        {
            MessageBox.Show(text, "Чудово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void doingMes() { warnMes("Ваш чайник зайнятий!"); }

        public void Lose()
        {
            DialogResult mes = MessageBox.Show("Ви не доглядали за чайником? Він помер через вас!", "Ви програли!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            if (mes == DialogResult.OK ) 
            { 
            this.Close();
            }
        }

        public void showMoney() { this.moneyLabel.Text = Convert.ToString(money) + "$"; }
        public void giveMoney() 
        {
            money+=25;
            showMoney();
        }
        public void checkBar()
        {
            if (happinessBar.Value == 20) { warnMes("Ваш чайник сумний, пограйтеся з ним!"); }
            if (energyBar.Value == 20) { warnMes("Ваш чайник втомився, покладіть його спати!"); }
            if (hungerBar.Value == 80) { warnMes("Ваш чайник голодний, нагодуйте його!"); }

            if (happinessBar.Value == 0 || energyBar.Value == 0 || hungerBar.Value == 100){ Lose();}
        }

      

        private void Play(object sender, EventArgs e)
        {
            if (!isDoing)
            {
                isDoing = true;
                this.BackColor = Color.Gold;
                StatusLabel.Text = "Грає...";
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 4000;
                timer.Tick += (s, args) =>
                {
                    isDoing = false;
                    giveMoney();
                    addBar(happinessBar, 25);
                    decreaseBar(energyBar, 20);
                    addBar(hungerBar, 15);
                    checkBar();
                    this.BackColor= Color.MediumSpringGreen;
                    StatusLabel.Text = "";
                    timer.Stop();
                };
                timer.Start();
            }
            else
            {
                doingMes();
            }
        }

        private void Sleep(object sender, EventArgs e)
        {
            if (!isDoing)
            {
                isDoing = true;
                this.BackColor = Color.SlateBlue;
                StatusLabel.Text = "Спить...";
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 4000;
                timer.Tick += (s, args) =>
                {
                    isDoing = false;
                    giveMoney();
                    addBar(energyBar, 25);
                    addBar(hungerBar, 10);
                    decreaseBar(happinessBar,15);
                    checkBar();
                    this.BackColor = Color.MediumSpringGreen;
                    StatusLabel.Text = "";
                    timer.Stop();
                };
                timer.Start();
            }
            else
            {
                doingMes();
            }
        }

        private void Feed(object sender, EventArgs e)
        {
            if (!isDoing)
            {
                isDoing = true;
                this.BackColor = Color.Orange;
                StatusLabel.Text = "Їсть...";
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 4000;
                timer.Tick += (s, args) =>
                {
                    isDoing = false;
                    giveMoney();
                    decreaseBar(hungerBar, 25);
                    addBar(happinessBar, 10);
                    addBar(energyBar, 15);
                    checkBar();
                    this.BackColor = Color.MediumSpringGreen;
                    StatusLabel.Text = "";
                    timer.Stop();
                };
                timer.Start();
            }
            else
            {
                doingMes();
            }
        }

        public void ChangeSkin(Image img)
        {
        teapot.BackgroundImage = img;
        }

        private void ShopButton_Click(object sender, EventArgs e)
        {
            if (!isDoing)
            {
                ShopForm shopForm = new ShopForm(this);
                shopForm.ShowDialog();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //SoundPlayer mainMusic = new SoundPlayer(Resources.MainMusic);
            //mainMusic.PlayLooping();

            System.Timers.Timer basetimer = new System.Timers.Timer(8000);
            basetimer.AutoReset = true;
            basetimer.Elapsed += (s, args) =>
            {
                decreaseBar(happinessBar, 5);
                decreaseBar(energyBar, 5);
                addBar(hungerBar, 5);
                checkBar();
            };
            basetimer.Start();
        }

        private void slotMachine_Click(object sender, EventArgs e)
        {
            if (!isDoing)
            {
                SlotMachine slotForm = new SlotMachine(this);
                slotForm.ShowDialog();
            }

        }
    }
}
