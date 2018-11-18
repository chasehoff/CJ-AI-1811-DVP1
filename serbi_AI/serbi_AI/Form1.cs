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
using System.Speech.Recognition;

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
<<<<<<< HEAD
        public void aiR(string xyz)
        {
            ss.Speak(xyz);
        }
        private void rec_SpeachRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //user response to text 
            string uR = e.Result.Text;   

            if (uR == "hello")
            {
                aiR("Hello there lad!");
            }
            /*
            while(uR == "your dumb" || uR == "no your dumb")
            {
                aiR("no you dumb!");test
            }
            */
        }
=======
>>>>>>> 3816922dc74a39270831e153dba10cb2f2d4ad42

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
