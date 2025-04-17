namespace My_Litle_WT
{
    partial class ShopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShopForm));
            this.defSkin = new System.Windows.Forms.Button();
            this.pixSkin = new System.Windows.Forms.Button();
            this.AiSkin = new System.Windows.Forms.Button();
            this.defSkinStatus = new System.Windows.Forms.Label();
            this.pixSkinStatus = new System.Windows.Forms.Label();
            this.AiSkinStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // defSkin
            // 
            this.defSkin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.defSkin.BackgroundImage = global::My_Litle_WT.Properties.Resources.NoBGteapot;
            this.defSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.defSkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defSkin.Location = new System.Drawing.Point(35, 11);
            this.defSkin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.defSkin.Name = "defSkin";
            this.defSkin.Size = new System.Drawing.Size(175, 162);
            this.defSkin.TabIndex = 0;
            this.defSkin.UseVisualStyleBackColor = false;
            this.defSkin.Click += new System.EventHandler(this.defSkin_Click);
            // 
            // pixSkin
            // 
            this.pixSkin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pixSkin.BackgroundImage = global::My_Litle_WT.Properties.Resources.PixelWT;
            this.pixSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pixSkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pixSkin.Location = new System.Drawing.Point(233, 11);
            this.pixSkin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pixSkin.Name = "pixSkin";
            this.pixSkin.Size = new System.Drawing.Size(175, 162);
            this.pixSkin.TabIndex = 1;
            this.pixSkin.UseVisualStyleBackColor = false;
            this.pixSkin.Click += new System.EventHandler(this.pixSkin_Click);
            // 
            // AiSkin
            // 
            this.AiSkin.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AiSkin.BackgroundImage = global::My_Litle_WT.Properties.Resources.AiWT;
            this.AiSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AiSkin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AiSkin.Location = new System.Drawing.Point(432, 11);
            this.AiSkin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AiSkin.Name = "AiSkin";
            this.AiSkin.Size = new System.Drawing.Size(175, 162);
            this.AiSkin.TabIndex = 2;
            this.AiSkin.UseVisualStyleBackColor = false;
            this.AiSkin.Click += new System.EventHandler(this.AiSkin_Click);
            // 
            // defSkinStatus
            // 
            this.defSkinStatus.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.defSkinStatus.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.defSkinStatus.Location = new System.Drawing.Point(31, 190);
            this.defSkinStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.defSkinStatus.Name = "defSkinStatus";
            this.defSkinStatus.Size = new System.Drawing.Size(178, 25);
            this.defSkinStatus.TabIndex = 3;
            this.defSkinStatus.Text = "Owned";
            this.defSkinStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pixSkinStatus
            // 
            this.pixSkinStatus.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pixSkinStatus.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.pixSkinStatus.Location = new System.Drawing.Point(230, 190);
            this.pixSkinStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pixSkinStatus.Name = "pixSkinStatus";
            this.pixSkinStatus.Size = new System.Drawing.Size(178, 25);
            this.pixSkinStatus.TabIndex = 4;
            this.pixSkinStatus.Text = "Not Owned";
            this.pixSkinStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AiSkinStatus
            // 
            this.AiSkinStatus.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AiSkinStatus.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.AiSkinStatus.Location = new System.Drawing.Point(429, 190);
            this.AiSkinStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AiSkinStatus.Name = "AiSkinStatus";
            this.AiSkinStatus.Size = new System.Drawing.Size(178, 25);
            this.AiSkinStatus.TabIndex = 5;
            this.AiSkinStatus.Text = "Not Owned";
            this.AiSkinStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(429, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "1000$";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(230, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "300$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(31, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "0$";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(635, 256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AiSkinStatus);
            this.Controls.Add(this.pixSkinStatus);
            this.Controls.Add(this.defSkinStatus);
            this.Controls.Add(this.AiSkin);
            this.Controls.Add(this.pixSkin);
            this.Controls.Add(this.defSkin);
            this.Font = new System.Drawing.Font("Ink Free", 8.25F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ShopForm";
            this.Text = "Shop";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button defSkin;
        private System.Windows.Forms.Button pixSkin;
        private System.Windows.Forms.Button AiSkin;
        private System.Windows.Forms.Label defSkinStatus;
        private System.Windows.Forms.Label pixSkinStatus;
        private System.Windows.Forms.Label AiSkinStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}