// This is a simple text to speach program.
// What this program does is takes string input and read it out loud to the user
// It is made as window form, not a console application


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TTS
{
    public partial class Form1 : Form
    {
        //This is instance for synth object, for the list where the fonts will be and string for the TTS
        SpeechSynthesizer synth = new SpeechSynthesizer();
        List<string> listBoxItems = new List<string>();
        string theText;

        //The starting point in the program, the basic window
        public Form1()
        {
            InitializeComponent();
        }

        //Function for speaking strings
        private void Speak()
        {
            synth.Speak(theText);
        }

        //Close the window upon exit button click
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Show info in the about menu
        private void aboutTTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a Text to Speech program v 1.0 made by i3aze", "About");
        }

        //Exit from the program upon exit button click
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Speak uppon the press of the start button
        private void button1_Click(object sender, EventArgs e)
        {
            if (theText != null)
            {
                Speak();
                textBox1.Clear();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //Write text in the textbox
        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            theText = objTextBox.Text;
        }

        //Speak upon the press of enter
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                if (theText != null)
                {
                    Speak();
                    textBox1.Clear();
                }
                textBox1.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void changeVoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Speak with male voice
        private void toMaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);
        }

        //Speak with female voice
        private void toFemaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);
        }

        //Speak upon press start in the menu
        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (theText != null)
            {
                Speak();
                textBox1.Clear();

            }
        }
    }
}
