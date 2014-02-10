using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//@author xNovax

namespace RandomPasswordGenerator
{
    public partial class mainForm : Form
    {
        //Variable Declaration
        decimal numPasswords;
        Boolean progressFull = false;
        Boolean errorOccured = false;
        Random gen = new Random();
        static int passwordLength = 16;
        char[] password = new char[passwordLength];

        public mainForm()
        {
            InitializeComponent();
        }

        //Fills the progress bar
        public void fillProgress()
        {
            for (int i = 0; i < 101;i++)
            {
                progressBar.Value = i;
            }
            progressFull = true;
        }
        
        //Resets the progress bar.
        public void emptyProgress()
        {
            progressBar.Value = 0;
            progressFull = false;
        }

        //Gets the number of passwords the user wants.
        private void numberOfPasswordsUD_ValueChanged(object sender, EventArgs e)
        {
            numPasswords = numberOfPasswordsUD.Value;
        }

        public void randomPasswordGen()
        {
            for (int i = 0; i <= passwordLength;i++)
            {
                int x = gen.Next(10);

                switch(x)
                {
                    case 0:
                        password[i] = ('1');
                        break;
                    case 1:
                        password[i] = ('2');
                        break;
                    case 2:
                        password[i] = ('3');
                        break;
                    case 3:
                        password[i] = ('4');
                        break;
                    case 4:
                        password[i] = ('5');
                        break;
                    case 5:
                        password[i] = ('6');
                        break;
                    case 6:
                        password[i] = ('7');
                        break;
                    case 7:
                        password[i] = ('8');
                        break;
                    case 8:
                        password[i] = ('9');
                        break;
                    case 9:
                        password[i] = ('0');
                        break;
                    case 10:
                        password[i] = ('A');
                        break;
                    case 11:
                        password[i] = ('B');
                        break;
                    case 12:
                        password[i] = ('C');
                        break;
                    case 13:
                        password[i] = ('D');
                        break;
                    case 14:
                        password[i] = ('E');
                        break;
                    case 15:
                        password[i] = ('F');
                        break;
                    case 16:
                        password[i] = ('G');
                        break;
                    case 17:
                        password[i] = ('H');
                        break;
                    case 18:
                        password[i] = ('I');
                        break;
                    case 19:
                        password[i] = ('J');
                        break;
                    case 20:
                        password[i] = ('K');
                        break;
                }
            }
        }

        //Runs everything when it is needed and prints the passwords to a file.
        private void printToFileButton_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                    {
                        for (int i = 0; i <= numPasswords; i++)
                        {
                            randomPasswordGen();
                            sw.Write(password);
                        }
                        sw.Close();
                    }
                outputLabel.Text = ("You have saved your passwords to: " + saveFileDialog.FileName);
            }
            else
            {
                outputLabel.ForeColor = Color.Red;
                outputLabel.Text = ("An error has occured");
                errorOccured = true;
            }

            //Code that fills the progress bar and does all of the fancy visual features.
            // If the progress bar is not full and no errors have occured fill the progress bar.
            if ((progressFull == false)&&(errorOccured == false))
            {
                fillProgress();
            }
            else
            {
                // If an error has occured empty the progress bar
                if (errorOccured == true)
                {
                    emptyProgress();
                }
                else
                // If something else happened empty the progress bar and fill it again.
                {
                    emptyProgress();
                    fillProgress();
                }
            }

        }
    }
}
