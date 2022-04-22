using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace SoundBoard
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void cow_Click(object sender, RoutedEventArgs e)
        {
            MySoundPlayer.PlaySound("cow.ogg");
        }

        private void sheep_Click(object sender, RoutedEventArgs e)
        {
            MySoundPlayer.PlaySound("sheep.wav");
        }

        private void pig_Click(object sender, RoutedEventArgs e)
        {
            MySoundPlayer.PlaySound("pig.wav");
        }

        private void rooster_Click(object sender, RoutedEventArgs e)
        {
            MySoundPlayer.PlaySound("rooster.wav");
        }

        private void donkey_Click(object sender, RoutedEventArgs e)
        {
            MySoundPlayer.PlaySound("donkey.wav");
        }

    }
}
