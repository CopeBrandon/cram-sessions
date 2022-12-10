using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;


//https://www.youtube.com/watch?v=J4JL4zR_l-0 Source of PeriodicTimer code. Tysm Nick Chapsas
namespace cram_sessions {
    internal class RepeatingTick{
        private Task? _timerTask;
        private readonly PeriodicTimer _timer;
        private readonly CancellationTokenSource _cts = new();
        private int _ticks = 0;

        public RepeatingTick(TimeSpan interval) {
            _timer = new PeriodicTimer(interval);
        }

        public void Start(MediaPlayer player, int sessionLength) {
            _timerTask = DoWorkAsync(player, sessionLength);
        }

        private async Task DoWorkAsync(MediaPlayer player, int sessionLength) {
                try {
                while (await _timer.WaitForNextTickAsync(_cts.Token)) {
                        if (_ticks < sessionLength / 2) {
                            player.Position = new TimeSpan(0);
                            player.Play();
                            _ticks++;
                        }
                        else {
                                _ = StopAsync();
                                break;
                        }
                    }

                } catch (OperationCanceledException) {
                }
             
        }
        public async Task StopAsync() {
            if(_timerTask is null) {
                return;
            }
            _ticks = 0;
            _cts.Cancel();
            await _timerTask;
            _cts.Dispose();
            MessageBox.Show("Task was cancelled");
        }
    }
}
