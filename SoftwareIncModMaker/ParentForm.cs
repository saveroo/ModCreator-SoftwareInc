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
            WorkerClass.Bg = this.backgroundWorker1;
            WorkerClass.PBar = this.progressBar1;
            WorkerClass.FCallback = this;
        }

        StatusStrip IMdiParentAccess.ActionHistoryAccess()
        {
            throw new NotImplementedException();
        }

        ToolStripStatusLabel IMdiParentAccess.StatusCurrent()
        {
            return this.statusCurrentAction;
        }

        ToolStripStatusLabel IMdiParentAccess.StatusInformation()
        {
            return this.statusInformation;
        }

        ToolStripStatusLabel IMdiParentAccess.StatusLast()
        {
            return this.statusLastAction;
        }

        private void AboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            UserInterfaceController.ShowChildForm(this, new AboutForm());
            ActionHistory.SetStatus("Opened About Window");
        }

        private void ActionLogToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = this.ActionMemoBox;
        }

        private void ActionMemoBoxTextChanged(object sender, EventArgs e)
        {
            this.ActionMemoBox.SelectionStart = this.ActionMemoBox.Text.Length;
            this.ActionMemoBox.ScrollToCaret();
        }

        private void CloseAllWindowToolStripMenuItemClick(object sender, EventArgs e)
        {
            UserInterfaceController.DisposeAllButThis(this, this.MdiChildren);
        }

        private void CreateNewModToolStripMenuItemClick(object sender, EventArgs e)
        {
            UserInterfaceController.ShowChildForm(this, new CreateBoxForm());
            ActionHistory.SetStatus("Opened Create Box Window");
        }

        private void DebugInfoToolStripMenuItemClick(object sender, EventArgs e)
        {
            UserInterfaceController.ShowChildForm(this, new DiagnosticForm());
            ActionHistory.SetStatus("Opened Diagnostic Window");
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (Application.MessageLoop) Application.Exit();
            else Environment.Exit(1);
        }

        private void ForumBrowserToolStripMenuItemClick(object sender, EventArgs e)
        {
            UserInterfaceController.ShowChildForm(this, new MetroForm2());
            ActionHistory.SetStatus("Opened Forum Browser Window");
        }

        private void HideActionLogToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.hideActionLogToolStripMenuItem.Checked == false) this.ActionMemoBox.Visible = false;
            else this.ActionMemoBox.Visible = true;
        }

        private void MainWindowToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = this;
        }

        private void ParentFormLoad(object sender, EventArgs e)
        {
            ActionHistory.LabelControl.Add(this.statusCurrentAction);
            ActionHistory.LabelControl.Add(this.statusLastAction);
            ActionHistory.LabelControl.Add(this.statusInformation);
            ActionMemo.Component = this.ActionMemoBox;

            // ActionMemoTextbox.Lines =new []{"a","a"};
        }

        private void PropertyGrid1Click(object sender, EventArgs e)
        {
        }

        private void ShowPropertyGridToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (this.showPropertyGridToolStripMenuItem.Checked == false) this.propertyGrid1.Visible = false;
            else this.propertyGrid1.Visible = true;
        }

        private void StatusStrip1ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void TabularEditorToolStripMenuItemClick(object sender, EventArgs e)
        {
            // await Task.Run(()=>WorkerClass.Start());
            UserInterfaceController.ShowChildForm(this, new TabularEditorForm());
            ActionHistory.SetStatus("Opened Tabular Window");
        }

        private void TreeviewToolStripMenuItemClick(object sender, EventArgs e)
        {
        }

        private void WikiToolStripMenuItemClick(object sender, EventArgs e)
        {
            UserInterfaceController.ShowChildForm(this, new WikiBrowser());
            ActionHistory.SetStatus("Opened Browser Window");
        }

        private void XMlDiagramToolStripMenuItemClick(object sender, EventArgs e)
        {
            // UserInterfaceController.showChildForm(this, new Form1());
            // ActionHistory.setStatus("Opened XMLDiagram Window");
        }

        private void XMlEditorToolStripMenuItemClick(object sender, EventArgs e)
        {
            UserInterfaceController.ShowChildForm(this, new XmlEditorForm(this));
            ActionHistory.SetStatus("Opened XML Editor Window");
        }
    }
}