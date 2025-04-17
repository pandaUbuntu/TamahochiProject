using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_Litle_WT.Properties;

namespace My_Litle_WT
{
    public partial class ShopForm : Form
    {
        Form1 mainForm;
        public ShopForm(Form1 form)
        {
            InitializeComponent();
            mainForm = form;
        }



        private void defSkin_Click(object sender, EventArgs e)
        {
            mainForm.ChangeSkin(Resources.NoBGteapot);
        }

        private void pixSkin_Click(object sender, EventArgs e)
        {
            if (mainForm.pixStatus)
            {
                mainForm.ChangeSkin(Resources.PixelWT);
            }
            else {
                if (mainForm.money >= 300)
                {
                    mainForm.money -= 300;
                    mainForm.showMoney();
                    mainForm.pixStatus = true;
                    pixSkinStatus.Text = "Owned";
                    mainForm.ChangeSkin(Resources.PixelWT);
                }
                else { MessageBox.Show("Недостатньо коштів!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error); }
                }
        }

        private void AiSkin_Click(object sender, EventArgs e)
        {
            if (mainForm.aiStatus)
            {
                mainForm.ChangeSkin(Resources.AiWT);
            }
            else
            {
                if (mainForm.money >= 1000)
                {
                    mainForm.money -= 1000;
                    mainForm.showMoney();
                    mainForm.aiStatus = true;
                    AiSkinStatus.Text = "Owned";
                    mainForm.ChangeSkin(Resources.AiWT);
                }
                else { MessageBox.Show("Недостатньо коштів!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void ShopForm_Load(object sender, EventArgs e)
        {
            if (mainForm.pixStatus)
            { pixSkinStatus.Text = "Owned"; }
            if (mainForm.aiStatus)
            { AiSkinStatus.Text = "Owned"; }
        }
    }
}
