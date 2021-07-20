using System;
using System.IO;
using System.Windows.Forms;

namespace MineSweeperGame.UserInterface
{
    public partial class HelpForm : Form
    {
        readonly StreamReader helpFile;

        public HelpForm()
        {
            InitializeComponent();
            helpFile = new StreamReader("Справка.txt");
            ReadHelpFile();
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ReadHelpFile()
        {
            ReadOneTextBox(FieldGameTextBox, 5);
            ReadOneTextBox(RuleGameTextBox, 6);
            helpFile.Close();
        }

        private void ReadOneTextBox(TextBox infoTextBox, int maxIndex)
        {
            for (int index = 0; index <= maxIndex - 1; index++)
            {
                if (index == maxIndex - 1)
                {
                    infoTextBox.Text += helpFile.ReadLine();
                }
                else
                {
                    infoTextBox.Text += helpFile.ReadLine() + Environment.NewLine;
                }
            }
        }
    }
}