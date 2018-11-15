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

        //Create the list to hold all the commands for the AI speech recognition
        Choices list = new Choices();
        public Form1()
        {
            //Create speech recognition engine
            SpeechRecognitionEngine regEng = new SpeechRecognitionEngine();

            //Stash ineraction in choices list
            list.Add(new string[] { "Hello there! I am Serbbbbb!"});

            //store the grammar inside of the Microsoft grammar builder function
            Grammar grammarStorage = new Grammar(new GrammarBuilder(list));

            try
            {
                //Make sure the bot stores grammar inputed from the user, and use the microsoft recognition library
                regEng.RequestRecognizerUpdate();
                regEng.LoadGrammar(grammarStorage);
                regEng.SpeechRecognized += rec_SpeachRecognized;

                //This sends the AI's voice to your default audio device.
                regEng.SetInputToDefaultAudioDevice();
                regEng.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }

            //Sets voice of the bot
            // ss.SelectVoiceByHints(VoiceGender.Male);

            //To make sure the mircosoft references are working we test the bot
            ss.Speak("Aye there lad! Im serbbbbeee!");
            InitializeComponent();
        }
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
                aiR("no you dumb!");
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
