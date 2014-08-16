using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PlaySong(string key)
        {
            string folder = "Sonidos/";
            string sonido = folder + key + ".wav";
            try
            {
                using (var stream = TitleContainer.OpenStream(sonido))
                {
                    if (stream != null)
                    {

                        var effect = SoundEffect.FromStream(stream);

                        FrameworkDispatcher.Update(); // Nos permite disparar el efecto que produce el sonido
                        effect.Play();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }




        private void do_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("do");
        }

        private void do_sostenido_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("do sostenido");
        }

        private void re_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("re");
        }

        private void re_sostenido_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("re sostenido");
        }

        private void mi_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("mi");
        }


        private void fa_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("fa");
        }


        private void fa_sostenido_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("fa sostenido");
        }


        private void sol_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("sol");
        }


        private void sol_sostenido_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("sol sostenido");
        }


        private void la_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("la");
        }


        private void la_sostenido_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("la sostenido");
        }


        private void si_Click(object sender, RoutedEventArgs e)
        {

            PlaySong("si");
        }


        private void doalto_Click(object sender, RoutedEventArgs e)
        {
            PlaySong("do alto");
        }
    }
}
