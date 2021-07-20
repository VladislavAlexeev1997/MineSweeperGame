using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MineSweeperGame.UserInterface
{
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
            ReadFileRecords("Новичок");
        }

        private void RadioButtonCheckedChanged(object sender, EventArgs e)
        {
            StatisticGroupBox.Text = (sender as RadioButton).Text;
            ReadFileRecords((sender as RadioButton).Text);
        }

        private void ReadFileRecords(string levelName)
        {
            string documentName = @"Рекорды.xml";
            XDocument documentRecords = XDocument.Load(documentName);
            foreach (XElement node in documentRecords.Element("records").Elements("level"))
            {
                if (node.Attribute("name").Value == levelName)
                {
                    GamesCountLabel.Text = node.Element("allgame").Value;
                    WinGamesLabel.Text = node.Element("wingame").Value;
                    TimeLabel.Text = node.Element("time").Value;
                }
            }
        }

        private void RestartButtonClick(object sender, EventArgs e)
        {
            string documentName = @"Рекорды.xml";
            XDocument documentRecords = XDocument.Load(documentName);
            foreach (XElement node in documentRecords.Element("records").Elements("level"))
            {
                node.Element("allgame").Value = Convert.ToString(0);
                node.Element("wingame").Value = Convert.ToString(0);
                node.Element("time").Value = Convert.ToString(999);
            }
            documentRecords.Save(documentName);
            GamesCountLabel.Text = "0";
            WinGamesLabel.Text = "0";
            TimeLabel.Text = "999";
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}