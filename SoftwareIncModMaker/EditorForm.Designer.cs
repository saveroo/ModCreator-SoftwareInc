namespace SoftwareIncModMaker
{
    partial class XmlEditorForm
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
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Name");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Category");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Description");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Random");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Node10");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Category", new System.Windows.Forms.TreeNode[] {
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44,
            treeNode45,
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Categories", new System.Windows.Forms.TreeNode[] {
            treeNode47});
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Node15");
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Node16");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Node17");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Node19");
            System.Windows.Forms.TreeNode treeNode53 = new System.Windows.Forms.TreeNode("Features", new System.Windows.Forms.TreeNode[] {
            treeNode52});
            System.Windows.Forms.TreeNode treeNode54 = new System.Windows.Forms.TreeNode("Software Type", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode48,
            treeNode49,
            treeNode50,
            treeNode51,
            treeNode53});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XmlEditorForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.softwareTree = new System.Windows.Forms.TreeView();
            this.scintilla1 = new ScintillaNET.Scintilla();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
            this.nodeEditTimer = new System.Windows.Forms.Timer(this.components);
            this.textEditorContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertToTreeViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.softwareTreeToolStripMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.textEditorContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.softwareTree, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.scintilla1, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 482);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1Paint);
            // 
            // softwareTree
            // 
            this.softwareTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.softwareTree.Location = new System.Drawing.Point(3, 31);
            this.softwareTree.Name = "softwareTree";
            treeNode37.Name = "nodeName";
            treeNode37.Text = "Name";
            treeNode38.Name = "nodeCategory";
            treeNode38.Text = "Category";
            treeNode39.Name = "nodeDescriptionRoot";
            treeNode39.Text = "Description";
            treeNode40.Name = "nodeRandom";
            treeNode40.Text = "Random";
            treeNode41.Name = "Node8";
            treeNode41.Text = "Node8";
            treeNode42.Name = "Node9";
            treeNode42.Text = "Node9";
            treeNode43.Name = "Node10";
            treeNode43.Text = "Node10";
            treeNode44.Name = "Node11";
            treeNode44.Text = "Node11";
            treeNode45.Name = "Node12";
            treeNode45.Text = "Node12";
            treeNode46.Name = "Node7";
            treeNode46.Text = "Node7";
            treeNode47.Name = "Node6";
            treeNode47.Tag = "Name";
            treeNode47.Text = "Category";
            treeNode48.Name = "nodeCategories";
            treeNode48.Text = "Categories";
            treeNode49.Name = "Node15";
            treeNode49.Text = "Node15";
            treeNode50.Name = "Node16";
            treeNode50.Text = "Node16";
            treeNode51.Name = "Node17";
            treeNode51.Text = "Node17";
            treeNode52.Name = "Node19";
            treeNode52.Text = "Node19";
            treeNode53.Name = "nodeFeatures";
            treeNode53.Tag = "";
            treeNode53.Text = "Features";
            treeNode54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            treeNode54.Name = "Node0";
            treeNode54.Text = "Software Type";
            this.softwareTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode54});
            this.softwareTree.Size = new System.Drawing.Size(942, 177);
            this.softwareTree.TabIndex = 0;
            this.softwareTree.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.SoftwareTreeBeforeLabelEdit);
            this.softwareTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.SoftwareTreeAfterLabelEdit);
            this.softwareTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1AfterSelect);
            this.softwareTree.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SoftwareTreeMouseDown);
            // 
            // scintilla1
            // 
            this.scintilla1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scintilla1.ContextMenuStrip = this.textEditorContextMenu;
            this.scintilla1.EdgeColor = System.Drawing.Color.IndianRed;
            this.scintilla1.EdgeMode = ScintillaNET.EdgeMode.Line;
            this.scintilla1.FontQuality = ScintillaNET.FontQuality.LcdOptimized;
            this.scintilla1.Lexer = ScintillaNET.Lexer.Xml;
            this.scintilla1.Location = new System.Drawing.Point(3, 234);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(942, 245);
            this.scintilla1.TabIndex = 1;
            this.scintilla1.Text = "Boom Boom Paw";
            this.scintilla1.UseTabs = true;
            this.scintilla1.ViewWhitespace = ScintillaNET.WhitespaceMode.VisibleAfterIndent;
            this.scintilla1.TextChanged += new System.EventHandler(this.Scintilla1TextChanged);
            this.scintilla1.Click += new System.EventHandler(this.Scintilla1Click);
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
            this.editNodeToolStripMenuItem.Click += new System.EventHandler(this.EditNodeToolStripMenuItemClick);
            // 
            // deleteNodeToolStripMenuItem
            // 
            this.deleteNodeToolStripMenuItem.Name = "deleteNodeToolStripMenuItem";
            this.deleteNodeToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteNodeToolStripMenuItem.Text = "Delete Node";
            this.deleteNodeToolStripMenuItem.Click += new System.EventHandler(this.DeleteNodeToolStripMenuItemClick1);
            // 
            // deleteAllToolStripMenuItem
            // 
            this.deleteAllToolStripMenuItem.Name = "deleteAllToolStripMenuItem";
            this.deleteAllToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.deleteAllToolStripMenuItem.Text = "Delete All";
            this.deleteAllToolStripMenuItem.Click += new System.EventHandler(this.DeleteAllToolStripMenuItemClick);
            // 
            // expandHighlightedToolStripMenuItem
            // 
            this.expandHighlightedToolStripMenuItem.Name = "expandHighlightedToolStripMenuItem";
            this.expandHighlightedToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.expandHighlightedToolStripMenuItem.Text = "Expand";
            this.expandHighlightedToolStripMenuItem.Click += new System.EventHandler(this.ExpandHighlightedToolStripMenuItemClick);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.ExpandAllToolStripMenuItemClick);
            // 
            // collapseHighlightedToolStripMenuItem
            // 
            this.collapseHighlightedToolStripMenuItem.Name = "collapseHighlightedToolStripMenuItem";
            this.collapseHighlightedToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.collapseHighlightedToolStripMenuItem.Text = "Collapse";
            this.collapseHighlightedToolStripMenuItem.Click += new System.EventHandler(this.CollapseHighlightedToolStripMenuItemClick);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.CollapseAllToolStripMenuItemClick);
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
            this.viewRAWXMLToolStripMenuItem.Click += new System.EventHandler(this.ViewRawxmlToolStripMenuItemClick);
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
            this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1FileOk);
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
            this.nodeEditTimer.Tick += new System.EventHandler(this.NodeEditTimerTick);
            // 
            // textEditorContextMenu
            // 
            this.textEditorContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.convertToTreeViewToolStripMenuItem,
            this.deleteLineToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.textEditorContextMenu.Name = "textEditorContextMenu";
            this.textEditorContextMenu.Size = new System.Drawing.Size(123, 180);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.ClickCopy);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.ClickPaste);
            // 
            // convertToTreeViewToolStripMenuItem
            // 
            this.convertToTreeViewToolStripMenuItem.Name = "convertToTreeViewToolStripMenuItem";
            this.convertToTreeViewToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.convertToTreeViewToolStripMenuItem.Text = "Cut";
            this.convertToTreeViewToolStripMenuItem.Click += new System.EventHandler(this.ClickCut);
            // 
            // deleteLineToolStripMenuItem
            // 
            this.deleteLineToolStripMenuItem.Name = "deleteLineToolStripMenuItem";
            this.deleteLineToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteLineToolStripMenuItem.Text = "Select All";
            this.deleteLineToolStripMenuItem.Click += new System.EventHandler(this.ClickSelectAll);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClickClear);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.ClickUndo);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.ClickRedo);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.featureToolStripMenuItem,
            this.categoryToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // featureToolStripMenuItem
            // 
            this.featureToolStripMenuItem.Name = "featureToolStripMenuItem";
            this.featureToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.featureToolStripMenuItem.Text = "Feature";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoryToolStripMenuItem.Text = "Category";
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
            this.Activated += new System.EventHandler(this.EditorFormActivated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditorFormOnClose);
            this.Load += new System.EventHandler(this.Form3Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.softwareTreeToolStripMenu.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.textEditorContextMenu.ResumeLayout(false);
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
        private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
        private System.Windows.Forms.ToolStripMenuItem expandHighlightedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseHighlightedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Timer nodeEditTimer;
        public ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.ContextMenuStrip textEditorContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToTreeViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem featureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
    }
}