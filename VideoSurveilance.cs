//----------------------------------------------------------------------------
//  Copyright (C) 2004-2012 by EMGU. All rights reserved.       
//----------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.VideoSurveillance;

namespace VideoSurveilance
{
    public partial class VideoSurveilance : Form
    {
        private static MCvFont _font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_TRIPLEX, 0.7, 0.7);
        private static Capture _cameraCapture;
        private static BlobTrackerAuto<Bgr> _tracker;
        private static IBGFGDetector<Bgr> _detector;
        private int second = 0;
        private int cars = 0, cars1 = 0;
        private ArrayList filename;
        ManualResetEvent evt = new ManualResetEvent(true);
        Thread mThread1, mThread2;
        public VideoSurveilance()
        {
            InitializeComponent();
            filename = new ArrayList();
            //timer1.Interval = 1000 / 30;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            second = second + 1;
            label1.Text = "Total Vehicle: " + Convert.ToString(cars);
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StartVideoCount()
        {
            FGDetector<Bgr> d = new FGDetector<Bgr>(FORGROUND_DETECTOR_TYPE.FGD); ;
            BlobTrackerAuto<Bgr> t = new BlobTrackerAuto<Bgr>();
            Capture secondCapture = new Capture(openFileDialog3.FileName);
            double totalframe = secondCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_COUNT);
            for ( ; ; )
            {
                evt.WaitOne();
                Image<Bgr, byte> frameVideo = secondCapture.QueryFrame();
                double currentframe = secondCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_FRAMES);
                if(frameVideo != null)
                {
                    frameVideo._SmoothGaussian(3); //filter out noises
                    d.Update(frameVideo);
                    Image<Gray, Byte> forgroundMask = d.ForgroundMask;

                    t.Process(frameVideo, forgroundMask);

                    foreach (MCvBlob blob in t)
                    {
                        cars1 = blob.ID;
                        frameVideo.Draw((Rectangle)blob, new Bgr(255.0, 255.0, 255.0), 1);
                        frameVideo.Draw(blob.ID.ToString(), ref _font, Point.Round(blob.Center), new Bgr(10.0, 200.0, 10.0));
                        //label3.Text = "Total Vehicle: " + Convert.ToString(cars);
                        this.label3.BeginInvoke((MethodInvoker)delegate() { this.label1.Text = "Total Vehicle: " + Convert.ToString(cars1); });
                    }
                    imageBox1.Image = frameVideo;
                }
                
                Thread.Sleep(7);
            }
        }
        private void StartVideoCount2()
        {
            FGDetector<Bgr> d = new FGDetector<Bgr>(FORGROUND_DETECTOR_TYPE.FGD); ;
            BlobTrackerAuto<Bgr> t = new BlobTrackerAuto<Bgr>();
            Capture thirdCapture = new Capture(openFileDialog2.FileName);
            double totalframe = thirdCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_COUNT);
            for (; ; )
            {
                evt.WaitOne();
                Image<Bgr, byte> frameVideo = thirdCapture.QueryFrame();
                double currentframe = thirdCapture.GetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_POS_FRAMES);
                frameVideo._SmoothGaussian(3); //filter out noises
                d.Update(frameVideo);
                Image<Gray, Byte> forgroundMask = d.ForgroundMask;

                t.Process(frameVideo, forgroundMask);

                foreach (MCvBlob blob in t)
                {
                    int cars2 = blob.ID;
                    frameVideo.Draw((Rectangle)blob, new Bgr(255.0, 255.0, 255.0), 2);
                    frameVideo.Draw(blob.ID.ToString(), ref _font, Point.Round(blob.Center), new Bgr(10.0, 10.0, 10.0));
                    //label3.Text = "Total Vehicle: " + Convert.ToString(cars);
                    this.label3.BeginInvoke((MethodInvoker)delegate() { this.label3.Text = "Total Vehicle: " + Convert.ToString(cars2); });
                }
                imageBox2.Image = frameVideo;
                Thread.Sleep(1);
            }
        }
        private void openVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }




        private void VideoSurveilance_Load(object sender, EventArgs e)
        {

        }

        private void VideoSurveilance_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnLoadVid2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
 
        }

        private void btnLoadVid3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void btnPlay1_Click(object sender, EventArgs e)
        {
            mThread1 = new Thread(new ThreadStart(StartVideoCount));
            mThread1.Start();

            //foreach (object fn in filename)
            //{
            //    string fname = (string)fn + "\n";
            //richTextBox1.Text = filename.Count.ToString();
            //}

            //if (filename.Count == 1)
            //{
            //    mThread1 = new Thread(new ThreadStart(StartVideoCount));
            //    mThread1.Start();
            //}
            //if (filename.Count == 2)
            //{
                //richTextBox1.Text = (string)filename[0] + "\n" + (string)filename[1];
            //mThread1.Join();
                //mThread2.Join();
            //}
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //filename.Add(openFileDialog1.FileName);
            btnPlay1.Enabled = true;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mThread2 = new Thread(new ThreadStart(StartVideoCount2));
            mThread2.Start();

        }

        private void VideoSurveilance_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mThread1 = new Thread(new ThreadStart(StartVideoCount));
            mThread1.Start();
        }

        private void imageBox6_Click(object sender, EventArgs e)
        {

        }

    }
}