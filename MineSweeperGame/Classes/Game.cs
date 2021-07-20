using System;
using System.Media;
using System.Xml.Linq;
using System.Windows.Forms;

namespace MineSweeperGame.Classes
{
    public class Game
    {
        public GameField fieldGameMineSweeper;

        public int timerCount;

        public int clickedOfField;

        public int colFieldGame;

        public int rowFieldGame;

        public LevelGame levelGame;

        public bool tonePlayGame;

        public Game(LevelGame newLevelGame)
        {
            levelGame = newLevelGame;
            tonePlayGame = false;
        }

        public void NewGame(params PictureBox[] CountTimePictures)
        {
            switch (levelGame)
            {
                case LevelGame.Newal:
                    colFieldGame = 9;
                    rowFieldGame = 9;
                    fieldGameMineSweeper = new GameField(colFieldGame, rowFieldGame, 10);
                    break;
                case LevelGame.Devotee:
                    colFieldGame = 16;
                    rowFieldGame = 16;
                    fieldGameMineSweeper = new GameField(colFieldGame, rowFieldGame, 40);
                    break;
                default:
                    colFieldGame = 30;
                    rowFieldGame = 16;
                    fieldGameMineSweeper = new GameField(colFieldGame, rowFieldGame, 99);
                    break;
            }
            timerCount = 1;
            clickedOfField = 0;
            CountPicture(0, CountTimePictures[0]);
            CountPicture(0, CountTimePictures[1]);
            CountPicture(0, CountTimePictures[2]);
        }

        public void TimeProcessGame(params PictureBox[] CountsPicture)
        {
            if (tonePlayGame)
            {
                new SoundPlayer(Properties.Resources.SecondTimer).Play();
            }
            int nowTime = timerCount++;
            CountPicture(nowTime / 100, CountsPicture[0]);
            CountPicture((nowTime / 10) % 10, CountsPicture[1]);
            CountPicture(nowTime % 10, CountsPicture[2]);
        }

        public void PictureFlagCounter(params PictureBox[] CountsPicture)
        {
            if (fieldGameMineSweeper.CountFlags >= 0)
            {
                CountPicture(fieldGameMineSweeper.CountFlags / 100, CountsPicture[0]);
                CountPicture((fieldGameMineSweeper.CountFlags / 10) % 10, CountsPicture[1]);
                CountPicture(fieldGameMineSweeper.CountFlags % 10, CountsPicture[2]);
            }
            else
            {
                CountsPicture[0].BackgroundImage = Properties.Resources.minus;
                CountsPicture[0].BackgroundImageLayout = ImageLayout.Stretch;
                CountPicture(Math.Abs(fieldGameMineSweeper.CountFlags) / 10, CountsPicture[1]);
                CountPicture(Math.Abs(fieldGameMineSweeper.CountFlags) % 10, CountsPicture[2]);
            }
        }

        public void WinGame(Button StatusButton, Timer GameTimer)
        {
            EndGame(StatusButton, GameTimer, "Вы выиграли! Поздравляем!", "Игра выиграна");
        }

        public void LoseGame(Button StatusButton, Timer GameTimer)
        {
            EndGame(StatusButton, GameTimer, "Вы проиграли. Сожалеем...", "Игра проиграна");
        }

        private void CountPicture(int count, PictureBox countPicture)
        {
            switch (count)
            {
                case 1:
                    countPicture.BackgroundImage = Properties.Resources.Number1;
                    break;
                case 2:
                    countPicture.BackgroundImage = Properties.Resources.Number2;
                    break;
                case 3:
                    countPicture.BackgroundImage = Properties.Resources.Number3;
                    break;
                case 4:
                    countPicture.BackgroundImage = Properties.Resources.Number4;
                    break;
                case 5:
                    countPicture.BackgroundImage = Properties.Resources.Number5;
                    break;
                case 6:
                    countPicture.BackgroundImage = Properties.Resources.Number6;
                    break;
                case 7:
                    countPicture.BackgroundImage = Properties.Resources.Number7;
                    break;
                case 8:
                    countPicture.BackgroundImage = Properties.Resources.Number8;
                    break;
                case 9:
                    countPicture.BackgroundImage = Properties.Resources.Number9;
                    break;
                default:
                    countPicture.BackgroundImage = Properties.Resources.Number0;
                    break;
            }
            countPicture.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void EndGame(Button StatusButton, Timer GameTimer, string message, string nameMessage)
        {
            RewriteStatisticGame(fieldGameMineSweeper.statusGame);
            GameTimer.Enabled = false;
            if (fieldGameMineSweeper.statusGame == StatusGame.Win)
            {
                StatusButton.BackgroundImage = Properties.Resources.StatusGameProcessWin;
                if (tonePlayGame)
                {
                    new SoundPlayer(Properties.Resources.WinGame).Play();
                }
            }
            else
            {
                StatusButton.BackgroundImage = Properties.Resources.StatusGameProcessLose;
                if (tonePlayGame)
                {
                    new SoundPlayer(Properties.Resources.Mine1).Play();
                }
            }
            StatusButton.BackgroundImageLayout = ImageLayout.Stretch;
            MessageBox.Show(message, nameMessage);
        }

        private void RewriteStatisticGame(StatusGame statusGame)
        {
            string nowLevelGame;
            switch (levelGame)
            {
                case LevelGame.Newal:
                    nowLevelGame = "Новичок";
                    break;
                case LevelGame.Devotee:
                    nowLevelGame = "Любитель";
                    break;
                default:
                    nowLevelGame = "Профессионал";
                    break;
            }
            string documentName = @"Рекорды.xml";
            XDocument documentRecords = XDocument.Load(documentName);
            foreach (XElement node in documentRecords.Element("records").Elements("level"))
            {
                if (node.Attribute("name").Value == nowLevelGame)
                {
                    node.Element("allgame").Value = Convert.ToString(int.Parse(node.Element("allgame").Value) + 1);
                    if (statusGame == StatusGame.Win)
                    {
                        node.Element("wingame").Value = Convert.ToString(int.Parse(node.Element("wingame").Value) + 1);
                        if (int.Parse(node.Element("time").Value) > timerCount)
                        {
                            node.Element("time").Value = Convert.ToString(timerCount);
                        }
                    }
                }
            }
            documentRecords.Save(documentName);
        }
    }
}