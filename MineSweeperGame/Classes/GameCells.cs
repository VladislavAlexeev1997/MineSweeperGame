using System;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeperGame.Classes
{
    public class Cell
    {
        public Button cellButton;

        public PictureBox cellPicture;

        public string statusCell;

        public bool flag;

        public bool openCell;

        public Cell(int indexLocX, int indexLocY)
        {
            CellButton(indexLocX, indexLocY);
            CellPicture(indexLocX, indexLocY);
            statusCell = "void";
            flag = false;
            openCell = false;
        }

        protected void CellButton(int indexLocX, int indexLocY)
        {
            cellButton = new Button();
            cellButton.Size = new Size(22, 22);
            cellButton.Location = new Point(indexLocX * 21, indexLocY * 21);
            cellButton.MouseDown += CellButtonMouseDown;
        }

        protected void CellPicture(int indexLocX, int indexLocY)
        {
            cellPicture = new PictureBox();
            cellPicture.Size = new Size(20, 20);
            cellPicture.Location = new Point(indexLocX * 21 + 1, indexLocY * 21 + 1);
        }

        private void CellButtonMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!flag)
                {
                    (sender as Button).BackgroundImage = Properties.Resources.flag;
                    (sender as Button).BackgroundImageLayout = ImageLayout.Stretch;
                    flag = true;
                }
                else
                {
                    (sender as Button).BackgroundImage = null;
                    flag = false;
                }
            }
            else if (e.Button == MouseButtons.Left)
            {
                (sender as Button).Visible = false;
            }
        }
    }

    public class MineCell : Cell
    {
        public MineCell(int indexLocX, int indexLocY)
            : base(indexLocX, indexLocY)
        {
            statusCell = "mine";
            DrawAllMine();
        }

        public void DrawAllMine()
        {
            cellPicture.BackgroundImage = Properties.Resources.Mine;
            cellPicture.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void DrawSelectedMine()
        {
            cellPicture.BackgroundImage = Properties.Resources.Select_Mine;
            cellPicture.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void DrawFlagOfMine()
        {
            cellButton.BackgroundImage = Properties.Resources.flagFinish;
            cellButton.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }

    public class CountCell : Cell
    {
        public int countMines;

        public CountCell(int indexLocX, int indexLocY, int mines)
            : base(indexLocX, indexLocY)
        {
            statusCell = "count";
            countMines = mines;
            DrawCountCells();
        }

        public void DrawCountCells()
        {
            switch (countMines)
            {
                case 1:
                    cellPicture.BackgroundImage = Properties.Resources._1;
                    break;
                case 2:
                    cellPicture.BackgroundImage = Properties.Resources._2;
                    break;
                case 3:
                    cellPicture.BackgroundImage = Properties.Resources._3;
                    break;
                case 4:
                    cellPicture.BackgroundImage = Properties.Resources._4;
                    break;
                case 5:
                    cellPicture.BackgroundImage = Properties.Resources._5;
                    break;
                case 6:
                    cellPicture.BackgroundImage = Properties.Resources._6;
                    break;
                case 7:
                    cellPicture.BackgroundImage = Properties.Resources._7;
                    break;
                case 8:
                    cellPicture.BackgroundImage = Properties.Resources._8;
                    break;
                default:
                    cellPicture.BackgroundImage = Properties.Resources._0;
                    break;
            }
            cellPicture.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void DrawMissMine()
        {
            cellPicture.BackgroundImage = Properties.Resources.Miss_Mine;
            cellPicture.BackgroundImageLayout = ImageLayout.Stretch;
        }
    }
}