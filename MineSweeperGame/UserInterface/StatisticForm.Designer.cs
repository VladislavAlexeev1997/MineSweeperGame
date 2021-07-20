namespace MineSweeperGame.UserInterface
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            this.TimeLabel = new System.Windows.Forms.Label();
            this.WinGamesLabel = new System.Windows.Forms.Label();
            this.GamesCountLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatisticGroupBox = new System.Windows.Forms.GroupBox();
            this.NewalRadioButton = new System.Windows.Forms.RadioButton();
            this.DevoteeRadioButton = new System.Windows.Forms.RadioButton();
            this.ProfessionalRadioButton = new System.Windows.Forms.RadioButton();
            this.RestartButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.StatisticGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeLabel.Location = new System.Drawing.Point(129, 56);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(59, 15);
            this.TimeLabel.TabIndex = 31;
            this.TimeLabel.Text = "0";
            // 
            // WinGamesLabel
            // 
            this.WinGamesLabel.BackColor = System.Drawing.Color.Transparent;
            this.WinGamesLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinGamesLabel.Location = new System.Drawing.Point(129, 39);
            this.WinGamesLabel.Name = "WinGamesLabel";
            this.WinGamesLabel.Size = new System.Drawing.Size(59, 15);
            this.WinGamesLabel.TabIndex = 30;
            this.WinGamesLabel.Text = "0";
            // 
            // GamesCountLabel
            // 
            this.GamesCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.GamesCountLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GamesCountLabel.Location = new System.Drawing.Point(129, 22);
            this.GamesCountLabel.Name = "GamesCountLabel";
            this.GamesCountLabel.Size = new System.Drawing.Size(59, 13);
            this.GamesCountLabel.TabIndex = 29;
            this.GamesCountLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 51);
            this.label4.TabIndex = 26;
            this.label4.Text = "Проведено игр:\r\nВыиграно:\r\nЛучшее время:";
            // 
            // StatisticGroupBox
            // 
            this.StatisticGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.StatisticGroupBox.Controls.Add(this.label4);
            this.StatisticGroupBox.Controls.Add(this.GamesCountLabel);
            this.StatisticGroupBox.Controls.Add(this.WinGamesLabel);
            this.StatisticGroupBox.Controls.Add(this.TimeLabel);
            this.StatisticGroupBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticGroupBox.Location = new System.Drawing.Point(136, -1);
            this.StatisticGroupBox.Name = "StatisticGroupBox";
            this.StatisticGroupBox.Size = new System.Drawing.Size(200, 85);
            this.StatisticGroupBox.TabIndex = 38;
            this.StatisticGroupBox.TabStop = false;
            this.StatisticGroupBox.Text = "Новичок";
            // 
            // NewalRadioButton
            // 
            this.NewalRadioButton.AutoSize = true;
            this.NewalRadioButton.Checked = true;
            this.NewalRadioButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewalRadioButton.Location = new System.Drawing.Point(9, 10);
            this.NewalRadioButton.Name = "NewalRadioButton";
            this.NewalRadioButton.Size = new System.Drawing.Size(88, 21);
            this.NewalRadioButton.TabIndex = 39;
            this.NewalRadioButton.TabStop = true;
            this.NewalRadioButton.Text = "Новичок";
            this.NewalRadioButton.UseVisualStyleBackColor = true;
            this.NewalRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // DevoteeRadioButton
            // 
            this.DevoteeRadioButton.AutoSize = true;
            this.DevoteeRadioButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DevoteeRadioButton.Location = new System.Drawing.Point(9, 34);
            this.DevoteeRadioButton.Name = "DevoteeRadioButton";
            this.DevoteeRadioButton.Size = new System.Drawing.Size(97, 21);
            this.DevoteeRadioButton.TabIndex = 40;
            this.DevoteeRadioButton.Text = "Любитель";
            this.DevoteeRadioButton.UseVisualStyleBackColor = true;
            this.DevoteeRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // ProfessionalRadioButton
            // 
            this.ProfessionalRadioButton.AutoSize = true;
            this.ProfessionalRadioButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfessionalRadioButton.Location = new System.Drawing.Point(9, 58);
            this.ProfessionalRadioButton.Name = "ProfessionalRadioButton";
            this.ProfessionalRadioButton.Size = new System.Drawing.Size(127, 21);
            this.ProfessionalRadioButton.TabIndex = 41;
            this.ProfessionalRadioButton.Text = "Профессионал";
            this.ProfessionalRadioButton.UseVisualStyleBackColor = true;
            this.ProfessionalRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonCheckedChanged);
            // 
            // RestartButton
            // 
            this.RestartButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestartButton.Location = new System.Drawing.Point(12, 85);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(129, 26);
            this.RestartButton.TabIndex = 42;
            this.RestartButton.Text = "Сбросить данные";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButtonClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(256, 85);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(80, 26);
            this.CloseButton.TabIndex = 43;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(342, 114);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.ProfessionalRadioButton);
            this.Controls.Add(this.DevoteeRadioButton);
            this.Controls.Add(this.NewalRadioButton);
            this.Controls.Add(this.StatisticGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.StatisticGroupBox.ResumeLayout(false);
            this.StatisticGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label WinGamesLabel;
        private System.Windows.Forms.Label GamesCountLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox StatisticGroupBox;
        private System.Windows.Forms.RadioButton NewalRadioButton;
        private System.Windows.Forms.RadioButton DevoteeRadioButton;
        private System.Windows.Forms.RadioButton ProfessionalRadioButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button CloseButton;
    }
}