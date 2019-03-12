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
        private int RATE = 44100; // ширина сэмпла!
        private int BUFFERSIZE = (int)Math.Pow(2, 11); // размер буффера, всегда должен быть степенью 2 -ки
        NAudio.Wave.Mp3FileReader mpFile;
        NAudio.Wave.IWavePlayer wvOut;
        NAudio.Wave.WaveStream pStream;

        public Form1()
        {
            InitializeComponent();
            wvOut = new NAudio.Wave.WaveOut();
            SetupGraphLabel();
        }

        //настраиваем вид графиков
        private void SetupGraphLabel()
        {
            scottPlotUC1.fig.labelTitle = "FFT";
            scottPlotUC1.fig.labelX = "частотное распределение";
            scottPlotUC1.Redraw();
            timer1.Enabled = false;
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
            int cntByte, gCntByte;
            byte[] sampleBuffer = new byte[4096];
            float[] flSampleBuffer;

            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
            gCntByte = 0;
            if (opf.FileName != null)
            {
                fnamelabel.Text = opf.FileName;
                mpFile = new NAudio.Wave.Mp3FileReader(opf.FileName); //открываем файл
                wvOut.Init(mpFile);//инициализируем устройство вывода звука
                do
                {
                    cntByte = mpFile.Read(sampleBuffer, 0, sampleBuffer.Length);
                    gCntByte += cntByte;
                   
                        
                } while (cntByte != 0); //считываем mp3 файл
                pStream = WaveFormatConversionStream.CreatePcmStream(mpFile);
                //waveViewer1.WaveStream = pStream;
                waveViewer1.WaveStream = mpFile;
                sampleBuffer = new byte[gCntByte];
                flSampleBuffer = new float[gCntByte * sizeof(float)];
                cntByte = mpFile.Read(sampleBuffer, 0, sampleBuffer.Length);
                SampleConverter.Convert(sampleBuffer, flSampleBuffer);
                //wavechart1.UpdateWaveform("MP3", flSampleBuffer);
                duratLabel.Text = String.Format("{0:00}:{1:00}", (int)mpFile.TotalTime.TotalMinutes, mpFile.TotalTime.Seconds);

                //настраиваем отслеживание позиции проигрываемого файла
                trackBar1.Maximum = (int)mpFile.TotalTime.TotalSeconds;
                progressBar1.Maximum = (int)mpFile.TotalTime.TotalSeconds;

                trackBar1.TickFrequency = trackBar1.Maximum / 30;
                



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
                if (wvOut != null)
                {
                    wvOut.Play();
                    timer1.Interval = 100; //интервал срабатывания таймера 3 сек
                    timer1.Enabled = true;
                }
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
                if (wvOut != null) { wvOut.Pause(); timer1.Enabled = !timer1.Enabled; }
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
                if (wvOut != null)  {wvOut.Stop(); timer1.Enabled = !timer1.Enabled; }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        //производим расчет данных для отображения БПФ
        private void calcData()
        {
            trackBar1.Value = (int)mpFile.CurrentTime.TotalSeconds;
            progressBar1.Value = trackBar1.Value;

            //анализ сигнала
            bool needsAutoScaling = true;
            int frameSize = BUFFERSIZE;
            var audioBytes = new byte[frameSize];
            mpFile.Read(audioBytes, 0, frameSize);

            // проверяем на окончание
            if (audioBytes.Length == 0)
                return;
            if (audioBytes[frameSize - 2] == 0)
                return;

            // incoming data is 16-bit (2 bytes per audio point)
            int BYTES_PER_POINT = 2;

            // create a (32-bit) int array ready to fill with the 16-bit data
            int graphPointCount = audioBytes.Length / BYTES_PER_POINT;

            // create double arrays to hold the data we will graph
            double[] pcm = new double[graphPointCount];
            double[] fft = new double[graphPointCount];
            double[] fftReal = new double[graphPointCount / 2];

            // populate Xs and Ys with double data
            for (int i = 0; i < graphPointCount; i++)
            {
                // read the int16 from the two bytes
                Int16 val = BitConverter.ToInt16(audioBytes, i * 2);

                // store the value in Ys as a percent (+/- 100% = 200%)
                pcm[i] = (double)(val) / Math.Pow(2, 16) * 200.0;
            }

            // calculate the full FFT
            fft = FFT(pcm);

            // determine horizontal axis units for graphs
            double pcmPointSpacingMs = RATE / 1000;
            double fftMaxFreq = RATE / 2;
            double fftPointSpacingHz = fftMaxFreq / graphPointCount;

            // just keep the real half (the other half imaginary)
            Array.Copy(fft, fftReal, fftReal.Length);

            // plot the Xs and Ys for both graphs
            //scottPlotUC1.Clear();
            //scottPlotUC1.PlotSignal(pcm, pcmPointSpacingMs, Color.Blue);
            scottPlotUC1.Clear();
            scottPlotUC1.PlotSignal(fftReal, fftPointSpacingHz, Color.Blue);

            // optionally adjust the scale to automatically fit the data
            if (needsAutoScaling)
            {
                scottPlotUC1.AxisAuto();
                //scottPlotUC2.AxisAuto();
                needsAutoScaling = false;
            }

            //scottPlotUC1.PlotSignal(Ys, RATE);

            //numberOfDraws += 1;
            //lblStatus.Text = $"Analyzed and graphed PCM and FFT data {numberOfDraws} times";

            // this reduces flicker and helps keep the program responsive
            Application.DoEvents();

        }

        private void updateChart(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            calcData();
            timer1.Enabled = true;
        }
    }
}
