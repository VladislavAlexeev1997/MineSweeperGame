namespace MineSweeperGame.UserInterface
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectButtonPictBox = new System.Windows.Forms.PictureBox();
            this.ExitButtonLabel = new System.Windows.Forms.Label();
            this.StatisticGameButtonLabel = new System.Windows.Forms.Label();
            this.NewGameButtonLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectButtonPictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.SelectButtonPictBox);
            this.panel1.Controls.Add(this.ExitButtonLabel);
            this.panel1.Controls.Add(this.StatisticGameButtonLabel);
            this.panel1.Controls.Add(this.NewGameButtonLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 238);
            this.panel1.TabIndex = 0;
            // 
            // SelectButtonPictBox
            // 
            this.SelectButtonPictBox.BackColor = System.Drawing.Color.Transparent;
            this.SelectButtonPictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectButtonPictBox.BackgroundImage")));
            this.SelectButtonPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SelectButtonPictBox.Location = new System.Drawing.Point(12, 69);
            this.SelectButtonPictBox.Name = "SelectButtonPictBox";
            this.SelectButtonPictBox.Size = new System.Drawing.Size(20, 20);
            this.SelectButtonPictBox.TabIndex = 3;
            this.SelectButtonPictBox.TabStop = false;
            this.SelectButtonPictBox.Visible = false;
            // 
            // ExitButtonLabel
            // 
            this.ExitButtonLabel.AutoSize = true;
            this.ExitButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExitButtonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButtonLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButtonLabel.ForeColor = System.Drawing.Color.Black;
            this.ExitButtonLabel.Location = new System.Drawing.Point(33, 116);
            this.ExitButtonLabel.Name = "ExitButtonLabel";
            this.ExitButtonLabel.Size = new System.Drawing.Size(71, 24);
            this.ExitButtonLabel.TabIndex = 2;
            this.ExitButtonLabel.Text = "Выход";
            this.ExitButtonLabel.Click += new System.EventHandler(this.ExitButtonLabelClick);
            this.ExitButtonLabel.MouseEnter += new System.EventHandler(this.ButtonLabelMouseEnter);
            this.ExitButtonLabel.MouseLeave += new System.EventHandler(this.ButtonLabelMouseLeave);
            // 
            // StatisticGameButtonLabel
            // 
            this.StatisticGameButtonLabel.AutoSize = true;
            this.StatisticGameButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatisticGameButtonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatisticGameButtonLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatisticGameButtonLabel.ForeColor = System.Drawing.Color.Black;
            this.StatisticGameButtonLabel.Location = new System.Drawing.Point(33, 93);
            this.StatisticGameButtonLabel.Name = "StatisticGameButtonLabel";
            this.StatisticGameButtonLabel.Size = new System.Drawing.Size(119, 24);
            this.StatisticGameButtonLabel.TabIndex = 1;
            this.StatisticGameButtonLabel.Text = "Статистика";
            this.StatisticGameButtonLabel.Click += new System.EventHandler(this.StatisticGameButtonLabelClick);
            this.StatisticGameButtonLabel.MouseEnter += new System.EventHandler(this.ButtonLabelMouseEnter);
            this.StatisticGameButtonLabel.MouseLeave += new System.EventHandler(this.ButtonLabelMouseLeave);
            // 
            // NewGameButtonLabel
            // 
            this.NewGameButtonLabel.AutoSize = true;
            this.NewGameButtonLabel.BackColor = System.Drawing.Color.Transparent;
            this.NewGameButtonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewGameButtonLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGameButtonLabel.ForeColor = System.Drawing.Color.Black;
            this.NewGameButtonLabel.Location = new System.Drawing.Point(33, 68);
            this.NewGameButtonLabel.Name = "NewGameButtonLabel";
            this.NewGameButtonLabel.Size = new System.Drawing.Size(118, 24);
            this.NewGameButtonLabel.TabIndex = 0;
            this.NewGameButtonLabel.Text = "Новая игра";
            this.NewGameButtonLabel.Click += new System.EventHandler(this.NewGameButtonLabelClick);
            this.NewGameButtonLabel.MouseEnter += new System.EventHandler(this.ButtonLabelMouseEnter);
            this.NewGameButtonLabel.MouseLeave += new System.EventHandler(this.ButtonLabelMouseLeave);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 238);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сапер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenuFormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SelectButtonPictBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox SelectButtonPictBox;
        private System.Windows.Forms.Label ExitButtonLabel;
        private System.Windows.Forms.Label StatisticGameButtonLabel;
        private System.Windows.Forms.Label NewGameButtonLabel;
    }
}