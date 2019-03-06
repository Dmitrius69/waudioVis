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

        private void oPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cntByte;
            byte[] sampleBuffer = new byte[4096];

            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();

            if (opf.FileName != null)
            {
                fnamelabel.Text = opf.FileName;
                //wvOut.Init();
                mpFile = new NAudio.Wave.Mp3FileReader(opf.FileName); //открываем файл
                do
                {
                    cntByte = mpFile.Read(sampleBuffer, 0, sampleBuffer.Length);
                    
                } while (cntByte != 0); //считываем mp3 файл
                pStream = WaveFormatConversionStream.CreatePcmStream(mpFile);
                //waveViewer1.WaveStream = pStream;
                waveViewer1.WaveStream = mpFile;
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
    }
}
