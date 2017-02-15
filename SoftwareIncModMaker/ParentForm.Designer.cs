﻿namespace SoftwareIncModMaker
{
    partial class ParentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateSoftwareTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateScenarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWrapperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabularEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nodeEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLDiagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wikiBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forumBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPropertyGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideActionLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCurrentAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusInformation = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTableProcess = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataTableEditor = new System.Data.DataTable();
            this.ActionMemoBox = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.process1 = new System.Diagnostics.Process();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.treeviewToolStripMenuItem,
            this.wikiToolStripMenuItem,
            this.miscToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1244, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewModToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.viewWrapperToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewModToolStripMenuItem
            // 
            this.createNewModToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateSoftwareTypeToolStripMenuItem,
            this.generateScenarioToolStripMenuItem,
            this.generateEventsToolStripMenuItem});
            this.createNewModToolStripMenuItem.Name = "createNewModToolStripMenuItem";
            this.createNewModToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.createNewModToolStripMenuItem.Text = "New";
            this.createNewModToolStripMenuItem.Click += new System.EventHandler(this.CreateNewModToolStripMenuItemClick);
            // 
            // generateSoftwareTypeToolStripMenuItem
            // 
            this.generateSoftwareTypeToolStripMenuItem.Name = "generateSoftwareTypeToolStripMenuItem";
            this.generateSoftwareTypeToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.generateSoftwareTypeToolStripMenuItem.Text = "Generate SoftwareType";
            // 
            // generateScenarioToolStripMenuItem
            // 
            this.generateScenarioToolStripMenuItem.Enabled = false;
            this.generateScenarioToolStripMenuItem.Name = "generateScenarioToolStripMenuItem";
            this.generateScenarioToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.generateScenarioToolStripMenuItem.Text = "Generate Scenario";
            // 
            // generateEventsToolStripMenuItem
            // 
            this.generateEventsToolStripMenuItem.Enabled = false;
            this.generateEventsToolStripMenuItem.Name = "generateEventsToolStripMenuItem";
            this.generateEventsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.generateEventsToolStripMenuItem.Text = "Generate Events";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // viewWrapperToolStripMenuItem
            // 
            this.viewWrapperToolStripMenuItem.Name = "viewWrapperToolStripMenuItem";
            this.viewWrapperToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.viewWrapperToolStripMenuItem.Text = "View Wrapper";
            // 
            // treeviewToolStripMenuItem
            // 
            this.treeviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabularEditorToolStripMenuItem,
            this.xMLEditorToolStripMenuItem,
            this.textEditorToolStripMenuItem,
            this.nodeEditorToolStripMenuItem,
            this.xMLDiagramToolStripMenuItem});
            this.treeviewToolStripMenuItem.Name = "treeviewToolStripMenuItem";
            this.treeviewToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.treeviewToolStripMenuItem.Text = "Editor";
            this.treeviewToolStripMenuItem.Click += new System.EventHandler(this.TreeviewToolStripMenuItemClick);
            // 
            // tabularEditorToolStripMenuItem
            // 
            this.tabularEditorToolStripMenuItem.Name = "tabularEditorToolStripMenuItem";
            this.tabularEditorToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.tabularEditorToolStripMenuItem.Text = "Tabular Editor";
            this.tabularEditorToolStripMenuItem.Click += new System.EventHandler(this.TabularEditorToolStripMenuItemClick);
            // 
            // xMLEditorToolStripMenuItem
            // 
            this.xMLEditorToolStripMenuItem.Name = "xMLEditorToolStripMenuItem";
            this.xMLEditorToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.xMLEditorToolStripMenuItem.Text = "Node+XML Editor";
            this.xMLEditorToolStripMenuItem.Click += new System.EventHandler(this.XMlEditorToolStripMenuItemClick);
            // 
            // textEditorToolStripMenuItem
            // 
            this.textEditorToolStripMenuItem.Name = "textEditorToolStripMenuItem";
            this.textEditorToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.textEditorToolStripMenuItem.Text = "Text Editor";
            // 
            // nodeEditorToolStripMenuItem
            // 
            this.nodeEditorToolStripMenuItem.Name = "nodeEditorToolStripMenuItem";
            this.nodeEditorToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nodeEditorToolStripMenuItem.Text = "Node Editor";
            // 
            // xMLDiagramToolStripMenuItem
            // 
            this.xMLDiagramToolStripMenuItem.Name = "xMLDiagramToolStripMenuItem";
            this.xMLDiagramToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.xMLDiagramToolStripMenuItem.Text = "XML Diagram";
            this.xMLDiagramToolStripMenuItem.Click += new System.EventHandler(this.XMlDiagramToolStripMenuItemClick);
            // 
            // wikiToolStripMenuItem
            // 
            this.wikiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wikiBrowserToolStripMenuItem,
            this.forumBrowserToolStripMenuItem});
            this.wikiToolStripMenuItem.Name = "wikiToolStripMenuItem";
            this.wikiToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.wikiToolStripMenuItem.Text = "Wiki Browser";
            this.wikiToolStripMenuItem.Click += new System.EventHandler(this.WikiToolStripMenuItemClick);
            // 
            // wikiBrowserToolStripMenuItem
            // 
            this.wikiBrowserToolStripMenuItem.Name = "wikiBrowserToolStripMenuItem";
            this.wikiBrowserToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.wikiBrowserToolStripMenuItem.Text = "Wiki Browser";
            // 
            // forumBrowserToolStripMenuItem
            // 
            this.forumBrowserToolStripMenuItem.Name = "forumBrowserToolStripMenuItem";
            this.forumBrowserToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.forumBrowserToolStripMenuItem.Text = "Forum Browser";
            this.forumBrowserToolStripMenuItem.Click += new System.EventHandler(this.ForumBrowserToolStripMenuItemClick);
            // 
            // miscToolStripMenuItem
            // 
            this.miscToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.debugInfoToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem,
            this.showPropertyGridToolStripMenuItem,
            this.hideActionLogToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.miscToolStripMenuItem.Name = "miscToolStripMenuItem";
            this.miscToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.miscToolStripMenuItem.Text = "Misc";
            // 
            // debugInfoToolStripMenuItem
            // 
            this.debugInfoToolStripMenuItem.Name = "debugInfoToolStripMenuItem";
            this.debugInfoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.debugInfoToolStripMenuItem.Text = "Diagnostic Info";
            this.debugInfoToolStripMenuItem.Click += new System.EventHandler(this.DebugInfoToolStripMenuItemClick);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Enabled = false;
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.checkForUpdateToolStripMenuItem.Text = "Check for Update";
            // 
            // showPropertyGridToolStripMenuItem
            // 
            this.showPropertyGridToolStripMenuItem.CheckOnClick = true;
            this.showPropertyGridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainWindowToolStripMenuItem,
            this.actionLogToolStripMenuItem});
            this.showPropertyGridToolStripMenuItem.Name = "showPropertyGridToolStripMenuItem";
            this.showPropertyGridToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.showPropertyGridToolStripMenuItem.Text = "Property Grid";
            this.showPropertyGridToolStripMenuItem.Click += new System.EventHandler(this.ShowPropertyGridToolStripMenuItemClick);
            // 
            // mainWindowToolStripMenuItem
            // 
            this.mainWindowToolStripMenuItem.Name = "mainWindowToolStripMenuItem";
            this.mainWindowToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.mainWindowToolStripMenuItem.Text = "Main Window";
            this.mainWindowToolStripMenuItem.Click += new System.EventHandler(this.MainWindowToolStripMenuItemClick);
            // 
            // actionLogToolStripMenuItem
            // 
            this.actionLogToolStripMenuItem.Name = "actionLogToolStripMenuItem";
            this.actionLogToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.actionLogToolStripMenuItem.Text = "Action Log";
            this.actionLogToolStripMenuItem.Click += new System.EventHandler(this.ActionLogToolStripMenuItemClick);
            // 
            // hideActionLogToolStripMenuItem
            // 
            this.hideActionLogToolStripMenuItem.CheckOnClick = true;
            this.hideActionLogToolStripMenuItem.Name = "hideActionLogToolStripMenuItem";
            this.hideActionLogToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.hideActionLogToolStripMenuItem.Text = "Action Log";
            this.hideActionLogToolStripMenuItem.Click += new System.EventHandler(this.HideActionLogToolStripMenuItemClick);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openXMLToolStripMenuItem,
            this.closeAllWindowToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 48);
            // 
            // openXMLToolStripMenuItem
            // 
            this.openXMLToolStripMenuItem.Name = "openXMLToolStripMenuItem";
            this.openXMLToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openXMLToolStripMenuItem.Text = "Open XML";
            // 
            // closeAllWindowToolStripMenuItem
            // 
            this.closeAllWindowToolStripMenuItem.Name = "closeAllWindowToolStripMenuItem";
            this.closeAllWindowToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.closeAllWindowToolStripMenuItem.Text = "Close All Window";
            this.closeAllWindowToolStripMenuItem.Click += new System.EventHandler(this.CloseAllWindowToolStripMenuItemClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusCurrentAction,
            this.toolStripStatusLabel3,
            this.statusLastAction,
            this.toolStripStatusLabel5,
            this.statusInformation});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 589);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1244, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.StatusStrip1ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(88, 15);
            this.toolStripStatusLabel1.Text = "Current Action:";
            // 
            // statusCurrentAction
            // 
            this.statusCurrentAction.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusCurrentAction.Name = "statusCurrentAction";
            this.statusCurrentAction.Size = new System.Drawing.Size(77, 21);
            this.statusCurrentAction.Text = "(Nothing)";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(69, 15);
            this.toolStripStatusLabel3.Text = "Last Action:";
            // 
            // statusLastAction
            // 
            this.statusLastAction.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusLastAction.Name = "statusLastAction";
            this.statusLastAction.Size = new System.Drawing.Size(77, 21);
            this.statusLastAction.Text = "(Nothing)";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackColor = System.Drawing.Color.DarkOrange;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(73, 15);
            this.toolStripStatusLabel5.Text = "Information:";
            // 
            // statusInformation
            // 
            this.statusInformation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusInformation.Name = "statusInformation";
            this.statusInformation.Size = new System.Drawing.Size(77, 21);
            this.statusInformation.Text = "(Nothing)";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTableProcess,
            this.dataTableEditor});
            // 
            // dataTableProcess
            // 
            this.dataTableProcess.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1});
            this.dataTableProcess.TableName = "tableProcess";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Column1";
            // 
            // dataTableEditor
            // 
            this.dataTableEditor.TableName = "tableEditor";
            // 
            // ActionMemoBox
            // 
            this.ActionMemoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionMemoBox.AutoWordSelection = true;
            this.ActionMemoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ActionMemoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ActionMemoBox.BulletIndent = 1;
            this.ActionMemoBox.ForeColor = System.Drawing.Color.SeaGreen;
            this.ActionMemoBox.Location = new System.Drawing.Point(0, 439);
            this.ActionMemoBox.Margin = new System.Windows.Forms.Padding(4);
            this.ActionMemoBox.Name = "ActionMemoBox";
            this.ActionMemoBox.ReadOnly = true;
            this.ActionMemoBox.Size = new System.Drawing.Size(1245, 124);
            this.ActionMemoBox.TabIndex = 6;
            this.ActionMemoBox.Text = "";
            this.ActionMemoBox.Visible = false;
            this.ActionMemoBox.TextChanged += new System.EventHandler(this.ActionMemoBoxTextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 567);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1244, 22);
            this.progressBar1.TabIndex = 8;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.Location = new System.Drawing.Point(920, 27);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.ActionMemoBox;
            this.propertyGrid1.Size = new System.Drawing.Size(324, 405);
            this.propertyGrid1.TabIndex = 11;
            this.propertyGrid1.Visible = false;
            this.propertyGrid1.Click += new System.EventHandler(this.PropertyGrid1Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SoftwareIncModMaker.Properties.Resources.gu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1244, 615);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.ActionMemoBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("DejaVu Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(464, 399);
            this.Name = "ParentForm";
            this.Text = "Mod Creator: Software Inc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ParentFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem treeviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel statusCurrentAction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel statusLastAction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripStatusLabel statusInformation;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem miscToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateSoftwareTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateScenarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTableProcess;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataTable dataTableEditor;
        private System.Windows.Forms.ToolStripMenuItem viewWrapperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabularEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nodeEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLDiagramToolStripMenuItem;
        private System.Windows.Forms.RichTextBox ActionMemoBox;
        public System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripMenuItem closeAllWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wikiBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem forumBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideActionLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPropertyGridToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ToolStripMenuItem mainWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionLogToolStripMenuItem;
    }
}

