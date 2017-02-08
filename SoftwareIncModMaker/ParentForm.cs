using System;
using System.Windows.Forms;

namespace SoftwareIncModMaker
{
    public partial class ParentForm : Form, IMdiParentAccess
    {
        private IMdiParentAccess statusAccess;

        public ParentForm()
        {
            InitializeComponent();
        }

        private void deleteTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_Click(object sender, EventArgs e)
        {
                
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition);
            }
        }

        private void xmlView()
        {
           
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
            UserInterfaceController.showChildForm(this, new TabularEditorForm());
            ActionHistory.setStatus("Opened Tabular Window");

        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            ActionHistory.labelControl.Add(statusCurrentAction);
            ActionHistory.labelControl.Add(statusLastAction);
            ActionHistory.labelControl.Add(statusInformation);
        }

        private void wikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new WikiBrowser());
            ActionHistory.setStatus("Opened Browser Window");
        }

        private void xMLDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new Form1());
            ActionHistory.setStatus("Opened XMLDiagram Window");
        }
    }
}
