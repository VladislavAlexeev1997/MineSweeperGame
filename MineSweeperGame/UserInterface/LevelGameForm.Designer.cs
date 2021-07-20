namespace MineSweeperGame.UserInterface
{
    partial class LevelGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelGameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.SelectButtonPictBox = new System.Windows.Forms.PictureBox();
            this.ProfessionalLevelButtonLabel = new System.Windows.Forms.Label();
            this.DevoteeLevelButtonLabel = new System.Windows.Forms.Label();
            this.NewalLevelButtonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelectButtonPictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Выберите уровень сложности\r\nигры\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectButtonPictBox
            // 
            this.SelectButtonPictBox.BackColor = System.Drawing.Color.Transparent;
            this.SelectButtonPictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectButtonPictBox.BackgroundImage")));
            this.SelectButtonPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectButtonPictBox.Location = new System.Drawing.Point(17, 121);
            this.SelectButtonPictBox.Name = "SelectButtonPictBox";
            this.SelectButtonPictBox.Size = new System.Drawing.Size(20, 20);
            this.SelectButtonPictBox.TabIndex = 8;
            this.SelectButtonPictBox.TabStop = false;
            this.SelectButtonPictBox.Visible = false;
            // 
            // ProfessionalLevelButtonLabel
            // 
            this.ProfessionalLevelButtonLabel.AutoSize = true;
            this.ProfessionalLevelButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProfessionalLevelButtonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfessionalLevelButtonLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfessionalLevelButtonLabel.ForeColor = System.Drawing.Color.Black;
            this.ProfessionalLevelButtonLabel.Location = new System.Drawing.Point(38, 168);
            this.ProfessionalLevelButtonLabel.Name = "ProfessionalLevelButtonLabel";
            this.ProfessionalLevelButtonLabel.Size = new System.Drawing.Size(151, 24);
            this.ProfessionalLevelButtonLabel.TabIndex = 7;
            this.ProfessionalLevelButtonLabel.Text = "Профессионал";
            this.ProfessionalLevelButtonLabel.Click += new System.EventHandler(this.ProfessionalLevelButtonLabelClick);
            this.ProfessionalLevelButtonLabel.MouseEnter += new System.EventHandler(this.ButtonLabelMouseEnter);
            this.ProfessionalLevelButtonLabel.MouseLeave += new System.EventHandler(this.ButtonLabelMouseLeave);
            // 
            // DevoteeLevelButtonLabel
            // 
            this.DevoteeLevelButtonLabel.AutoSize = true;
            this.DevoteeLevelButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.DevoteeLevelButtonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DevoteeLevelButtonLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevoteeLevelButtonLabel.ForeColor = System.Drawing.Color.Black;
            this.DevoteeLevelButtonLabel.Location = new System.Drawing.Point(38, 145);
            this.DevoteeLevelButtonLabel.Name = "DevoteeLevelButtonLabel";
            this.DevoteeLevelButtonLabel.Size = new System.Drawing.Size(107, 24);
            this.DevoteeLevelButtonLabel.TabIndex = 6;
            this.DevoteeLevelButtonLabel.Text = "Любитель";
            this.DevoteeLevelButtonLabel.Click += new System.EventHandler(this.DevoteeLevelButtonLabelClick);
            this.DevoteeLevelButtonLabel.MouseEnter += new System.EventHandler(this.ButtonLabelMouseEnter);
            this.DevoteeLevelButtonLabel.MouseLeave += new System.EventHandler(this.ButtonLabelMouseLeave);
            // 
            // NewalLevelButtonLabel
            // 
            this.NewalLevelButtonLabel.AutoSize = true;
            this.NewalLevelButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewalLevelButtonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewalLevelButtonLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewalLevelButtonLabel.ForeColor = System.Drawing.Color.Black;
            this.NewalLevelButtonLabel.Location = new System.Drawing.Point(38, 121);
            this.NewalLevelButtonLabel.Name = "NewalLevelButtonLabel";
            this.NewalLevelButtonLabel.Size = new System.Drawing.Size(94, 24);
            this.NewalLevelButtonLabel.TabIndex = 5;
            this.NewalLevelButtonLabel.Text = "Новичок";
            this.NewalLevelButtonLabel.Click += new System.EventHandler(this.NewalLevelButtonLabelClick);
            this.NewalLevelButtonLabel.MouseEnter += new System.EventHandler(this.ButtonLabelMouseEnter);
            this.NewalLevelButtonLabel.MouseLeave += new System.EventHandler(this.ButtonLabelMouseLeave);
            // 
            // LevelGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectButtonPictBox);
            this.Controls.Add(this.ProfessionalLevelButtonLabel);
            this.Controls.Add(this.DevoteeLevelButtonLabel);
            this.Controls.Add(this.NewalLevelButtonLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LevelGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сапер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LevelGameFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SelectButtonPictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox SelectButtonPictBox;
        private System.Windows.Forms.Label ProfessionalLevelButtonLabel;
        private System.Windows.Forms.Label DevoteeLevelButtonLabel;
        private System.Windows.Forms.Label NewalLevelButtonLabel;

    }
}