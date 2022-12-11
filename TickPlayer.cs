using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace cram_sessions {
    internal class TickPlayer {
        private int _ticks = 0;
        private TimeSpan _ts = new(500);
        private int _studyLength;
        private int _restLength;
        private int _numSessions;
        private double _volume;
        private MediaPlayer _player = new();
        Duration duration;
        private readonly CancellationTokenSource _cts = new();
        public TickPlayer(int studyLength, int restLength, int numSessions, double volume) {
            _studyLength = studyLength * 2;//seconds->ticks
            _restLength = restLength * 2;//same
            _numSessions = numSessions;
            _player.Open(new Uri(@"Assets/Audio/Tick.wav", UriKind.Relative));
            duration = _player.NaturalDuration;
        }
        public void Play() {
            StartTick();
        }
        private async void StartTick() {
            for(int i=0; i< _numSessions; i++) {
                MessageBox.Show("Let's study.");
                while (_ticks<_studyLength) {
                    await PlayTick();
                }
                _ticks = 0;
                MessageBox.Show("Let's rest.");
                while(_ticks<_restLength) {
                    await PlayTick();
                }
                _ticks = 0;
            }
        }
        private async Task PlayTick() {
            _player.Position = new TimeSpan(0);
            _player.Play();
            _ticks++;
            await Task.Delay(500);
        }
    }
}
