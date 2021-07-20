using System;
using System.Drawing;
using System.Windows.Forms;
using MineSweeperGame.Classes;

namespace MineSweeperGame.UserInterface
{
    public partial class GameForm : Form
    {
        readonly Game game;

        public GameForm(LevelGame newLevelGame)
        {
            InitializeComponent();
            game = new Game(newLevelGame);
            NewGame();
            StatusMenuCheckLevel(newLevelGame);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            game.TimeProcessGame(FirstTimeCountPictBox, SecondTimeCountPictBox, ThirdTimeCountPictBox);
        }

        private void StatusGameProcessButtonClick(object sender, EventArgs e)
        {
            NewGame();
        }

        private void NewGameToolStripMenuItemClick(object sender, EventArgs e)
        {
            StatusGameProcessButtonClick(sender, e);
        }

        private void GameFormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
            Hide();
        }

        private void ExitGameToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ToneToolStripMenuItemClick(object sender, EventArgs e)
        {
            game.tonePlayGame = !game.tonePlayGame;
            if (game.tonePlayGame)
            {
                ToneToolStripMenuItem.CheckState = CheckState.Checked;
            }
            else
            {
                ToneToolStripMenuItem.CheckState = CheckState.Unchecked;
            }
        }

        private void NewalLevelToolStripMenuItemClick(object sender, EventArgs e)
        {
            CheckLevel(LevelGame.Newal);
        }

        private void DevoteeLevelToolStripMenuItemClick(object sender, EventArgs e)
        {
            CheckLevel(LevelGame.Devotee);
        }

        private void ProfessionalLevelToolStripMenuItemClick(object sender, EventArgs e)
        {
            CheckLevel(LevelGame.Professional);
        }

        private void CheckLevel(LevelGame newLevelGame)
        {
            if (game.levelGame != newLevelGame)
            {
                game.levelGame = newLevelGame;
                StatusMenuCheckLevel(game.levelGame);
                NewGame();
            }
        }

        private void StatisticToolStripMenuItemClick(object sender, EventArgs e)
        {
            StatisticForm statisticForm = new StatisticForm();
            statisticForm.Show();
        }

        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            helpForm.Show();
        }

        private void NewGame()
        {
            GameTimer.Enabled = false;
            FieldPanel.Controls.Clear();
            game.NewGame(FirstTimeCountPictBox, SecondTimeCountPictBox, ThirdTimeCountPictBox);
            PaintGameField();
            StatusGameProcessButton.BackgroundImage = Properties.Resources.StatusGameProcessStart;
            StatusGameProcessButton.BackgroundImageLayout = ImageLayout.Stretch;
            game.PictureFlagCounter(FirstFlagCountPictBox, SecondFlagCountPictBox, ThirdFlagCountPictBox);
        }

        private void PaintGameField()
        {
            UnderLinePictBox.Size = new Size(21 * game.colFieldGame + 18, 4);
            MiddleLinePictBox.Size = new Size(21 * game.colFieldGame + 10, 4);
            DownLinePictBox.Size = new Size(21 * game.colFieldGame + 18, 4);
            LeftLinePictBox.Size = new Size(4, 21 * game.rowFieldGame + 46);
            RightLinePictBox.Size = new Size(4, 21 * game.rowFieldGame + 46);
            StatusGameProcessButton.Location = new Point(21 * game.colFieldGame / 2, 32);
            switch (game.levelGame)
            {
                case LevelGame.Newal:
                    PaintElementLevelGameField(new Size(230, 310), 263, 207, 130);
                    break;
                case LevelGame.Devotee:
                    PaintElementLevelGameField(new Size(377, 458), 411, 354, 277);
                    break;
                default:
                    PaintElementLevelGameField(new Size(672, 458), 411, 648, 571);
                    break;
            }
            game.fieldGameMineSweeper.DrawField(FieldPanel);
        }

        private void PaintElementLevelGameField(Size sizeForm, int yDownLine, int xRightLine, int xTimeCount)
        {
            Size = sizeForm;
            DownLinePictBox.Location = new Point(4, yDownLine);
            RightLinePictBox.Location = new Point(xRightLine, 29);
            TimeCountPanel.Location = new Point(xTimeCount, 29);
        }

        private void StatusMenuCheckLevel(LevelGame nowLevel)
        {
            switch (nowLevel)
            {
                case LevelGame.Newal:
                    NewalLevelToolStripMenuItem.CheckState = CheckState.Checked;
                    DevoteeLevelToolStripMenuItem.CheckState = CheckState.Unchecked;
                    ProfessionalLevelToolStripMenuItem.CheckState = CheckState.Unchecked;
                    break;
                case LevelGame.Devotee:
                    NewalLevelToolStripMenuItem.CheckState = CheckState.Unchecked;
                    DevoteeLevelToolStripMenuItem.CheckState = CheckState.Checked;
                    ProfessionalLevelToolStripMenuItem.CheckState = CheckState.Unchecked;
                    break;
                default:
                    NewalLevelToolStripMenuItem.CheckState = CheckState.Unchecked;
                    DevoteeLevelToolStripMenuItem.CheckState = CheckState.Unchecked;
                    ProfessionalLevelToolStripMenuItem.CheckState = CheckState.Checked;
                    break;
            }
        }

        private void FieldPanelControlAdded(object sender, ControlEventArgs e)
        {
            e.Control.MouseUp += FieldButtonMouseUp;
            e.Control.MouseDown += FieldButtonMouseDown;
        }

        private void FieldButtonMouseDown(object sender, MouseEventArgs e)
        {
            SelectNextControl(null, false, false, false, false);
            game.PictureFlagCounter(FirstFlagCountPictBox, SecondFlagCountPictBox, ThirdFlagCountPictBox);
            if (e.Button == MouseButtons.Left)
            {
                if (game.fieldGameMineSweeper.statusGame == StatusGame.Process)
                {
                    StatusGameProcessButton.BackgroundImage = Properties.Resources.StatusGameProcessPress;
                    StatusGameProcessButton.BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void FieldButtonMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((game.fieldGameMineSweeper.statusGame == StatusGame.Win) && (GameTimer.Enabled))
                {
                    game.WinGame(StatusGameProcessButton, GameTimer);
                }
                else if ((game.fieldGameMineSweeper.statusGame == StatusGame.Lose) && (GameTimer.Enabled || game.clickedOfField == 0))
                {
                    game.LoseGame(StatusGameProcessButton, GameTimer);
                }
                else if (game.fieldGameMineSweeper.statusGame == StatusGame.Process)
                {
                    game.clickedOfField++;
                    StatusGameProcessButton.BackgroundImage = Properties.Resources.StatusGameProcessStart;
                    StatusGameProcessButton.BackgroundImageLayout = ImageLayout.Stretch;
                    if (game.clickedOfField == 1)
                    {
                        GameTimer.Enabled = true;
                        game.timerCount = 1;
                    }
                }
            }
        }
    }
}