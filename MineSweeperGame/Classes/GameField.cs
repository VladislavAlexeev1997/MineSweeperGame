using System;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeperGame.Classes
{
    public class GameField
    {
        private Cell[,] cellsField;

        private readonly int colField;

        private readonly int rowField;

        private readonly int countMines;

        private int countOpenCells;

        private int countFlags;

        public StatusGame statusGame;

        public GameField(int newCol, int newRow, int newCountMines)
        {
            colField = newCol;
            rowField = newRow;
            countMines = newCountMines;
            countOpenCells = 0;
            countFlags = countMines;
            statusGame = StatusGame.Start;
            NewCellGrid();
            PlacingMineCells();
            PlacingCountCells();
        }

        private void NewCellGrid()
        {
            cellsField = new Cell[colField, rowField];
            for (int i = 0; i < colField; i++)
                for (int j = 0; j < rowField; j++)
                {
                    cellsField[i, j] = new Cell(i, j);
                }
        }

        private void PlacingMineCells()
        {
            Random random = new Random();
            int mineCounter = 0;
            do
            {
                int colMine = random.Next(colField);
                int rowMine = random.Next(rowField);
                if (cellsField[colMine, rowMine].statusCell != "mine")
                {
                    cellsField[colMine, rowMine] = new MineCell(colMine, rowMine);
                    cellsField[colMine, rowMine].cellButton.MouseDown += MineCellButtonMouseDown;
                    mineCounter++;
                }
            }
            while (mineCounter != countMines);
        }

        private void PlacingCountCells()
        {
            for (int i = 0; i < colField; i++)
                for (int j = 0; j < rowField; j++)
                {
                    if (cellsField[i, j].statusCell != "mine")
                    {
                        cellsField[i, j] = new CountCell(i, j, CountMines(i, j));
                        cellsField[i, j].cellButton.MouseDown += CountCellButtonMouseDown;
                    }
                }
        }

        public int CountFlags
        {
            get
            {
                return countFlags;
            }
        }

        private int CountMines(int indexCol, int indexRow)
        {
            int countMines = 0;
            if (indexCol > 0)
            {
                countMines += CompareCell(indexCol - 1, indexRow);
            }
            if (indexCol < colField - 1)
            {
                countMines += CompareCell(indexCol + 1, indexRow);
            }
            if (indexRow > 0)
            {
                countMines += CompareCell(indexCol, indexRow - 1);
            }
            if (indexRow < rowField - 1)
            {
                countMines += CompareCell(indexCol, indexRow + 1);
            }
            if ((indexCol > 0) && (indexRow > 0))
            {
                countMines += CompareCell(indexCol - 1, indexRow - 1);
            }
            if ((indexCol < colField - 1) && (indexRow > 0))
            {
                countMines += CompareCell(indexCol + 1, indexRow - 1);
            }
            if ((indexCol > 0) && (indexRow < rowField - 1))
            {
                countMines += CompareCell(indexCol - 1, indexRow + 1);
            }
            if ((indexCol < colField - 1) && (indexRow < rowField - 1))
            {
                countMines += CompareCell(indexCol + 1, indexRow + 1);
            }
            return countMines;
        }

        private int CompareCell(int nowIndexCol, int nowIndexRow)
        {
            if (cellsField[nowIndexCol, nowIndexRow].statusCell == "mine")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void DrawField(Panel field)
        {
            field.Size = new Size(22 * colField, 22 * rowField);
            for (int i = 0; i < colField; i++)
                for (int j = 0; j < rowField; j++)
                {
                    field.Controls.Add(cellsField[i, j].cellButton);
                    field.Controls.Add(cellsField[i, j].cellPicture);
                }
        }

        private void MineCellButtonMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                for (int i = 0; i < colField; i++)
                    for (int j = 0; j < rowField; j++)
                    {
                        if ((cellsField[i, j].statusCell == "mine") && (cellsField[i, j].cellButton != (sender as Button)))
                        {
                            if (cellsField[i, j].flag)
                            {
                                (cellsField[i, j] as MineCell).DrawFlagOfMine();
                                cellsField[i, j].cellButton.Enabled = false;
                            }
                            else
                            {
                                cellsField[i, j].cellButton.Visible = false;
                            }
                        }
                        else if (cellsField[i, j].cellButton == (sender as Button))
                        {
                            (cellsField[i, j] as MineCell).DrawSelectedMine();
                        }
                        else
                        {
                            if (cellsField[i, j].statusCell == "count")
                            {
                                if ((cellsField[i, j].flag) && (cellsField[i, j].cellButton.Visible))
                                {
                                    (cellsField[i, j] as CountCell).DrawMissMine();
                                    cellsField[i, j].cellButton.Visible = false;
                                }
                                else
                                {
                                    cellsField[i, j].cellButton.Enabled = false;
                                }
                            }
                            else
                            {
                                cellsField[i, j].cellButton.Enabled = false;
                            }
                        }
                    }
                statusGame = StatusGame.Lose;
            }
            else if (e.Button == MouseButtons.Right)
            {
                ButtonFlag(sender as Button);
            }
        }

        private void CountCellButtonMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if ((countOpenCells >= 0) && (countOpenCells < colField * rowField - countMines - 1))
                {
                    statusGame = StatusGame.Process;
                    for (int i = 0; i < colField; i++)
                        for (int j = 0; j < rowField; j++)
                        {
                            if (cellsField[i, j].cellButton == (sender as Button))
                            {
                                if (cellsField[i, j].flag)
                                {
                                    countFlags++;
                                }
                                OpenCountCell(i, j);
                                return;
                            }
                        }
                }
                else
                {
                    for (int i = 0; i < colField; i++)
                        for (int j = 0; j < rowField; j++)
                        {
                            if (cellsField[i, j] is MineCell)
                            {
                                (cellsField[i, j] as MineCell).DrawFlagOfMine();
                                (cellsField[i, j] as MineCell).cellButton.Enabled = false;
                            }
                        }
                    statusGame = StatusGame.Win;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                ButtonFlag(sender as Button);
            }
        }

        private void ButtonFlag(Button clickButton)
        {
            for (int i = 0; i < colField; i++)
                for (int j = 0; j < rowField; j++)
                {
                    if (cellsField[i, j].cellButton == clickButton)
                    {
                        if (cellsField[i, j].flag == true)
                        {
                            countFlags--;
                        }
                        else
                        {
                            countFlags++;
                        }
                        return;
                    }
                }
        }

        private void OpenCountCell(int indexCol, int indexRow)
        {
            if ((indexCol >= 0) && (indexRow >= 0) && (indexCol < colField) && (indexRow < rowField) && (!cellsField[indexCol, indexRow].flag))
            {
                if (cellsField[indexCol, indexRow].openCell)
                {
                    return;
                }
                cellsField[indexCol, indexRow].cellButton.Visible = false;
                countOpenCells++;
                cellsField[indexCol, indexRow].openCell = true;
                if ((cellsField[indexCol, indexRow].statusCell == "count") && ((cellsField[indexCol, indexRow] as CountCell).countMines > 0))
                {
                    return;
                }
                OpenCountCell(indexCol - 1, indexRow);
                OpenCountCell(indexCol + 1, indexRow);
                OpenCountCell(indexCol, indexRow - 1);
                OpenCountCell(indexCol, indexRow + 1);
            }
        }
    }
}