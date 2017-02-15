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

        public static BackgroundWorker Bg { get; set; }

        public static bool Completed { get; set; }

        public static Form FCallback { get; set; }

        public static ProgressBar PBar { get; set; }

        public static void BackgroundWorker1DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 0; i <= 100; i++)
            {
                Completed = false;
                Bg.ReportProgress(i);
            }

            Completed = true;
        }

        public static void BackgroundWorker1ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            DelegatedProgressBarCallback(FCallback, PBar, e.ProgressPercentage);
        }

        public static void BgCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                Bg.Dispose();
                if (e.Error != null) MessageBox.Show(e.Error.ToString());
            }
            finally
            {
                Bg = new BackgroundWorker();
            }
        }

        public static void DelegatedProgressBarCallback(Form f, ProgressBar ctrl, int value)
        {
            if (PBar.InvokeRequired)
            {
                ProgressBarCallBack pb = DelegatedProgressBarCallback;
                f.Invoke(pb, f, ctrl, value);
            }
            else
            {
                ctrl.Value = value;
            }
        }

        public static void Form1Shown(object sender, EventArgs e)
        {
            Bg.RunWorkerAsync();
        }

        public static void Start()
        {
            Bg.WorkerReportsProgress = true;
            Bg.DoWork += BackgroundWorker1DoWork;
            Bg.ProgressChanged += BackgroundWorker1ProgressChanged;
            Bg.RunWorkerAsync();
            Bg.RunWorkerCompleted += BgCompleted;
        }
    }
}