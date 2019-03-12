using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Dsp;
using NAudio.Wave;
using Accord;
using Accord.Audio;

namespace waudioVis
{
    public partial class Form1 : Form
    {
        NAudio.Wave.Mp3FileReader mpFile;
        NAudio.Wave.IWavePlayer wvOut;
        NAudio.Wave.WaveStream pStream;

        public Form1()
        {
            InitializeComponent();
            wvOut = new NAudio.Wave.WaveOut();
        }

        //быстрое преобразование Фурье!
        public double[] FFT(double[] data)
        {
            double[] fft = new double[data.Length];
            System.Numerics.Complex[] fftComplex = new System.Numerics.Complex[data.Length];
            for (int i = 0; i < data.Length; i++)
                fftComplex[i] = new System.Numerics.Complex(data[i], 0.0);
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            for (int i = 0; i < data.Length; i++)
                fft[i] = fftComplex[i].Magnitude;
            return fft;
        }

        private void oPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cntByte;
            byte[] sampleBuffer = new byte[4096];

            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();

            if (opf.FileName != null)
            {
                fnamelabel.Text = opf.FileName;
                mpFile = new NAudio.Wave.Mp3FileReader(opf.FileName); //открываем файл
                wvOut.Init(mpFile);//инициализируем устройство вывода звука
                do
                {
                    cntByte = mpFile.Read(sampleBuffer, 0, sampleBuffer.Length);
                    
                    
                } while (cntByte != 0); //считываем mp3 файл
                pStream = WaveFormatConversionStream.CreatePcmStream(mpFile);
                //waveViewer1.WaveStream = pStream;
                waveViewer1.WaveStream = mpFile;
                //wavechart1.
                duratLabel.Text = String.Format("{0:00}:{1:00}", (int)mpFile.TotalTime.TotalMinutes, mpFile.TotalTime.Seconds);

            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (wvOut != null) wvOut.Play();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (wvOut != null) wvOut.Pause();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (wvOut != null) wvOut.Stop();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }
    }
}
