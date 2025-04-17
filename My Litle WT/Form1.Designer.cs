namespace My_Litle_WT
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.happiness = new System.Windows.Forms.Label();
            this.happinessBar = new System.Windows.Forms.ProgressBar();
            this.energyBar = new System.Windows.Forms.ProgressBar();
            this.energy = new System.Windows.Forms.Label();
            this.hungerBar = new System.Windows.Forms.ProgressBar();
            this.hunger = new System.Windows.Forms.Label();
            this.teapot = new System.Windows.Forms.PictureBox();
            this.sleepButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.feedButton = new System.Windows.Forms.Button();
            this.ShopButton = new System.Windows.Forms.Button();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.slotMachineIcon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teapot)).BeginInit();
            this.SuspendLayout();
            // 
            // happiness
            // 
            this.happiness.AutoSize = true;
            this.happiness.Font = new System.Drawing.Font("Ink Free", 10F, System.Drawing.FontStyle.Bold);
            this.happiness.Location = new System.Drawing.Point(80, 10);
            this.happiness.Name = "happiness";
            this.happiness.Size = new System.Drawing.Size(54, 18);
            this.happiness.TabIndex = 12;
            this.happiness.Text = "Щастя";
            this.happiness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // happinessBar
            // 
            this.happinessBar.Location = new System.Drawing.Point(83, 32);
            this.happinessBar.Name = "happinessBar";
            this.happinessBar.Size = new System.Drawing.Size(400, 23);
            this.happinessBar.TabIndex = 13;
            this.happinessBar.Value = 100;
            // 
            // energyBar
            // 
            this.energyBar.Location = new System.Drawing.Point(83, 81);
            this.energyBar.Name = "energyBar";
            this.energyBar.Size = new System.Drawing.Size(400, 23);
            this.energyBar.TabIndex = 15;
            this.energyBar.Value = 100;
            // 
            // energy
            // 
            this.energy.AutoSize = true;
            this.energy.Font = new System.Drawing.Font("Ink Free", 10F, System.Drawing.FontStyle.Bold);
            this.energy.Location = new System.Drawing.Point(80, 59);
            this.energy.Name = "energy";
            this.energy.Size = new System.Drawing.Size(64, 18);
            this.energy.TabIndex = 14;
            this.energy.Text = "Енергія";
            this.energy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hungerBar
            // 
            this.hungerBar.Location = new System.Drawing.Point(83, 130);
            this.hungerBar.Name = "hungerBar";
            this.hungerBar.Size = new System.Drawing.Size(400, 23);
            this.hungerBar.TabIndex = 17;
            // 
            // hunger
            // 
            this.hunger.AutoSize = true;
            this.hunger.Font = new System.Drawing.Font("Ink Free", 10F, System.Drawing.FontStyle.Bold);
            this.hunger.Location = new System.Drawing.Point(80, 108);
            this.hunger.Name = "hunger";
            this.hunger.Size = new System.Drawing.Size(53, 18);
            this.hunger.TabIndex = 16;
            this.hunger.Text = "Голод";
            this.hunger.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teapot
            // 
            this.teapot.BackgroundImage = global::My_Litle_WT.Properties.Resources.NoBGteapot;
            this.teapot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.teapot.ErrorImage = null;
            this.teapot.InitialImage = null;
            this.teapot.Location = new System.Drawing.Point(175, 200);
            this.teapot.Name = "teapot";
            this.teapot.Size = new System.Drawing.Size(250, 250);
            this.teapot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.teapot.TabIndex = 18;
            this.teapot.TabStop = false;
            // 
            // sleepButton
            // 
            this.sleepButton.BackColor = System.Drawing.Color.SlateBlue;
            this.sleepButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.sleepButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sleepButton.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sleepButton.Location = new System.Drawing.Point(10, 480);
            this.sleepButton.Name = "sleepButton";
            this.sleepButton.Size = new System.Drawing.Size(180, 50);
            this.sleepButton.TabIndex = 19;
            this.sleepButton.Text = "Укласти Спати";
            this.sleepButton.UseVisualStyleBackColor = false;
            this.sleepButton.Click += new System.EventHandler(this.Sleep);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Gold;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(200, 480);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(190, 50);
            this.playButton.TabIndex = 20;
            this.playButton.Text = "Пограти";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.Play);
            // 
            // feedButton
            // 
            this.feedButton.BackColor = System.Drawing.Color.Orange;
            this.feedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.feedButton.Font = new System.Drawing.Font("Ink Free", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedButton.Location = new System.Drawing.Point(400, 480);
            this.feedButton.Name = "feedButton";
            this.feedButton.Size = new System.Drawing.Size(180, 50);
            this.feedButton.TabIndex = 21;
            this.feedButton.Text = "Покормити";
            this.feedButton.UseVisualStyleBackColor = false;
            this.feedButton.Click += new System.EventHandler(this.Feed);
            // 
            // ShopButton
            // 
            this.ShopButton.BackgroundImage = global::My_Litle_WT.Properties.Resources.ShopIcon;
            this.ShopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShopButton.FlatAppearance.BorderSize = 0;
            this.ShopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopButton.Location = new System.Drawing.Point(10, 17);
            this.ShopButton.Name = "ShopButton";
            this.ShopButton.Size = new System.Drawing.Size(60, 60);
            this.ShopButton.TabIndex = 22;
            this.ShopButton.UseVisualStyleBackColor = true;
            this.ShopButton.Click += new System.EventHandler(this.ShopButton_Click);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Ink Free", 20F, System.Drawing.FontStyle.Bold);
            this.moneyLabel.Location = new System.Drawing.Point(516, 32);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(47, 34);
            this.moneyLabel.TabIndex = 23;
            this.moneyLabel.Text = "0$";
            this.moneyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Ink Free", 16F, System.Drawing.FontStyle.Bold);
            this.StatusLabel.Location = new System.Drawing.Point(260, 423);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 27);
            this.StatusLabel.TabIndex = 24;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // slotMachineIcon
            // 
            this.slotMachineIcon.BackgroundImage = global::My_Litle_WT.Properties.Resources.CasinoIcon;
            this.slotMachineIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.slotMachineIcon.FlatAppearance.BorderSize = 0;
            this.slotMachineIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slotMachineIcon.Location = new System.Drawing.Point(513, 93);
            this.slotMachineIcon.Name = "slotMachineIcon";
            this.slotMachineIcon.Size = new System.Drawing.Size(60, 60);
            this.slotMachineIcon.TabIndex = 25;
            this.slotMachineIcon.UseVisualStyleBackColor = true;
            this.slotMachineIcon.Click += new System.EventHandler(this.slotMachine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.slotMachineIcon);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.ShopButton);
            this.Controls.Add(this.feedButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.sleepButton);
            this.Controls.Add(this.teapot);
            this.Controls.Add(this.hungerBar);
            this.Controls.Add(this.hunger);
            this.Controls.Add(this.energyBar);
            this.Controls.Add(this.energy);
            this.Controls.Add(this.happinessBar);
            this.Controls.Add(this.happiness);
            this.Font = new System.Drawing.Font("Ink Free", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WT Tamagotchi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teapot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label happiness;
        private System.Windows.Forms.ProgressBar happinessBar;
        private System.Windows.Forms.ProgressBar energyBar;
        private System.Windows.Forms.Label energy;
        private System.Windows.Forms.ProgressBar hungerBar;
        private System.Windows.Forms.Label hunger;
        private System.Windows.Forms.PictureBox teapot;
        private System.Windows.Forms.Button sleepButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button feedButton;
        private System.Windows.Forms.Button ShopButton;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button slotMachineIcon;
    }
}

