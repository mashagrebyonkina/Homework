using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace Stopwatchh
{
    public partial class Form1 : Form
    {
        private Stopwatch _stopwatch = new Stopwatch();
        private Timer _timer = new Timer() { Interval = 10 };
        private bool _resetIsWas = true;
        private bool _pauseIsWas;
        private List<Image> _list = new List<Image>();
        private int _imageNumber;

        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i < 5; i++)
                _list.Add(
                    new Bitmap($"C:\\Users\\Мария\\Desktop\\Stopwatch1\\Stopwatchh\\Stopwatchh\\Images\\{i}.jpg"));
        }

        #region Обработка события "нажатие на кнопку ПУСК"

        private void start_Click(object sender, EventArgs e)
        {
            if (_resetIsWas)
            {
                _stopwatch.Restart();
                _resetIsWas = false;
            }
            else if (_pauseIsWas)
            {
                _stopwatch.Start();
                _pauseIsWas = false;
            }

            SwapButtons(
                sender,
                "Стоп",
                start_Click,
                pause_Click);

            _timer.Tick += timer_Tick;
            _timer.Start();
        }

        #endregion 

        #region Обработка события "нажатие на кнопку СТОП"

        private void pause_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _stopwatch.Stop();
            _pauseIsWas = true;

            SwapButtons(
                sender,
                "Пуск",
                pause_Click,
                start_Click);
        }

        #endregion

        #region Обработка события "нажатие на кнопку СБРОС"

        private void reset_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            _resetIsWas = true;
            _stopwatch.Reset();
            label1.Text = "00:00.0";
            BackgroundImage = _list[_imageNumber++ % 4];
            SwapButtons(
                button1,
                "Пуск",
                pause_Click,
                start_Click);
        }

        #endregion

        private void timer_Tick(object sender, EventArgs e)
        {
            var stopwatchData = _stopwatch.Elapsed;
            label1.Text = $"0{stopwatchData.Hours}:0{stopwatchData.Minutes}.{stopwatchData.Seconds}";
        }

        #region Смена состояний левой кнопки (Пуск/Стоп)

        private void SwapButtons(object sender, string name, EventHandler firstHandler, EventHandler secondHandler)
        {
            var button = sender as Button;
            button.Text = button.Text is null ? "Empty" : name;
            button.Click -= firstHandler;
            button.Click += secondHandler;
        }



        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
