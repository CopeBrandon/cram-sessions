using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace cram_sessions {
    internal static class Ticker {
        //static private Uri _TickUri = new Uri(@"Assets/Audio/Tick.wav", UriKind.Relative);
        //static private MediaPlayer _player = new MediaPlayer();
        /*public Ticker() {
            _player.Open(new Uri(@"Assets/Audio/Tick.wav", UriKind.Relative));
        }*/
        public static void Play(MediaPlayer player) {
            //player.Position = new TimeSpan(0);
            player.Play();
        }
        public static void Dispose() {
           // _player.Close();
        }
    }
}
