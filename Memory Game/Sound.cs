/*
 * Arthur: Tony Anderson, Vrushank Mali
 * Date: 11/22/2020
 * Filename: Sound.cs
 * Description: This file gets and plays the background music from file.
 */

using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Memory_Game
{
    class Sound
    {
        //Creating a new mediaplayer
        private static MediaPlayer mediaPlayer = new MediaPlayer();

        //Opening music file
        public static void OpenMusic(string relativePath)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP3 files (*.mp3)|*.mp3|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                mediaPlayer.Open(new Uri(openFileDialog.FileName));
                mediaPlayer.Play();
            }
        }

        //Playing the music
        public static void PlayBackgroundMusic()
        {
            mediaPlayer.Open(new Uri(Path.Combine(Environment.CurrentDirectory, @"C:\Users\tmanr\source\repos\Memory Game\Memory Game\Music\bensound-theelevatorbossanova.mp3")));
            mediaPlayer.Play();

            
        }

        //Muting to the music
        public static void MuteBackgroundMusic()
        {
            mediaPlayer.Stop();
        }

    }
}

