namespace MineSweeperGame.UserInterface
{
    partial class GameForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.FieldPanel = new System.Windows.Forms.Panel();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NewalLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DevoteeLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfessionalLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlagCountPanel = new System.Windows.Forms.Panel();
            this.TimeCountPanel = new System.Windows.Forms.Panel();
            this.FirstTimeCountPictBox = new System.Windows.Forms.PictureBox();
            this.SecondTimeCountPictBox = new System.Windows.Forms.PictureBox();
            this.ThirdTimeCountPictBox = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ThirdFlagCountPictBox = new System.Windows.Forms.PictureBox();
            this.SecondFlagCountPictBox = new System.Windows.Forms.PictureBox();
            this.FirstFlagCountPictBox = new System.Windows.Forms.PictureBox();
            this.LeftLinePictBox = new System.Windows.Forms.PictureBox();
            this.RightLinePictBox = new System.Windows.Forms.PictureBox();
            this.UnderLinePictBox = new System.Windows.Forms.PictureBox();
            this.DownLinePictBox = new System.Windows.Forms.PictureBox();
            this.MiddleLinePictBox = new System.Windows.Forms.PictureBox();
            this.StatusGameProcessButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.FlagCountPanel.SuspendLayout();
            this.TimeCountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FirstTimeCountPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondTimeCountPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdTimeCountPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdFlagCountPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondFlagCountPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstFlagCountPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLinePictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLinePictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderLinePictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLinePictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleLinePictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FieldPanel
            // 
            this.FieldPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FieldPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.FieldPanel.Location = new System.Drawing.Point(13, 69);
            this.FieldPanel.Name = "FieldPanel";
            this.FieldPanel.Size = new System.Drawing.Size(189, 189);
            this.FieldPanel.TabIndex = 0;
            this.FieldPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FieldPanelControlAdded);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(214, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGameToolStripMenuItem,
            this.toolStripSeparator1,
            this.NewalLevelToolStripMenuItem,
            this.DevoteeLevelToolStripMenuItem,
            this.ProfessionalLevelToolStripMenuItem,
            this.toolStripSeparator2,
            this.ToneToolStripMenuItem,
            this.StatisticToolStripMenuItem,
            this.toolStripSeparator3,
            this.ExitGameToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // NewGameToolStripMenuItem
            // 
            this.NewGameToolStripMenuItem.Name = "NewGameToolStripMenuItem";
            this.NewGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.NewGameToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.NewGameToolStripMenuItem.Text = "Новая игра";
            this.NewGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItemClick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // NewalLevelToolStripMenuItem
            // 
            this.NewalLevelToolStripMenuItem.Checked = true;
            this.NewalLevelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.NewalLevelToolStripMenuItem.Name = "NewalLevelToolStripMenuItem";
            this.NewalLevelToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.NewalLevelToolStripMenuItem.Text = "Новичок";
            this.NewalLevelToolStripMenuItem.Click += new System.EventHandler(this.NewalLevelToolStripMenuItemClick);
            // 
            // DevoteeLevelToolStripMenuItem
            // 
            this.DevoteeLevelToolStripMenuItem.Name = "DevoteeLevelToolStripMenuItem";
            this.DevoteeLevelToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.DevoteeLevelToolStripMenuItem.Text = "Любитель";
            this.DevoteeLevelToolStripMenuItem.Click += new System.EventHandler(this.DevoteeLevelToolStripMenuItemClick);
            // 
            // ProfessionalLevelToolStripMenuItem
            // 
            this.ProfessionalLevelToolStripMenuItem.Name = "ProfessionalLevelToolStripMenuItem";
            this.ProfessionalLevelToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ProfessionalLevelToolStripMenuItem.Text = "Профессионал";
            this.ProfessionalLevelToolStripMenuItem.Click += new System.EventHandler(this.ProfessionalLevelToolStripMenuItemClick);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // ToneToolStripMenuItem
            // 
            this.ToneToolStripMenuItem.Name = "ToneToolStripMenuItem";
            this.ToneToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ToneToolStripMenuItem.Text = "Звук";
            this.ToneToolStripMenuItem.Click += new System.EventHandler(this.ToneToolStripMenuItemClick);
            // 
            // StatisticToolStripMenuItem
            // 
            this.StatisticToolStripMenuItem.Name = "StatisticToolStripMenuItem";
            this.StatisticToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.StatisticToolStripMenuItem.Text = "Статистика";
            this.StatisticToolStripMenuItem.Click += new System.EventHandler(this.StatisticToolStripMenuItemClick);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // ExitGameToolStripMenuItem
            // 
            this.ExitGameToolStripMenuItem.Name = "ExitGameToolStripMenuItem";
            this.ExitGameToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.ExitGameToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.ExitGameToolStripMenuItem.Text = "Завершить игру";
            this.ExitGameToolStripMenuItem.Click += new System.EventHandler(this.ExitGameToolStripMenuItemClick);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.AboutToolStripMenuItem.Text = "Об игре";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // FlagCountPanel
            // 
            this.FlagCountPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FlagCountPanel.Controls.Add(this.pictureBox7);
            this.FlagCountPanel.Controls.Add(this.ThirdFlagCountPictBox);
            this.FlagCountPanel.Controls.Add(this.SecondFlagCountPictBox);
            this.FlagCountPanel.Controls.Add(this.FirstFlagCountPictBox);
            this.FlagCountPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.FlagCountPanel.Location = new System.Drawing.Point(9, 29);
            this.FlagCountPanel.Name = "FlagCountPanel";
            this.FlagCountPanel.Size = new System.Drawing.Size(76, 31);
            this.FlagCountPanel.TabIndex = 19;
            // 
            // TimeCountPanel
            // 
            this.TimeCountPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TimeCountPanel.Controls.Add(this.FirstTimeCountPictBox);
            this.TimeCountPanel.Controls.Add(this.SecondTimeCountPictBox);
            this.TimeCountPanel.Controls.Add(this.ThirdTimeCountPictBox);
            this.TimeCountPanel.Controls.Add(this.pictureBox8);
            this.TimeCountPanel.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TimeCountPanel.Location = new System.Drawing.Point(131, 29);
            this.TimeCountPanel.Name = "TimeCountPanel";
            this.TimeCountPanel.Size = new System.Drawing.Size(76, 31);
            this.TimeCountPanel.TabIndex = 20;
            // 
            // FirstTimeCountPictBox
            // 
            this.FirstTimeCountPictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstTimeCountPictBox.BackgroundImage")));
            this.FirstTimeCountPictBox.Location = new System.Drawing.Point(5, 5);
            this.FirstTimeCountPictBox.Name = "FirstTimeCountPictBox";
            this.FirstTimeCountPictBox.Size = new System.Drawing.Size(14, 23);
            this.FirstTimeCountPictBox.TabIndex = 1;
            this.FirstTimeCountPictBox.TabStop = false;
            // 
            // SecondTimeCountPictBox
            // 
            this.SecondTimeCountPictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SecondTimeCountPictBox.BackgroundImage")));
            this.SecondTimeCountPictBox.Location = new System.Drawing.Point(19, 5);
            this.SecondTimeCountPictBox.Name = "SecondTimeCountPictBox";
            this.SecondTimeCountPictBox.Size = new System.Drawing.Size(14, 23);
            this.SecondTimeCountPictBox.TabIndex = 2;
            this.SecondTimeCountPictBox.TabStop = false;
            // 
            // ThirdTimeCountPictBox
            // 
            this.ThirdTimeCountPictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ThirdTimeCountPictBox.BackgroundImage")));
            this.ThirdTimeCountPictBox.Location = new System.Drawing.Point(33, 5);
            this.ThirdTimeCountPictBox.Name = "ThirdTimeCountPictBox";
            this.ThirdTimeCountPictBox.Size = new System.Drawing.Size(14, 23);
            this.ThirdTimeCountPictBox.TabIndex = 3;
            this.ThirdTimeCountPictBox.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox8.Location = new System.Drawing.Point(50, 4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(22, 22);
            this.pictureBox8.TabIndex = 9;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(3, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(22, 22);
            this.pictureBox7.TabIndex = 8;
            this.pictureBox7.TabStop = false;
            // 
            // ThirdFlagCountPictBox
            // 
            this.ThirdFlagCountPictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ThirdFlagCountPictBox.BackgroundImage")));
            this.ThirdFlagCountPictBox.Location = new System.Drawing.Point(57, 5);
            this.ThirdFlagCountPictBox.Name = "ThirdFlagCountPictBox";
            this.ThirdFlagCountPictBox.Size = new System.Drawing.Size(14, 23);
            this.ThirdFlagCountPictBox.TabIndex = 5;
            this.ThirdFlagCountPictBox.TabStop = false;
            // 
            // SecondFlagCountPictBox
            // 
            this.SecondFlagCountPictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SecondFlagCountPictBox.BackgroundImage")));
            this.SecondFlagCountPictBox.Location = new System.Drawing.Point(43, 5);
            this.SecondFlagCountPictBox.Name = "SecondFlagCountPictBox";
            this.SecondFlagCountPictBox.Size = new System.Drawing.Size(14, 23);
            this.SecondFlagCountPictBox.TabIndex = 6;
            this.SecondFlagCountPictBox.TabStop = false;
            // 
            // FirstFlagCountPictBox
            // 
            this.FirstFlagCountPictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FirstFlagCountPictBox.BackgroundImage")));
            this.FirstFlagCountPictBox.Location = new System.Drawing.Point(29, 5);
            this.FirstFlagCountPictBox.Name = "FirstFlagCountPictBox";
            this.FirstFlagCountPictBox.Size = new System.Drawing.Size(14, 23);
            this.FirstFlagCountPictBox.TabIndex = 7;
            this.FirstFlagCountPictBox.TabStop = false;
            // 
            // LeftLinePictBox
            // 
            this.LeftLinePictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftLinePictBox.BackgroundImage")));
            this.LeftLinePictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftLinePictBox.Location = new System.Drawing.Point(4, 29);
            this.LeftLinePictBox.Name = "LeftLinePictBox";
            this.LeftLinePictBox.Size = new System.Drawing.Size(4, 235);
            this.LeftLinePictBox.TabIndex = 17;
            this.LeftLinePictBox.TabStop = false;
            // 
            // RightLinePictBox
            // 
            this.RightLinePictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightLinePictBox.BackgroundImage")));
            this.RightLinePictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightLinePictBox.Location = new System.Drawing.Point(207, 29);
            this.RightLinePictBox.Name = "RightLinePictBox";
            this.RightLinePictBox.Size = new System.Drawing.Size(4, 235);
            this.RightLinePictBox.TabIndex = 16;
            this.RightLinePictBox.TabStop = false;
            // 
            // UnderLinePictBox
            // 
            this.UnderLinePictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UnderLinePictBox.BackgroundImage")));
            this.UnderLinePictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UnderLinePictBox.Location = new System.Drawing.Point(4, 25);
            this.UnderLinePictBox.Name = "UnderLinePictBox";
            this.UnderLinePictBox.Size = new System.Drawing.Size(207, 4);
            this.UnderLinePictBox.TabIndex = 15;
            this.UnderLinePictBox.TabStop = false;
            // 
            // DownLinePictBox
            // 
            this.DownLinePictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownLinePictBox.BackgroundImage")));
            this.DownLinePictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownLinePictBox.Location = new System.Drawing.Point(4, 263);
            this.DownLinePictBox.Name = "DownLinePictBox";
            this.DownLinePictBox.Size = new System.Drawing.Size(207, 4);
            this.DownLinePictBox.TabIndex = 13;
            this.DownLinePictBox.TabStop = false;
            // 
            // MiddleLinePictBox
            // 
            this.MiddleLinePictBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MiddleLinePictBox.BackgroundImage")));
            this.MiddleLinePictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MiddleLinePictBox.Location = new System.Drawing.Point(8, 61);
            this.MiddleLinePictBox.Name = "MiddleLinePictBox";
            this.MiddleLinePictBox.Size = new System.Drawing.Size(199, 4);
            this.MiddleLinePictBox.TabIndex = 12;
            this.MiddleLinePictBox.TabStop = false;
            // 
            // StatusGameProcessButton
            // 
            this.StatusGameProcessButton.BackgroundImage = global::MineSweeperGame.Properties.Resources.StatusGameProcessStart;
            this.StatusGameProcessButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StatusGameProcessButton.Location = new System.Drawing.Point(94, 32);
            this.StatusGameProcessButton.Name = "StatusGameProcessButton";
            this.StatusGameProcessButton.Size = new System.Drawing.Size(27, 27);
            this.StatusGameProcessButton.TabIndex = 0;
            this.StatusGameProcessButton.TabStop = false;
            this.StatusGameProcessButton.UseVisualStyleBackColor = true;
            this.StatusGameProcessButton.Click += new System.EventHandler(this.StatusGameProcessButtonClick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(214, 271);
            this.Controls.Add(this.TimeCountPanel);
            this.Controls.Add(this.FlagCountPanel);
            this.Controls.Add(this.LeftLinePictBox);
            this.Controls.Add(this.RightLinePictBox);
            this.Controls.Add(this.UnderLinePictBox);
            this.Controls.Add(this.DownLinePictBox);
            this.Controls.Add(this.MiddleLinePictBox);
            this.Controls.Add(this.StatusGameProcessButton);
            this.Controls.Add(this.FieldPanel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сапер";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameFormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FlagCountPanel.ResumeLayout(false);
            this.TimeCountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FirstTimeCountPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondTimeCountPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdTimeCountPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdFlagCountPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondFlagCountPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstFlagCountPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftLinePictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightLinePictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnderLinePictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownLinePictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MiddleLinePictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FieldPanel;
        private System.Windows.Forms.PictureBox FirstTimeCountPictBox;
        private System.Windows.Forms.PictureBox SecondTimeCountPictBox;
        private System.Windows.Forms.PictureBox ThirdTimeCountPictBox;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Button StatusGameProcessButton;
        private System.Windows.Forms.PictureBox FirstFlagCountPictBox;
        private System.Windows.Forms.PictureBox SecondFlagCountPictBox;
        private System.Windows.Forms.PictureBox ThirdFlagCountPictBox;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox MiddleLinePictBox;
        private System.Windows.Forms.PictureBox DownLinePictBox;
        private System.Windows.Forms.PictureBox UnderLinePictBox;
        private System.Windows.Forms.PictureBox RightLinePictBox;
        private System.Windows.Forms.PictureBox LeftLinePictBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Panel FlagCountPanel;
        private System.Windows.Forms.Panel TimeCountPanel;
        private System.Windows.Forms.ToolStripMenuItem NewGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem NewalLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DevoteeLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfessionalLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatisticToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem ExitGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;

    }
}

