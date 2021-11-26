using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstAppp.Models
{
    public interface ITextToSpeech
    {
        void Speak(string text);
    }
}
