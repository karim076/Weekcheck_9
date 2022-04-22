using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace SoundBoard
{
    internal class MySoundPlayer
    {
        public static void PlaySound(string fileName)
        {
            fileName = "Assets\\Animals\\" + fileName;
            PlayFromFile(fileName);
        }

        private static async void PlayFromFile(string fileName)
        {
            var element = new MediaElement();
            var folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            var file = await folder.GetFileAsync(fileName);
            var stream = await file.OpenAsync(Windows.Storage.FileAccessMode.Read);
            element.SetSource(stream, "");
            element.Play();
        }

        internal static ElementSoundMode PlaySound(object wav)
        {
            throw new NotImplementedException();
        }
    }
}
