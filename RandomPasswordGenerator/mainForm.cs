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
        //Accessing other forms
        optionsForm of = new optionsForm();
        AboutBox ab = new AboutBox();

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
            //Runs the code below for however many digits are in the password that is desired
            for (int i = 0; i <= passwordLength;i++)
            {
                int x = gen.Next(range) + startingValue;

                //Case Numbers
                //Category              Numbers
                //Numbers               0 - 9
                //Uppercase             10 - 35
                //Lowercase             36 - 61
                //Special Characters    62 - 74


                //Very long a tedious way of getting a random character.
                //I will try to shorten this once I know how to do it.
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
                    case 21:
                        password[i] = ('L');
                        break;
                    case 22:
                        password[i] = ('M');
                        break;
                    case 23:
                        password[i] = ('N');
                        break;
                    case 24:
                        password[i] = ('O');
                        break;
                    case 25:
                        password[i] = ('P');
                        break;
                    case 26:
                        password[i] = ('Q');
                        break;
                    case 27:
                        password[i] = ('R');
                        break;
                    case 28:
                        password[i] = ('S');
                        break;
                    case 29:
                        password[i] = ('T');
                        break;
                    case 30:
                        password[i] = ('U');
                        break;
                    case 31:
                        password[i] = ('V');
                        break;
                    case 32:
                        password[i] = ('W');
                        break;
                    case 33:
                        password[i] = ('X');
                        break;
                    case 34:
                        password[i] = ('Y');
                        break;
                    case 35:
                        password[i] = ('Z');
                        break;
                    case 36:
                        password[i] = ('a');
                        break;
                    case 37:
                        password[i] = ('b');
                        break;
                    case 38:
                        password[i] = ('c');
                        break;
                    case 39:
                        password[i] = ('d');
                        break;
                    case 40:
                        password[i] = ('e');
                        break;
                    case 41:
                        password[i] = ('f');
                        break;
                    case 42:
                        password[i] = ('g');
                        break;
                    case 43:
                        password[i] = ('h');
                        break;
                    case 44:
                        password[i] = ('i');
                        break;
                    case 45:
                        password[i] = ('j');
                        break;
                    case 46:
                        password[i] = ('k');
                        break;
                    case 47:
                        password[i] = ('l');
                        break;
                    case 48:
                        password[i] = ('m');
                        break;
                    case 49:
                        password[i] = ('n');
                        break;
                    case 50:
                        password[i] = ('o');
                        break;
                    case 51:
                        password[i] = ('p');
                        break;
                    case 52:
                        password[i] = ('q');
                        break;
                    case 53:
                        password[i] = ('r');
                        break;
                    case 54:
                        password[i] = ('s');
                        break;
                    case 55:
                        password[i] = ('t');
                        break;
                    case 56:
                        password[i] = ('u');
                        break;
                    case 57:
                        password[i] = ('v');
                        break;
                    case 58:
                        password[i] = ('w');
                        break;
                    case 59:
                        password[i] = ('x');
                        break;
                    case 60:
                        password[i] = ('y');
                        break;
                    case 61:
                        password[i] = ('z');
                        break;
                    case 62:
                        password[i] = ('!');
                        break;
                    case 63:
                        password[i] = ('@');
                        break;
                    case 64:
                        password[i] = ('#');
                        break;
                    case 65:
                        password[i] = ('$');
                        break;
                    case 66:
                        password[i] = ('%');
                        break;
                    case 67:
                        password[i] = ('^');
                        break;
                    case 68:
                        password[i] = ('&');
                        break;
                    case 69:
                        password[i] = ('*');
                        break;
                    case 70:
                        password[i] = ('-');
                        break;
                    case 71:
                        password[i] = ('_');
                        break;
                    case 72:
                        password[i] = ('+');
                        break;
                    case 73:
                        password[i] = ('=');
                        break;
                    case 74:
                        password[i] = ('?');
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
            of.Show();
        }
        //Checks to see if the info button has been clicked. If it has open the window.
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ab.Show();
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
