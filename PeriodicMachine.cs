using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;

namespace cram_sessions {
    internal static class PeriodicMachine {

        public static async Task PeriodicAsync(Task action,
                                               TimeSpan interval,
                                               CancellationToken cancellationToken = default) {
            using var timer = new PeriodicTimer(interval);
            while (true) {
                await action;
                await timer.WaitForNextTickAsync(cancellationToken);
            }
        }
    }
}
