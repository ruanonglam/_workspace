using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using NAudio.WindowsMediaFormat;
using System.Threading;
using System.Diagnostics;
using Util;

namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        IWavePlayer waveOutDevice;
        WaveStream mainOutputStream;
        WaveChannel32 volumeStream;
        WaveStream wmaReader;

        // Timer
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();


        public Form1()
        {
            InitializeComponent();
            
        }

        private void playAudio(int startTime)
        {
            waveOutDevice = new WaveOut();
            wmaReader = new WMAFileReader(@"C:\Users\AFTECH\Downloads\[Giang Chau]Chuyen Bac Ba Phi.mp3");
            volumeStream = new WaveChannel32(wmaReader);
            mainOutputStream = volumeStream;

            mainOutputStream.Skip(startTime);

            waveOutDevice.Init(wmaReader);

            waveOutDevice.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtStartTime.Text))
            {
                playAudio(0);
            }
            else
            {
                playAudio(Int32.Parse(txtStartTime.Text));
            }

            //
            if (String.IsNullOrEmpty(txtPlayTime.Text))
            {
                playStopped(Convert.ToInt32(mainOutputStream.TotalTime.TotalSeconds));
            }
            else
            {
                playStopped(Int32.Parse(txtPlayTime.Text));
            }
            
        }

        private void playStopped(int time)
        {
            //
            timer.Tick += new EventHandler(TimerEventProcessor);

            // Sets the timer interval to 5 seconds.
            timer.Interval = time * 1000;
            timer.Start();

            this.btnPlay.Enabled = false;
            this.btnStop.Enabled = true;
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            timer.Stop();
            timer.Enabled = false;
            waveOutDevice.Stop();
            this.btnPlay.Enabled = true;
            this.btnStop.Enabled = false;
       }

        private void button2_Click(object sender, EventArgs e)
        {
            waveOutDevice.Stop();
            this.btnPlay.Enabled = true;
            this.btnStop.Enabled = false;
        }
    }
}
