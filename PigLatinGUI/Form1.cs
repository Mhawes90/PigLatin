using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Pig Latin Translator
 * by Mark Hawes
 * week 3
 * updated: 9/13/17
 */

namespace PigLatinGUI
{
    public partial class Form1 : Form
    {
        // declare constants to be used for duration of program
        const string postFix = "AY";
        const int startIndex = 1;
        char[] charsToTrim = { 'A', 'Y' };

        public Form1()
        {
            InitializeComponent();
        }

        private void engTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EngToPigLatin();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PigLatinToEnglish();
        }

        // converts word in english text box to pig latin and places it
        // in the pig latin text box
        private void EngToPigLatin()
        {
            // create a temp string to hold the english text boxes string value
            string tmp = engTextBox.Text.ToUpper();
            char initLetter = tmp[0]; // holds initial character of string
            
            plTextBox.Text = tmp.Substring(startIndex, tmp.Length - 1) + initLetter + postFix;
        }

        // converts the word in the pig latin text box and places it
        // in the english text box
        private void PigLatinToEnglish()
        {
            // create temp string to hold the pig latin text box string value
            string tmp = plTextBox.Text.ToUpper();
            
            // check that word is pig latin
            if(tmp[tmp.Length - 1] == 'Y' && tmp[tmp.Length - 2] == 'A')
            {
                // remove final two characters - aka the "ay"
                tmp = tmp.TrimEnd(charsToTrim);
                char end = tmp[tmp.Length - 1]; // save last character of string after trimming
                int index = 0; // first index because I needed a variable for this

                engTextBox.Text = end + tmp.Substring(index, tmp.Length - 1);
            }
            else
            {
                engTextBox.ResetText();
            }
        } // end PigLatinToEnglish
    } // end class
}
