using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareIncModMaker
{
    class ActionHistory
    {

        // private static string _currentAction;
        // private static bool _currentActionType;
        // private static bool _actionIsEnded;
        // private static List<String> _lastAction;
        // private static string _information;
        public static List<String> HistoryOfAction = new List<String>();
        public static string CurrentAction { get; set; }
        public static bool CurrentActionType { get; set; }
        public static bool ActionIsEnded { get; set; }
        public static List<String> LastAction = new List<String>();
        public static string Information { get; set; }
        public static List<ToolStripStatusLabel> labelControl = new List<ToolStripStatusLabel>();

        public ActionHistory()
        {
            LastAction.Add("Empty");

        }

        public static void startAction()
        {
            ActionIsEnded = false;
        }
        public static void endAction()
        {
            labelControl.ElementAt(0).Text = "Done!";
            ActionIsEnded = true;
            labelControl.ElementAt(1).Text = LastAction.Last();
        }

        public static void setStatus(string status)
        {
            HistoryOfAction.Add(status);
            LastAction.Add(status);
            CurrentAction = status;
            labelControl.ElementAt(0).Text = status;
            if(HistoryOfAction.Count > 1) { 
                labelControl.ElementAt(1).Text = HistoryOfAction.ElementAt(HistoryOfAction.Count - 2).ToString();
            }
        }

        public static void setStatus(string status, string info)
        {
            HistoryOfAction.Add(status);
            CurrentAction = status;


            labelControl.ElementAt(2).Text = info;
            labelControl.ElementAt(0).Text = status;
            if (HistoryOfAction.Count > 1)
            {
                labelControl.ElementAt(1).Text = HistoryOfAction.ElementAt(HistoryOfAction.Count - 2).ToString();
            }
        }

        public static void setStatus(bool val, string status)
        {
            LastAction.Add(status);
            CurrentAction = status;
            CurrentActionType = val;
        }
        public void setStatus(StatusStrip form, string status)
        {
            LastAction.Add(status);
            CurrentAction = status;
            form.Text = status;
        }
        public void setStatus(StatusStrip form, bool val, string status)
        {
            LastAction.Add(status);
            CurrentAction = status;
            CurrentActionType = val;
            form.Text = status;
        }

    }
}
