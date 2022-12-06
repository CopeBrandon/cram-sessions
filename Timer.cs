using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cram_sessions
{
    public class Timer
    {
        //Needs getters and methods.
        //Fields: length study, length rest, number of sessions, type of sound(as string?), optional spotify playlist or song, volume
        private int _StudyLength;
        private int _RestLength;
        private int _NumSessions;
        private int _Volume;
        private String? _SpotifyUrl;

        public Timer(int studyLength, int restLength, int numSessions, int volume) {
            _StudyLength = studyLength;
            _RestLength = restLength;
            _NumSessions = numSessions;
            _Volume = volume;
        }
        public Timer(int studyLength, int restLength, int numSessions, int volume, string spotifyUrl) {
            _StudyLength = studyLength;
            _RestLength = restLength;
            _NumSessions = numSessions;
            _Volume = volume;
            _SpotifyUrl = spotifyUrl;
        }
        public void SetVolume(int Volume) {
            _Volume = Volume;
        }
        public bool StartTimer() {
            if (_SpotifyUrl!=null) { 
                return false;
            }
            
            return true;
        }
        public bool StopTimer() {
            //TODO: Make timer stop when this function is called. Either that or make a variable that is checked against each time the timer does its loop.
            return false;
        }
    }
}
