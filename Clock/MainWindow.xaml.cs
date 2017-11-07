using System;
using System.Windows;
using System.Windows.Threading;

namespace Clock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer Timer;

        public MainWindow()
        {
            InitializeComponent();
            Timer = new DispatcherTimer();

            Timer.Tick += new EventHandler(Timer_Click);
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Start();
        }

        private void Timer_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;

            string hh = d.Hour.ToString();
            string mm = d.Minute.ToString();
            string ss = d.Second.ToString();

            if (d.Hour < 10) hh = $"0{hh}";
            if (d.Minute < 10) mm = $"0{mm}";
            if (d.Second < 10) ss = $"0{ss}";

            TimeLabel.Text = $"{hh}.{mm}.{ss}";
        }
    }
}
