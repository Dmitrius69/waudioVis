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
using Accord;
using Accord.Audio;

namespace waudioVis
{
    public partial class Form1 : Form
    {
        NAudio.Wave.Mp3FileReader mpFile;
        NAudio.Wave.WaveOut wvOut;

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
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
