namespace SoftwareIncModMaker
{
    partial class EditorForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Name");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Category");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Description");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Random");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Category", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Categories", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Node15");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Node16");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Node17");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node19");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Features", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Software Type", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode17});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.softwareTree = new System.Windows.Forms.TreeView();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusCurrentAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusInformation = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.softwareTreeToolStripMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NodesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandHighlightedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseHighlightedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.viewRAWXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.nodeEditTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.softwareTreeToolStripMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.softwareTree, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.scintilla1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 482);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // softwareTree
            // 
            this.softwareTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.softwareTree.Location = new System.Drawing.Point(3, 31);
            this.softwareTree.Name = "softwareTree";
            treeNode1.Name = "nodeName";
            treeNode1.Text = "Name";
            treeNode2.Name = "nodeCategory";
            treeNode2.Text = "Category";
            treeNode3.Name = "nodeDescriptionRoot";
            treeNode3.Text = "Description";
            treeNode4.Name = "nodeRandom";
            treeNode4.Text = "Random";
            treeNode5.Name = "Node8";
            treeNode5.Text = "Node8";
            treeNode6.Name = "Node9";
            treeNode6.Text = "Node9";
            treeNode7.Name = "Node10";
            treeNode7.Text = "Node10";
            treeNode8.Name = "Node11";
            treeNode8.Text = "Node11";
            treeNode9.Name = "Node12";
            treeNode9.Text = "Node12";
            treeNode10.Name = "Node7";
            treeNode10.Text = "Node7";
            treeNode11.Name = "Node6";
            treeNode11.Tag = "Name";
            treeNode11.Text = "Category";
            treeNode12.Name = "nodeCategories";
            treeNode12.Text = "Categories";
            treeNode13.Name = "Node15";
            treeNode13.Text = "Node15";
            treeNode14.Name = "Node16";
            treeNode14.Text = "Node16";
            treeNode15.Name = "Node17";
            treeNode15.Text = "Node17";
            treeNode16.Name = "Node19";
            treeNode16.Text = "Node19";
            treeNode17.Name = "nodeFeatures";
            treeNode17.Tag = "";
            treeNode17.Text = "Features";
            treeNode18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            treeNode18.Name = "Node0";
            treeNode18.Text = "Software Type";
            this.softwareTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.softwareTree.Size = new System.Drawing.Size(942, 177);
            this.softwareTree.TabIndex = 0;
            this.softwareTree.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.softwareTree_BeforeLabelEdit);
            this.softwareTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.softwareTree_AfterLabelEdit);
            this.softwareTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.softwareTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.softwareTree_MouseDown);
            // 
            // scintilla1
            // 
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.FontQuality = ScintillaNET.FontQuality.LcdOptimized;
            this.scintilla1.Lexer = ScintillaNET.Lexer.Xml;
            this.scintilla1.Location = new System.Drawing.Point(3, 234);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(942, 245);
            this.scintilla1.TabIndex = 1;
            this.scintilla1.Text = "scintilla1";
            this.scintilla1.CharAdded += new System.EventHandler<ScintillaNET.CharAddedEventArgs>(this.scintilla1_CharAdded);
            this.scintilla1.Click += new System.EventHandler(this.scintilla1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusCurrentAction,
            this.toolStripStatusLabel3,
            this.statusLastAction,
            this.toolStripStatusLabel5,
            this.statusInformation});
            this.statusStrip1.Location = new System.Drawing.Point(0, 211);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(948, 20);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
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
            this.statusCurrentAction.Name = "statusCurrentAction";
            this.statusCurrentAction.Size = new System.Drawing.Size(118, 15);
            this.statusCurrentAction.Text = "toolStripStatusLabel2";
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
            this.statusLastAction.Name = "statusLastAction";
            this.statusLastAction.Size = new System.Drawing.Size(118, 15);
            this.statusLastAction.Text = "toolStripStatusLabel4";
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
            this.statusInformation.Name = "statusInformation";
            this.statusInformation.Size = new System.Drawing.Size(118, 15);
            this.statusInformation.Text = "toolStripStatusLabel6";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(948, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(83, 22);
            this.toolStripButton1.Text = "Open XML";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // softwareTreeToolStripMenu
            // 
            this.softwareTreeToolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NodesToolStripMenuItem1,
            this.expandHighlightedToolStripMenuItem,
            this.expandAllToolStripMenuItem,
            this.collapseHighlightedToolStripMenuItem,
            this.collapseAllToolStripMenuItem,
            this.toolStripSeparator1,
            this.viewRAWXMLToolStripMenuItem});
            this.softwareTreeToolStripMenu.Name = "softwareTreeToolStripMenu";
            this.softwareTreeToolStripMenu.Size = new System.Drawing.Size(155, 142);
            // 
            // NodesToolStripMenuItem1
            // 
            this.NodesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNodeToolStripMenuItem,
            this.editNodeToolStripMenuItem,
            this.deleteNodeToolStripMenuItem,
            this.deleteAllToolStripMenuItem});
            this.NodesToolStripMenuItem1.Name = "NodesToolStripMenuItem1";
            this.NodesToolStripMenuItem1.Size = new System.Drawing.Size(154, 22);
            this.NodesToolStripMenuItem1.Text = "Nodes";
            // 
            // addNodeToolStripMenuItem
            // 
            this.addNodeToolStripMenuItem.Name = "addNodeToolStripMenuItem";
            this.addNodeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.addNodeToolStripMenuItem.Text = "Add Node";
            // 
            // editNodeToolStripMenuItem
            // 
            this.editNodeToolStripMenuItem.Name = "editNodeToolStripMenuItem";
            this.editNodeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.editNodeToolStripMenuItem.Text = "Edit Node";
            this.editNodeToolStripMenuItem.Click += new System.EventHandler(this.editNodeToolStripMenuItem_Click);
            // 
            // deleteNodeToolStripMenuItem
            // 
            this.deleteNodeToolStripMenuItem.Name = "deleteNodeToolStripMenuItem";
            this.deleteNodeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteNodeToolStripMenuItem.Text = "Delete Node";
            this.deleteNodeToolStripMenuItem.Click += new System.EventHandler(this.deleteNodeToolStripMenuItem_Click_1);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete All";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.deleteAllToolStripMenuItem_Click);
            // 
            // expandHighlightedToolStripMenuItem
            // 
            this.expandHighlightedToolStripMenuItem.Name = "expandHighlightedToolStripMenuItem";
            this.expandHighlightedToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.expandHighlightedToolStripMenuItem.Text = "Expand";
            this.expandHighlightedToolStripMenuItem.Click += new System.EventHandler(this.expandHighlightedToolStripMenuItem_Click);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // collapseHighlightedToolStripMenuItem
            // 
            this.collapseHighlightedToolStripMenuItem.Name = "collapseHighlightedToolStripMenuItem";
            this.collapseHighlightedToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.collapseHighlightedToolStripMenuItem.Text = "Collapse";
            this.collapseHighlightedToolStripMenuItem.Click += new System.EventHandler(this.collapseHighlightedToolStripMenuItem_Click);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(151, 6);
            // 
            // viewRAWXMLToolStripMenuItem
            // 
            this.viewRAWXMLToolStripMenuItem.Name = "viewRAWXMLToolStripMenuItem";
            this.viewRAWXMLToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.viewRAWXMLToolStripMenuItem.Text = "View RAW XML";
            this.viewRAWXMLToolStripMenuItem.Click += new System.EventHandler(this.viewRAWXMLToolStripMenuItem_Click);
            // 
            // autocompleteMenu1
            // 
            this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
            this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.autocompleteMenu1.ImageList = null;
            this.autocompleteMenu1.Items = new string[] {
        "<Name>",
        "<Feature>"};
            this.autocompleteMenu1.TargetControlWrapper = null;
            // 
            // nodeEditTimer
            // 
            this.nodeEditTimer.Enabled = true;
            this.nodeEditTimer.Tick += new System.EventHandler(this.nodeEditTimer_Tick);
            // 
            // EditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 482);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditorForm";
            this.Text = "Editor Window";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.softwareTreeToolStripMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView softwareTree;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip softwareTreeToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NodesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRAWXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private ScintillaNET.Scintilla scintilla1;
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.ToolStripMenuItem expandHighlightedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseHighlightedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer nodeEditTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripStatusLabel statusCurrentAction;
        public System.Windows.Forms.ToolStripStatusLabel statusLastAction;
        public System.Windows.Forms.ToolStripStatusLabel statusInformation;
    }
}