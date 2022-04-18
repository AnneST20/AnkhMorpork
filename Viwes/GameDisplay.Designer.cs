namespace AnkhMorpork
{
    partial class GameDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameDisplay));
            this.pictureBoxFrame = new System.Windows.Forms.PictureBox();
            this.pictureBoxGuild = new System.Windows.Forms.PictureBox();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.buttonMove = new System.Windows.Forms.Button();
            this.panelInventory = new System.Windows.Forms.Panel();
            this.pictureBoxSilver = new System.Windows.Forms.PictureBox();
            this.labelSilver = new System.Windows.Forms.Label();
            this.pictureBoxBeer = new System.Windows.Forms.PictureBox();
            this.pictureBoxGold = new System.Windows.Forms.PictureBox();
            this.labelBeer = new System.Windows.Forms.Label();
            this.labelGold = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelMeetGuild = new System.Windows.Forms.Label();
            this.numericAssassinReward = new System.Windows.Forms.NumericUpDown();
            this.labelStep = new System.Windows.Forms.Label();
            this.labelGuildInfo = new System.Windows.Forms.Label();
            this.labelPreviousStep = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuild)).BeginInit();
            this.panelInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSilver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAssassinReward)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFrame
            // 
            this.pictureBoxFrame.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFrame.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFrame.Image")));
            this.pictureBoxFrame.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFrame.Name = "pictureBoxFrame";
            this.pictureBoxFrame.Size = new System.Drawing.Size(460, 605);
            this.pictureBoxFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFrame.TabIndex = 1;
            this.pictureBoxFrame.TabStop = false;
            // 
            // pictureBoxGuild
            // 
            this.pictureBoxGuild.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGuild.Image")));
            this.pictureBoxGuild.Location = new System.Drawing.Point(56, 51);
            this.pictureBoxGuild.Name = "pictureBoxGuild";
            this.pictureBoxGuild.Size = new System.Drawing.Size(367, 517);
            this.pictureBoxGuild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGuild.TabIndex = 2;
            this.pictureBoxGuild.TabStop = false;
            // 
            // buttonSkip
            // 
            this.buttonSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSkip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSkip.Location = new System.Drawing.Point(492, 618);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(278, 56);
            this.buttonSkip.TabIndex = 3;
            this.buttonSkip.Text = "Skip";
            this.buttonSkip.UseVisualStyleBackColor = false;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // buttonMove
            // 
            this.buttonMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonMove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMove.Location = new System.Drawing.Point(776, 618);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(276, 56);
            this.buttonMove.TabIndex = 4;
            this.buttonMove.Text = "Yes";
            this.buttonMove.UseVisualStyleBackColor = false;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // panelInventory
            // 
            this.panelInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelInventory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInventory.Controls.Add(this.pictureBoxSilver);
            this.panelInventory.Controls.Add(this.labelSilver);
            this.panelInventory.Controls.Add(this.pictureBoxBeer);
            this.panelInventory.Controls.Add(this.pictureBoxGold);
            this.panelInventory.Controls.Add(this.labelBeer);
            this.panelInventory.Controls.Add(this.labelGold);
            this.panelInventory.Controls.Add(this.labelInventory);
            this.panelInventory.ForeColor = System.Drawing.SystemColors.Control;
            this.panelInventory.Location = new System.Drawing.Point(12, 623);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Size = new System.Drawing.Size(460, 51);
            this.panelInventory.TabIndex = 5;
            // 
            // pictureBoxSilver
            // 
            this.pictureBoxSilver.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSilver.Image")));
            this.pictureBoxSilver.Location = new System.Drawing.Point(322, 2);
            this.pictureBoxSilver.Name = "pictureBoxSilver";
            this.pictureBoxSilver.Size = new System.Drawing.Size(34, 38);
            this.pictureBoxSilver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSilver.TabIndex = 12;
            this.pictureBoxSilver.TabStop = false;
            // 
            // labelSilver
            // 
            this.labelSilver.AutoSize = true;
            this.labelSilver.Location = new System.Drawing.Point(280, 4);
            this.labelSilver.Name = "labelSilver";
            this.labelSilver.Size = new System.Drawing.Size(51, 36);
            this.labelSilver.TabIndex = 11;
            this.labelSilver.Text = "00";
            this.labelSilver.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxBeer
            // 
            this.pictureBoxBeer.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBeer.Image")));
            this.pictureBoxBeer.Location = new System.Drawing.Point(410, 5);
            this.pictureBoxBeer.Name = "pictureBoxBeer";
            this.pictureBoxBeer.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxBeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBeer.TabIndex = 10;
            this.pictureBoxBeer.TabStop = false;
            // 
            // pictureBoxGold
            // 
            this.pictureBoxGold.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGold.Image")));
            this.pictureBoxGold.Location = new System.Drawing.Point(231, 2);
            this.pictureBoxGold.Name = "pictureBoxGold";
            this.pictureBoxGold.Size = new System.Drawing.Size(32, 39);
            this.pictureBoxGold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGold.TabIndex = 6;
            this.pictureBoxGold.TabStop = false;
            // 
            // labelBeer
            // 
            this.labelBeer.AutoSize = true;
            this.labelBeer.Location = new System.Drawing.Point(387, 6);
            this.labelBeer.Name = "labelBeer";
            this.labelBeer.Size = new System.Drawing.Size(33, 36);
            this.labelBeer.TabIndex = 9;
            this.labelBeer.Text = "0";
            // 
            // labelGold
            // 
            this.labelGold.AutoSize = true;
            this.labelGold.Location = new System.Drawing.Point(176, 5);
            this.labelGold.Name = "labelGold";
            this.labelGold.Size = new System.Drawing.Size(61, 36);
            this.labelGold.TabIndex = 7;
            this.labelGold.Text = "100";
            this.labelGold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Location = new System.Drawing.Point(3, 4);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(150, 36);
            this.labelInventory.TabIndex = 6;
            this.labelInventory.Text = "Inventory: ";
            // 
            // labelMeetGuild
            // 
            this.labelMeetGuild.BackColor = System.Drawing.Color.Transparent;
            this.labelMeetGuild.Font = new System.Drawing.Font("Matura MT Script Capitals", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMeetGuild.Location = new System.Drawing.Point(478, 261);
            this.labelMeetGuild.Name = "labelMeetGuild";
            this.labelMeetGuild.Size = new System.Drawing.Size(574, 50);
            this.labelMeetGuild.TabIndex = 6;
            this.labelMeetGuild.Text = "You meet Assassins\' Guild!";
            this.labelMeetGuild.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericAssassinReward
            // 
            this.numericAssassinReward.BackColor = System.Drawing.SystemColors.Info;
            this.numericAssassinReward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.numericAssassinReward.Location = new System.Drawing.Point(492, 569);
            this.numericAssassinReward.Name = "numericAssassinReward";
            this.numericAssassinReward.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericAssassinReward.Size = new System.Drawing.Size(560, 43);
            this.numericAssassinReward.TabIndex = 7;
            this.numericAssassinReward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericAssassinReward.Visible = false;
            // 
            // labelStep
            // 
            this.labelStep.BackColor = System.Drawing.Color.Transparent;
            this.labelStep.Font = new System.Drawing.Font("Matura MT Script Capitals", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStep.Location = new System.Drawing.Point(478, 199);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(574, 50);
            this.labelStep.TabIndex = 8;
            this.labelStep.Text = "Step: ";
            this.labelStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGuildInfo
            // 
            this.labelGuildInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelGuildInfo.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.labelGuildInfo.Location = new System.Drawing.Point(481, 339);
            this.labelGuildInfo.Name = "labelGuildInfo";
            this.labelGuildInfo.Size = new System.Drawing.Size(571, 210);
            this.labelGuildInfo.TabIndex = 9;
            this.labelGuildInfo.Text = "labelGuildInfo";
            this.labelGuildInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPreviousStep
            // 
            this.labelPreviousStep.BackColor = System.Drawing.Color.Transparent;
            this.labelPreviousStep.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelPreviousStep.Location = new System.Drawing.Point(481, 12);
            this.labelPreviousStep.Name = "labelPreviousStep";
            this.labelPreviousStep.Size = new System.Drawing.Size(571, 170);
            this.labelPreviousStep.TabIndex = 10;
            this.labelPreviousStep.Text = "labelPreviousStep";
            this.labelPreviousStep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.labelPreviousStep);
            this.Controls.Add(this.labelGuildInfo);
            this.Controls.Add(this.labelStep);
            this.Controls.Add(this.numericAssassinReward);
            this.Controls.Add(this.labelMeetGuild);
            this.Controls.Add(this.panelInventory);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.pictureBoxGuild);
            this.Controls.Add(this.pictureBoxFrame);
            this.Font = new System.Drawing.Font("Matura MT Script Capitals", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.MaximumSize = new System.Drawing.Size(1080, 720);
            this.MinimumSize = new System.Drawing.Size(1080, 720);
            this.Name = "GameDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameDisplay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameDisplay_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuild)).EndInit();
            this.panelInventory.ResumeLayout(false);
            this.panelInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSilver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAssassinReward)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFrame;
        private System.Windows.Forms.PictureBox pictureBoxGuild;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.Panel panelInventory;
        private System.Windows.Forms.Label labelBeer;
        private System.Windows.Forms.Label labelGold;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.PictureBox pictureBoxBeer;
        private System.Windows.Forms.PictureBox pictureBoxGold;
        private System.Windows.Forms.Label labelMeetGuild;
        private System.Windows.Forms.NumericUpDown numericAssassinReward;
        private System.Windows.Forms.Label labelStep;
        public System.Windows.Forms.Label labelGuildInfo;
        private System.Windows.Forms.PictureBox pictureBoxSilver;
        private System.Windows.Forms.Label labelSilver;
        public System.Windows.Forms.Label labelPreviousStep;
    }
}