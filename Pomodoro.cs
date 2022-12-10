using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Media;

namespace cram_sessions
{
    public class Pomodoro
    {
        //Needs getters and methods.
        //Fields: length study, length rest, number of sessions, type of sound(as string?), optional spotify playlist or song, volume
        private int _NumSessions;
        private int _StudyLength;
        private int _sessionCount = 0;
        private int _studyCount = 0;
        private int _RestLength;
        private int _Volume;
        private String? _SpotifyUrl = null;
        private bool _isShuffled = false;
        

        private RepeatingTick _ticker = new RepeatingTick(TimeSpan.FromMilliseconds(500));
        private MediaPlayer _player = new();

        public Pomodoro(int studyLength, int restLength, int numSessions, int volume) {
            _StudyLength = studyLength * 60; //input in minutes, converts to seconds
            _RestLength = restLength * 60;
            _NumSessions = numSessions;
            _Volume = volume;
            _player.Open(new Uri(@"Assets/Audio/Tick.wav", UriKind.Relative));
        }
        public Pomodoro(int studyLength, int restLength, int numSessions, int volume, string spotifyUrl, bool isShuffled) {
            _StudyLength = studyLength;
            _RestLength = restLength;
            _NumSessions = numSessions;
            _Volume = volume;
            _SpotifyUrl = spotifyUrl;
            _isShuffled = isShuffled;
        }
        public void SetVolume(int Volume) {
            _Volume = Volume;
        }
        public void SetShuffled(bool isShuffled) {
            _isShuffled = isShuffled;
        }
        public void StartTimer() { //todo: Figure out how to process tasks as they complete, and then count them so that you can only do so many in a row.
                _ticker.Start(_player, _StudyLength);
        }

        public void StopTimer() {
            //TODO: Make timer stop when this function is called. Either that or make a variable that is checked against each time the timer does its loop.
            MessageBox.Show("Stopped;");
        }
    }
}
