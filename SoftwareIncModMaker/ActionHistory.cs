namespace SoftwareIncModMaker
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    internal class ActionHistory
    {
        public static List<string> HistoryOfAction = new List<string>();

        public static List<ToolStripStatusLabel> LabelControl = new List<ToolStripStatusLabel>();

        public static List<string> LastAction = new List<string>();

        public ActionHistory()
        {
            LastAction.Add("Empty");
        }

        public static bool ActionIsEnded { get; set; }

        public static string CurrentAction { get; set; }

        public static bool CurrentActionType { get; set; }

        public static string Information { get; set; }

        public static void EndAction()
        {
            LabelControl.ElementAt(0).Text = "Done!";
            ActionIsEnded = true;
            LabelControl.ElementAt(1).Text = LastAction.Last();
        }

        public static void SetStatus(string status)
        {
            HistoryOfAction.Add(status);
            LastAction.Add(status);
            CurrentAction = status;
            LabelControl.ElementAt(0).Text = status;
            if (HistoryOfAction.Count > 1) LabelControl.ElementAt(1).Text = HistoryOfAction.ElementAt(HistoryOfAction.Count - 2);
        }

        public static void SetStatus(string status, string info)
        {
            HistoryOfAction.Add(status);
            CurrentAction = status;

            LabelControl.ElementAt(2).Text = info;
            LabelControl.ElementAt(0).Text = status;
            if (HistoryOfAction.Count > 1) LabelControl.ElementAt(1).Text = HistoryOfAction.ElementAt(HistoryOfAction.Count - 2);
        }

        public static void SetStatus(bool val, string status)
        {
            LastAction.Add(status);
            CurrentAction = status;
            CurrentActionType = val;
        }

        public static void StartAction()
        {
            ActionIsEnded = false;
        }

        public void SetStatus(StatusStrip form, string status)
        {
            LastAction.Add(status);
            CurrentAction = status;
            form.Text = status;
        }

        public void SetStatus(StatusStrip form, bool val, string status)
        {
            LastAction.Add(status);
            CurrentAction = status;
            CurrentActionType = val;
            form.Text = status;
        }
    }
}