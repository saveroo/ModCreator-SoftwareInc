namespace SoftwareIncModMaker
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;

    internal class WorkerClass
    {
        private delegate void ProgressBarCallBack(Form f, ProgressBar ctrl, int value);

        private delegate void SetTextCallback(Form f, Control ctrl, string text);

        private delegate void SetValueCallback(Form f, Control ctrl, int value);

        public static BackgroundWorker bg { get; set; }

        public static bool completed { get; set; }

        public static Form fCallback { get; set; }

        public static ProgressBar pBar { get; set; }

        public static void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 0; i <= 100; i++)
            {
                completed = false;
                bg.ReportProgress(i);
            }

            completed = true;
        }

        public static void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            DelegatedProgressBarCallback(fCallback, pBar, e.ProgressPercentage);
        }

        public static void bg_completed(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                bg.Dispose();
                if (e.Error != null) MessageBox.Show(e.Error.ToString());
            }
            finally
            {
                bg = new BackgroundWorker();
            }
        }

        public static void DelegatedProgressBarCallback(Form f, ProgressBar ctrl, int value)
        {
            if (pBar.InvokeRequired)
            {
                ProgressBarCallBack pb = DelegatedProgressBarCallback;
                f.Invoke(pb, f, ctrl, value);
            }
            else
            {
                ctrl.Value = value;
            }
        }

        public static void Form1_Shown(object sender, EventArgs e)
        {
            bg.RunWorkerAsync();
        }

        public static void Start()
        {
            bg.WorkerReportsProgress = true;
            bg.DoWork += backgroundWorker1_DoWork;
            bg.ProgressChanged += backgroundWorker1_ProgressChanged;
            bg.RunWorkerAsync();
            bg.RunWorkerCompleted += bg_completed;
        }
    }
}