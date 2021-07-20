using System;
using System.Drawing;
using System.Windows.Forms;
using MineSweeperGame.Classes;

namespace MineSweeperGame.UserInterface
{
    public partial class LevelGameForm : Form
    {
        public LevelGameForm()
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

        private void NewalLevelButtonLabelClick(object sender, EventArgs e)
        {
            OpenNewGame(LevelGame.Newal);
        }

        private void DevoteeLevelButtonLabelClick(object sender, EventArgs e)
        {
            OpenNewGame(LevelGame.Devotee);
        }

        private void ProfessionalLevelButtonLabelClick(object sender, EventArgs e)
        {
            OpenNewGame(LevelGame.Professional);
        }

        private void OpenNewGame(LevelGame newLevelGame)
        {
            GameForm gameForm = new GameForm(newLevelGame);
            gameForm.Show();
            Hide();
        }

        private void LevelGameFormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            Hide();
        }
    }
}