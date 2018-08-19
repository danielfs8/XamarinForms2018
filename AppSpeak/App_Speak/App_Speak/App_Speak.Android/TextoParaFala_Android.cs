using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using App_Speak.Droid;


using Java.Lang;
using Android.Speech.Tts;
using Android.Speech;

[assembly: Dependency(typeof(TextoParaFala_Android))]
namespace App_Speak.Droid
{
    public class TextoParaFala_Android : Java.Lang.Object, ISpeak, TextToSpeech.IOnInitListener 
    {
        TextToSpeech speaker;
        string toSpeak;

        public void ConverteEmFala(string texto)
        {
            toSpeak = texto;
            if (speaker == null)
            {
                speaker = new TextToSpeech(Forms.Context, this);      
            }
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

        public void OnInit([GeneratedEnum] OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

    }
}