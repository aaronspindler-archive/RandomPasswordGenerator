using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPasswordGenerator
{
    public partial class optionsForm : Form
    {
        //Variable Declaration
        Boolean uppercase;
        Boolean lowercase;
        Boolean numbers;
        Boolean specialChar;

        public optionsForm()
        {
            InitializeComponent();
        }

        //Checks to see if the box's state has been changed
        private void uppercaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (uppercaseCheckBox.Checked == true)
            {
                Properties.Settings.Default.uppercase = true;
                uppercase = true;
            }
            else
            {
                Properties.Settings.Default.uppercase = false;
                uppercase = false;
            }
        }

        //Checks to see if the box's state has been changed
        private void lowercaseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (lowercaseCheckBox.Checked == true)
            {
                Properties.Settings.Default.lowercase = true;
                lowercase = true;
            }
            else
            {
                Properties.Settings.Default.lowercase = false;
                lowercase = false;
            }
        }

        //Checks to see if the box's state has been changed
        private void numbersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (numbersCheckBox.Checked == true)
            {
                Properties.Settings.Default.numbers = true;
                numbers = true;
            }
            else
            {
                Properties.Settings.Default.numbers = false;
                numbers = false;
            }
        }

        //Checks to see if the box's state has been changed
        private void specialCharCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (specialCharCheckBox.Checked == true)
            {
                Properties.Settings.Default.specialChar = true;
                specialChar = true;
            }
            else
            {
                Properties.Settings.Default.specialChar = false;
                specialChar = false;
            }
        }

        //Checks the settings to see what the users settings are. Then it changes which check boxes are checked.
        private void optionsForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.uppercase == true)
            {
                uppercaseCheckBox.Checked = true;
                uppercase = true;
            }
            else
            {
                uppercaseCheckBox.Checked = false;
                uppercase = false;
            }

            if (Properties.Settings.Default.lowercase == true)
            {
                lowercaseCheckBox.Checked = true;
                lowercase = true;
            }
            else
            {
                lowercaseCheckBox.Checked = false;
                lowercase = false;
            }

            if (Properties.Settings.Default.numbers == true)
            {
                numbersCheckBox.Checked = true;
                numbers = true;
            }
            else
            {
                numbersCheckBox.Checked = false;
                numbers = false;
            }

            if (Properties.Settings.Default.specialChar == true)
            {
                specialCharCheckBox.Checked = true;
                specialChar = true;
            }
            else
            {
                specialCharCheckBox.Checked = false;
                specialChar = false;
            }
        }

        private void optionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.uppercase = uppercase;
            Properties.Settings.Default.lowercase = lowercase;
            Properties.Settings.Default.numbers = numbers;
            Properties.Settings.Default.specialChar = specialChar;
            Properties.Settings.Default.Save();
        }
    }
}
