using MaterialDesignThemes.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.IO;

namespace cram_sessions
{ 
    public partial class MainWindow : INotifyPropertyChanged {
        private Pomodoro newPom = new Pomodoro(1, 1, 1, 1);
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }
        private int _SessionCount;
        public int SessionCount {
            get { return _SessionCount; }
            set { if (_SessionCount!= value) {
                    _SessionCount= value;
                    OnPropertyChanged();
                }}
        }
        private int _StudyLengthSlider = 120;
        public int StudyLengthSlider {
            get {
                return _StudyLengthSlider;
            }
            set { if (_StudyLengthSlider != value) {
                    _StudyLengthSlider = value;
                    OnPropertyChanged();
                }}
        }
        private int _StudyDurationValue;
        public int StudyDurationValue {
            get { return _StudyDurationValue; }
            set { if (_StudyDurationValue != value) {
                    _StudyDurationValue = value;
                    OnPropertyChanged();
                }}
        }
        private int _RestLengthSlider = 120;
        public int RestLengthSlider {
            get {
                return _RestLengthSlider;
            }
            set { if (_RestLengthSlider != value) {
                    _RestLengthSlider = value;
                    OnPropertyChanged();
                }}
        }
        private int _RestDurationValue;
        public int RestDurationValue {
            get { return _RestDurationValue; }
            set { if (_RestDurationValue != value) {
                    _RestDurationValue= value;
                    OnPropertyChanged();
                }}
        }
        private int _Volume;
        public int Volume {
            get { return _Volume; }
            set { if (_Volume != value) {
                    _Volume= value;
                    OnPropertyChanged();
                }}
        }
        private string? _SpotifyURL=null;
        public string? SpotifyURL {
            get { return _SpotifyURL; }
            set {
                if (_SpotifyURL != value) {
                    _SpotifyURL = value;
                    OnPropertyChanged();
                }}
        }
        private bool _isShuffle;
        public bool isShuffle {
            get { return _isShuffle; }
            set {
                if (_isShuffle != value) {
                    _isShuffle = value;
                    OnPropertyChanged();
                }}
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Run_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("SessionCount: " + SessionCount +
                            "\nStudyDurationValue: " + StudyDurationValue +
                            "\nRestDurationValue: " + RestDurationValue + 
                            "\nVolume: " + Volume +
                            "\nSpotifyURL: " + SpotifyURL +
                            "\nisShuffle: " + isShuffle);
            newPom.StartTimer();
        }
    }
}