/*using Android.Speech.Tts;
using Xamarin.Forms;
using Java.Lang;
using App_Speak;
using App_Speak.Droid;
//using Android.Content.PM;
using Android.Content;
//using Android.Content.Res;

[assembly: Dependency(typeof(TextToSpeech_Android))]
namespace App_Speak.Droid
{
    public class TextToSpeech_Android : Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        TextToSpeech speaker;
        string toSpeak;

        public void Speak(string text)
        {
            toSpeak = text;
            if (speaker == null)
                speaker = new  TextToSpeech(Forms.Context, this);
            else
            {
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
        }

        #region IOnInitListener implementation
        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                System.Diagnostics.Debug.WriteLine("spoke");
                speaker.Speak(toSpeak, QueueMode.Flush, null, null);
            }
            else
                System.Diagnostics.Debug.WriteLine("was quiet");
        }
        #endregion
    }
}*/