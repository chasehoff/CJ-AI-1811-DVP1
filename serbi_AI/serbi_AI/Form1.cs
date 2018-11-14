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

namespace serbi_AI
{
    public partial class Form1 : Form
    {
        //Initialize the speech Synethesizer from Microsoft
        SpeechSynthesizer ss = new SpeechSynthesizer();
        public Form1()
        {
            //Sets voice of the bot
           // ss.SelectVoiceByHints(VoiceGender.Male);

            //To make sure the mircosoft references are working we test the bot
            ss.Speak("Boooooooooo!!! I am alive and well!");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
