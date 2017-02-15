namespace SoftwareIncModMaker
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Xml;
    using System.Xml.Linq;

    using ScintillaNET;

    public partial class XmlEditorForm : Form
    {
        private string nodeEditLabelHistory;

        private IMdiParentAccess statusAccess;

        private string xmlName;

        public XmlEditorForm(IMdiParentAccess handler)
        {
            this.statusAccess = handler;

            // Apply code highlight
            this.InitializeComponent();
            this.nodeEditTimer.Start();
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                // Check if the XmlNode has attributes
                foreach (XmlAttribute att in inXmlNode.Attributes) inTreeNode.Text = inTreeNode.Text + " [Attr]" + att.Name + ": " + att.Value;

                var nodeList = inXmlNode.ChildNodes;
                for (var i = 0; i < nodeList.Count; i++)
                {
                    var xNode = inXmlNode.ChildNodes[i];
                    var tNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(xNode.Name))];
                    this.AddNode(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = inXmlNode.OuterXml.Trim();
            }

            this.softwareTree.ExpandAll();
        }

        private void AddXmlNodes(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;

            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (var i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    this.AddXmlNodes(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.InnerText;
            }
        }

        private void BuildNodes(TreeNode treeNode, XElement element)
        {
            foreach (var child in element.Nodes())
                switch (child.NodeType)
                {
                    case XmlNodeType.Element:
                        var childElement = child as XElement;
                        var childTreeNode = new TreeNode(childElement.Name.LocalName);
                        treeNode.Nodes.Add(childTreeNode);
                        this.BuildNodes(childTreeNode, childElement);
                        break;
                    case XmlNodeType.Text:
                        var childText = child as XText;
                        treeNode.Nodes.Add(new TreeNode(childText.Value));
                        break;
                }
        }

        private void BuildTree(TreeView treeView, XDocument doc)
        {
            var treeNode = new TreeNode(doc.Root.Name.LocalName);
            treeView.Nodes.Add(treeNode);
            this.BuildNodes(treeNode, doc.Root);
        }

        private void ClickClear(object sender, EventArgs args)
        {
            ActionHistory.SetStatus("Clearing Text in Editor");
            this.scintilla1.Clear();
        }

        private void ClickCopy(object sender, EventArgs args)
        {
            ActionHistory.SetStatus("Copied Text From Editor");
            this.scintilla1.Copy();
        }

        private void ClickCut(object sender, EventArgs args)
        {
            ActionHistory.SetStatus("Cut Text From Editor");
            this.scintilla1.Cut();
        }

        private void ClickPaste(object sender, EventArgs args)
        {
            ActionHistory.SetStatus("Pasted Text To Editor");
            this.scintilla1.Paste();
        }

        private void ClickRedo(object sender, EventArgs args)
        {
            ActionHistory.SetStatus("Redo Text in Editor");
            this.scintilla1.Redo();
        }

        private void ClickSelectAll(object sender, EventArgs args)
        {
            ActionHistory.SetStatus("Select all Text in Editor");
            this.scintilla1.SelectAll();
        }

        private void ClickUndo(object sender, EventArgs args)
        {
            ActionHistory.SetStatus("Undo Text in Editor");
            this.scintilla1.Undo();
        }

        private void CollapseAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.softwareTree.CollapseAll();
        }

        private void CollapseHighlightedToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.softwareTree.SelectedNode.Collapse();
        }

        private void DeleteAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            ActionHistory.StartAction();
            ActionHistory.SetStatus("Deleting Node");
            ActionHistory.EndAction();
            this.softwareTree.Nodes.Clear();
        }

        private void DeleteNodeToolStripMenuItemClick1(object sender, EventArgs e)
        {
            this.softwareTree.SelectedNode.Remove();
        }

        private void EditNodeToolStripMenuItemClick(object sender, EventArgs e)
        {
            var selectedNode = this.softwareTree.SelectedNode;
            this.GetBeforeEditedLabel(ref this.nodeEditLabelHistory);
            if (selectedNode != null && selectedNode.Parent != null)
            {
                this.softwareTree.SelectedNode = selectedNode;
                this.softwareTree.LabelEdit = true;
                if (!selectedNode.IsEditing) selectedNode.BeginEdit();
            }
            else
            {
                MessageBox.Show("Editing Parent node is not possible");
            }
        }

        private void EditorFormActivated(object sender, EventArgs e)
        {
        }

        private void EditorFormOnClose(object sender, FormClosingEventArgs e)
        {
            var messageBoxCs = new StringBuilder();
            messageBoxCs.AppendFormat("{0} = {1}", "CloseReason", e.CloseReason);
            messageBoxCs.AppendLine();
            messageBoxCs.AppendFormat("{0} = {1}", "Cancel", e.Cancel);
            messageBoxCs.AppendLine();
            MessageBox.Show(messageBoxCs.ToString(), "Closing Editor");
        }

        private void ExpandAllToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.softwareTree.ExpandAll();
        }

        private void ExpandHighlightedToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.softwareTree.SelectedNode.Expand();
        }

        private void Form3Load(object sender, EventArgs e)
        {
            this.autocompleteMenu1.TargetControlWrapper = new ScintillaWrapper(this.scintilla1);
            ScintillaStyling.ScintillaStyleApply(ref this.scintilla1);
            ScintillaSnippet.BuildAutocompleteMenu(this.autocompleteMenu1);
        }

        private string GetBeforeEditedLabel()
        {
            return this.softwareTree.SelectedNode.Text;
        }

        private string GetBeforeEditedLabel(ref string referencedVariable)
        {
            return referencedVariable = this.softwareTree.SelectedNode.Text;
        }

        private void NodeDelClick(object sender, EventArgs e)
        {
            this.softwareTree.SelectedNode.Remove();
        }

        private void NodeDownClick(object sender, EventArgs e)
        {
        }

        private void NodeEditTimerTick(object sender, EventArgs e)
        {
            // if(softwareTree.node)
            // statusInformation.Text = softwareTree.SelectedNode.Text;
        }

        private void OpenFileDialog1FileOk(object sender, CancelEventArgs e)
        {
            this.xmlName = this.openFileDialog1.FileName;
            this.ParseToTreeView();
            var dom = new XmlDocument();
            dom.Load(this.xmlName);
            this.AddNode(dom.DocumentElement, this.softwareTree.Nodes[0]);
            ActionHistory.SetStatus("Opened XML", this.xmlName);
        }

        private void ParseNode(TreeNode tn)
        {
            var x = new List<string>();
            var ie = tn.Nodes.GetEnumerator();

            var parentnode = string.Empty;

            parentnode = tn.Text;

            while (ie.MoveNext())
            {
                var ctn = (TreeNode)ie.Current;

                if (ctn.GetNodeCount(true) == 0) x.Add(ctn.Text);
                else x.Add("<" + ctn.Text + ">\n");
                if (ctn.GetNodeCount(true) > 0) this.ParseNode(ctn);
            }

            x.Add("</" + parentnode + ">\n");
            x.Add(string.Empty);
            this.scintilla1.Text = string.Join(string.Empty, x.ToArray());
        }

        private void ParseToTreeView()
        {
            // XmlDataDocument xmlData = new XmlDataDocument();
            // FileStream fs = new FileStream(xmlName, FileMode.Open, FileAccess.ReadWrite);
            // xmlData.Load(fs);
            /**XmlNode xNode;
            xNode = xmlData.ChildNodes[1];
            softwareTree.Nodes.Clear();
            softwareTree.Nodes.Add(new TreeNode(xmlData.DocumentElement.Name));
            TreeNode tNode;
            tNode = softwareTree.Nodes[0];
            addXmlNodes(xNode, tNode);**/
            // var Loaded = XDocument.Parse(xmlData.Load(fs));
            this.softwareTree.Nodes.Clear();
            this.BuildTree(this.softwareTree, XDocument.Load(this.xmlName));
            var sourcecode = XDocument.Load(this.xmlName).ToString();

            // string colorized = new CodeColorizer().Colorize(sourcecode, Languages.Xml);
            this.scintilla1.Text = XDocument.Load(this.xmlName).ToString();
        }

        private void Scintilla1CharAdded(object sender, CharAddedEventArgs e)
        {
            // Find the word start
            var currentPos = this.scintilla1.CurrentPosition;
            var wordStartPos = this.scintilla1.WordStartPosition(currentPos, true);

            // Display the autocompletion list
            var lenEntered = currentPos - wordStartPos;
            if (lenEntered > 0) if (!this.scintilla1.AutoCActive) this.scintilla1.AutoCShow(lenEntered, "<Name></Name>");
        }

        private void Scintilla1Click(object sender, EventArgs e)
        {
        }

        private void Scintilla1Load(object sender, EventArgs e)
        {
            ScintillaStyling.ScintillaStyleApply(ref this.scintilla1);
        }

        private void Scintilla1TextChanged(object sender, EventArgs e)
        {
            ScintillaStyling.ScintillaLineNumber(ref this.scintilla1);
        }

        private void SoftwareTreeAfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            ActionHistory.EndAction();
            if (e.Label != null)
            {
                this.softwareTree.SelectedNode.Text = e.Label;
            }
            else
            {
                e.CancelEdit = true;
                e.Node.Text = this.GetBeforeEditedLabel();
                MessageBox.Show("Invalid tree node label");
            }
        }

        private void SoftwareTreeBeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            ActionHistory.StartAction();
            ActionHistory.SetStatus("Tree Editing");
        }

        private void SoftwareTreeMouseDown(object sender, MouseEventArgs e)
        {
            UserInterfaceController.RightClickMenu(this.softwareTreeToolStripMenu, e);
        }

        private void StatusWrapper()
        {
        }

        private void TableLayoutPanel1Paint(object sender, PaintEventArgs e)
        {
        }

        private void ToolStripButton1Click(object sender, EventArgs e)
        {
            var folderName = "Software Inc.\\Mods";
            this.openFileDialog1.InitialDirectory = "C:\\Games\\Steam\\steamapps\\common\\" + folderName;
            this.openFileDialog1.ShowDialog();
        }

        private void TreeView1AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void ViewRawxmlToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.ParseNode(this.softwareTree.SelectedNode);
        }

        private void Xml2TreeNode(XElement xNode, TreeNode treeNode)
        {
            if (xNode.HasElements)
            {
                // if node has children
                TreeNode tNode = null;
                var i = 0;
                foreach (var subNode in xNode.Elements())
                {
                    if (subNode.Descendants().Count() > 0)
                    {
                        // handle non-leaf node
                        var tn = treeNode.Nodes.Add(subNode.Name.ToString().Trim());

                        ////tn.Nodes.Add(new TreeNode(subNode.FirstNode.ToString().Trim())); //adds extra element-value to node
                        tn.Tag = treeNode.Nodes[i].Tag = subNode.Attributes().ToList();

                        // ---->these values are retrived in TreeNode2Xml function
                        tNode = tn; // add child nodes
                    }
                    else
                    {
                        // handle leaf node
                        var tn = treeNode.Nodes.Add(subNode.Name.ToString().Trim()); // show name of a leaf node element
                        tn.Nodes.Add(new TreeNode(subNode.Value.Trim()));

                        // show value of above element as a child of its name
                        tn.Tag = treeNode.Nodes[i].Tag = subNode.Attributes().ToList();

                        // ---->these values are retrived in TreeNode2Xml function
                        tNode = treeNode.Nodes[i++]; // add sibling node
                    }

                    this.Xml2TreeNode(subNode, tNode); // recursively add child nodes
                }
            }
        }
    }
}