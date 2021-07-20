using System;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeperGame.UserInterface
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void ButtonLabelMouseEnter(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.White;
            SelectButtonPictBox.Location = new Point((sender as Label).Location.X - 20, (sender as Label).Location.Y);
            SelectButtonPictBox.Visible = true;
        }

        private void ButtonLabelMouseLeave(object sender, EventArgs e)
        {
            (sender as Label).ForeColor = Color.Black;
            SelectButtonPictBox.Visible = false;
        }

        private void NewGameButtonLabelClick(object sender, EventArgs e)
        {
            LevelGameForm levelGameForm = new LevelGameForm();
            levelGameForm.Show();
            Hide();
        }

        private void StatisticGameButtonLabelClick(object sender, EventArgs e)
        {
            StatisticForm statisticForm = new StatisticForm();
            statisticForm.Show();
        }

        private void ExitButtonLabelClick(object sender, EventArgs e)
        {
            Close();
        }

        private void MainMenuFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }
    }
}