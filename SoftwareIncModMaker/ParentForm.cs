using System;
using System.ComponentModel;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareIncModMaker
{
    //TODO: Refactor, Task-based Asynchronous Pattern
    public partial class ParentForm : Form, IMdiParentAccess
    {
//        private IMdiParentAccess statusAccess;

        public ParentForm()
        {
            InitializeComponent();
            WorkerClass.bg = backgroundWorker1;
            WorkerClass.pBar = progressBar1;
            WorkerClass.fCallback = this;
        }

        private void createNewModToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UserInterfaceController.showChildForm(this, new CreateBoxForm());
            ActionHistory.setStatus("Opened Create Box Window");

        }

        private void treeviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
            {
                // WinForms 
                Application.Exit();
            }
             else
            {
                // Console 
                Environment.Exit(1);
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        StatusStrip IMdiParentAccess.ActionHistoryAccess()
        {
            throw new NotImplementedException();
        }

        ToolStripStatusLabel IMdiParentAccess.statusCurrent()
        {
            return statusCurrentAction;
        }

        ToolStripStatusLabel IMdiParentAccess.statusLast()
        {
            return statusLastAction;
        }

        ToolStripStatusLabel IMdiParentAccess.statusInformation()
        {
            return statusInformation;
        }

        private void debugInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new DiagnosticForm());
            ActionHistory.setStatus("Opened Diagnostic Window");

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new AboutForm());
            ActionHistory.setStatus("Opened About Window");
        }

        private void xMLEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new XMLEditorForm(this));
            ActionHistory.setStatus("Opened XML Editor Window");

        }

        private void tabularEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            await Task.Run(()=>WorkerClass.Start());
            UserInterfaceController.showChildForm(this, new TabularEditorForm());
            ActionHistory.setStatus("Opened Tabular Window");
            
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            ActionHistory.labelControl.Add(statusCurrentAction);
            ActionHistory.labelControl.Add(statusLastAction);
            ActionHistory.labelControl.Add(statusInformation);
            ActionMemo.Component = ActionMemoBox;
//            ActionMemoTextbox.Lines =new []{"a","a"};
        }

        private void wikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new WikiBrowser());
            ActionHistory.setStatus("Opened Browser Window");
        }

        private void xMLDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
//            UserInterfaceController.showChildForm(this, new Form1());
//            ActionHistory.setStatus("Opened XMLDiagram Window");
        }

        private void ActionMemoBox_TextChanged(object sender, EventArgs e)
        {
            ActionMemoBox.SelectionStart = ActionMemoBox.Text.Length;
            ActionMemoBox.ScrollToCaret();
        }

        private void closeAllWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.DisposeAllButThis(this, MdiChildren);
        }

        private void forumBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new MetroForm2());
            ActionHistory.setStatus("Opened Forum Browser Window");
        }

        private void hideActionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hideActionLogToolStripMenuItem.Checked == false)
            {
                ActionMemoBox.Visible = false;
            }
            else
            {
                ActionMemoBox.Visible = true;
            }
        }

        private void showPropertyGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showPropertyGridToolStripMenuItem.Checked == false)
            {
                propertyGrid1.Visible = false;
            }
            else
            {
                propertyGrid1.Visible = true;
            }
        }

        private void mainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = this;
        }

        private void actionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = ActionMemoBox;
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
