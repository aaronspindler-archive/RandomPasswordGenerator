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
        int passwordLength = 16;
        char[] password = new char[16];
        int startingValue = 0;
        int range = 0;
        String convertedPass;

        Boolean uppercase;
        Boolean lowercase;
        Boolean numbers;
        Boolean specialChar;

        char[] uppercaseArray = new char[26]{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};
        char[] lowercaseArray = new char[26]{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
        char[] numbersArray = new char[10]{'1','2','3','4','5','6','7','8','9','0'};
        char[] specialCharArray = new char[13]{'!','@','#','$','%','^','&','*','-','_','+','=','?'};

        int howManyChar = 0;

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

        public void whatKindOfPassword()
        {
            uppercase = Properties.Settings.Default.uppercase;
            lowercase = Properties.Settings.Default.lowercase;
            numbers = Properties.Settings.Default.numbers;
            specialChar = Properties.Settings.Default.specialChar;
        }

        public void randomPasswordGen()
        {
            //Runs the code below for however many digits are in the password that is desired
            for (int i = 0; i <= passwordLength;i++)
            {
                int x = gen.Next(range) + startingValue;

                switch(x)
                {
                    case 0:
                        howManyChar = 26;
                        int rand1 = gen.Next(howManyChar);
                        password[i] = uppercaseArray[rand1];
                        break;
                    case 1:
                        howManyChar = 26;
                        int rand2 = gen.Next(howManyChar);
                        password[i] = lowercaseArray[rand2];
                        break;
                    case 2:
                        howManyChar = 10;
                        int rand3 = gen.Next(howManyChar);
                        password[i] = numbersArray[rand3];
                        break;
                    case 3:
                        howManyChar = 13;
                        int rand4 = gen.Next(howManyChar);
                        password[i] = specialCharArray[rand4];
                        break;
                }



                //Converts the array into a string so that it can be written to the file.
                convertedPass = password.ToString();
            }
        }


        //Checks to see if the exit button has been clicked. If it has closes the window.
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Checks to see if the options button has been clicked. If it has open the window.
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new optionsForm();
            frm.Show(this);
        }
        //Checks to see if the info button has been clicked. If it has open the window.
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AboutBox();
            frm.Show(this);
        }

        //Runs this code when the printToFileButton is clicked.
        private void printToFileButton_Click(object sender, EventArgs e)
        {
            //Opens a saveFileDialog and then checks to see if the user clicks ok.
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Creates a new file writer that is aimed at the filename that the saveFileDialog recieved from the user.
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    //Runs the code for however many times the user defined.
                    for (int i = 0; i <= numPasswords; i++)
                    {
                        randomPasswordGen();
                        sw.NewLine = (convertedPass);
                    }
                    sw.Close();
                }
                //Telling the user that the save has been successful.
                outputLabel.Text = ("You have saved your passwords to: " + saveFileDialog.FileName);
            }
            else
            {
                //Telling the user that the save has ran into an error.
                System.Windows.Forms.MessageBox.Show("An error has occured!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                outputLabel.ForeColor = Color.Red;
                outputLabel.Text = ("An error has occured");
                errorOccured = true;
            }

            //Code that fills the progress bar and does all of the fancy visual features.
            // If the progress bar is not full and no errors have occured fill the progress bar.
            if ((progressFull == false) && (errorOccured == false))
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
                    //An example of something else happening would be if the user clicked the print to file button twice.
                {
                    emptyProgress();
                    fillProgress();
                }
            }
        }
    }
}
