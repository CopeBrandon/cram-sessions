using MaterialDesignThemes.Wpf;
using System;
using System.Diagnostics;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace cram_sessions
{ 
    public partial class MainWindow : INotifyPropertyChanged {
        public MainWindow()
        {
            
            DataContext = this;
            InitializeComponent();
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
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Run_Click(object sender, RoutedEventArgs e) {
            return;
        }
    }
}