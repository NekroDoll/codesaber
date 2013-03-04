using System;
using System.IO;
using System.Windows;

namespace CodeSaber.Ice
{
    public static class Initial
    {
        public static string Text
        {
            
            get
            {
                var uri = new Uri("Resources/InitialEditorText.txt", UriKind.Relative);
                var info = Application.GetResourceStream(uri);
                using (var sr = new StreamReader(info.Stream))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}