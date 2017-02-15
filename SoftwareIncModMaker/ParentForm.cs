namespace SoftwareIncModMaker
{
    using System;
    using System.Windows.Forms;

    // TODO: Refactor, Task-based Asynchronous Pattern
    public partial class ParentForm : Form, IMdiParentAccess
    {
        // private IMdiParentAccess statusAccess;
        public ParentForm()
        {
            this.InitializeComponent();
            WorkerClass.bg = this.backgroundWorker1;
            WorkerClass.pBar = this.progressBar1;
            WorkerClass.fCallback = this;
        }

        StatusStrip IMdiParentAccess.ActionHistoryAccess()
        {
            throw new NotImplementedException();
        }

        ToolStripStatusLabel IMdiParentAccess.statusCurrent()
        {
            return this.statusCurrentAction;
        }

        ToolStripStatusLabel IMdiParentAccess.statusInformation()
        {
            return this.statusInformation;
        }

        ToolStripStatusLabel IMdiParentAccess.statusLast()
        {
            return this.statusLastAction;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new AboutForm());
            ActionHistory.setStatus("Opened About Window");
        }

        private void actionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = this.ActionMemoBox;
        }

        private void ActionMemoBox_TextChanged(object sender, EventArgs e)
        {
            this.ActionMemoBox.SelectionStart = this.ActionMemoBox.Text.Length;
            this.ActionMemoBox.ScrollToCaret();
        }

        private void closeAllWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.DisposeAllButThis(this, this.MdiChildren);
        }

        private void createNewModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new CreateBoxForm());
            ActionHistory.setStatus("Opened Create Box Window");
        }

        private void debugInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new DiagnosticForm());
            ActionHistory.setStatus("Opened Diagnostic Window");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop) Application.Exit();
            else Environment.Exit(1);
        }

        private void forumBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new MetroForm2());
            ActionHistory.setStatus("Opened Forum Browser Window");
        }

        private void hideActionLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.hideActionLogToolStripMenuItem.Checked == false) this.ActionMemoBox.Visible = false;
            else this.ActionMemoBox.Visible = true;
        }

        private void mainWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = this;
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            ActionHistory.labelControl.Add(this.statusCurrentAction);
            ActionHistory.labelControl.Add(this.statusLastAction);
            ActionHistory.labelControl.Add(this.statusInformation);
            ActionMemo.Component = this.ActionMemoBox;

            // ActionMemoTextbox.Lines =new []{"a","a"};
        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {
        }

        private void showPropertyGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.showPropertyGridToolStripMenuItem.Checked == false) this.propertyGrid1.Visible = false;
            else this.propertyGrid1.Visible = true;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void tabularEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // await Task.Run(()=>WorkerClass.Start());
            UserInterfaceController.showChildForm(this, new TabularEditorForm());
            ActionHistory.setStatus("Opened Tabular Window");
        }

        private void treeviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void wikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new WikiBrowser());
            ActionHistory.setStatus("Opened Browser Window");
        }

        private void xMLDiagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // UserInterfaceController.showChildForm(this, new Form1());
            // ActionHistory.setStatus("Opened XMLDiagram Window");
        }

        private void xMLEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new XMLEditorForm(this));
            ActionHistory.setStatus("Opened XML Editor Window");
        }
    }
}