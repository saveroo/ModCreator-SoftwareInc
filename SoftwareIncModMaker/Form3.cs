using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.IO;
using ScintillaNET;
using System.Text.RegularExpressions;
using System.Collections;
using AutocompleteMenuNS;

namespace SoftwareIncModMaker
{
    public partial class Form3 : Form
    {
        String xmlName;
        String nodeEditLabelHistory;

        public Form3()
        {

            InitializeComponent();
            nodeEditTimer.Start();
            ActionHistory.labelControl.Add(statusCurrentAction);
            ActionHistory.labelControl.Add(statusLastAction);
            ActionHistory.labelControl.Add(statusInformation);


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void nodeDel_Click(object sender, EventArgs e)
        {
            softwareTree.SelectedNode.Remove();
        }

        private void nodeDown_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            String folderName = "Software Inc.\\Mods";
            openFileDialog1.InitialDirectory = "C:\\Games\\Steam\\steamapps\\common\\" + folderName;
            openFileDialog1.ShowDialog();
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.

            if (inXmlNode.HasChildNodes)
            {
                //Check if the XmlNode has attributes
                foreach (XmlAttribute att in inXmlNode.Attributes)
                {
                    inTreeNode.Text = inTreeNode.Text + " [Attr]" + att.Name + ": " + att.Value;
                }

                var nodeList = inXmlNode.ChildNodes;
                for (int i = 0; i < nodeList.Count; i++)
                {
                    var xNode = inXmlNode.ChildNodes[i];
                    var tNode = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(xNode.Name))];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
            softwareTree.ExpandAll();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            xmlName = openFileDialog1.FileName;
            parseToTreeView();
            XmlDocument dom = new XmlDocument();
            dom.Load(@xmlName);
            AddNode(dom.DocumentElement, softwareTree.Nodes[0]);
        }



        private void parseToTreeView()
        {
            //XmlDataDocument xmlData = new XmlDataDocument();
            //FileStream fs = new FileStream(xmlName, FileMode.Open, FileAccess.ReadWrite);
            //xmlData.Load(fs);
            /**XmlNode xNode;
            xNode = xmlData.ChildNodes[1];
            softwareTree.Nodes.Clear();
            softwareTree.Nodes.Add(new TreeNode(xmlData.DocumentElement.Name));
            TreeNode tNode;
            tNode = softwareTree.Nodes[0];
            addXmlNodes(xNode, tNode);**/
            //var Loaded = XDocument.Parse(xmlData.Load(fs));
            softwareTree.Nodes.Clear();
            BuildTree(softwareTree, XDocument.Load(@xmlName));
            string sourcecode = XDocument.Load(@xmlName).ToString();
            //string colorized = new CodeColorizer().Colorize(sourcecode, Languages.Xml);
            scintilla1.Lexer = Lexer.Xml;
            scintilla1.Styles[Style.Xml.SingleString].Font = "consolas";
            scintilla1.Styles[Style.Xml.SingleString].Size = 12;
            scintilla1.Styles[Style.Xml.Tag].ForeColor = Color.FromKnownColor(KnownColor.Green);
            scintilla1.Styles[Style.Xml.Value].ForeColor = Color.FromKnownColor(KnownColor.IndianRed);
            scintilla1.Styles[Style.Xml.Number].ForeColor = Color.FromKnownColor(KnownColor.Red);

            scintilla1.Margins[2].Type = MarginType.Symbol;
            scintilla1.Margins[2].Mask = Marker.MaskFolders;
            scintilla1.Margins[2].Sensitive = true;
            scintilla1.Margins[2].Width = 20;

            for (int i = 25; i <= 31; i++)
            {
                scintilla1.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla1.Markers[i].SetBackColor(SystemColors.ControlDark);
            }
            scintilla1.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla1.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla1.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla1.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla1.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla1.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla1.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            scintilla1.SetProperty("fold", "1");
            scintilla1.SetProperty("fold.compact", "1");
            scintilla1.SetProperty("fold.html", "1");
            scintilla1.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
            scintilla1.Text = XDocument.Load(@xmlName).ToString();
        }

        private void BuildTree(TreeView treeView, XDocument doc)
        {
            TreeNode treeNode = new TreeNode(doc.Root.Name.LocalName);
            treeView.Nodes.Add(treeNode);
            BuildNodes(treeNode, doc.Root);
        }

        private void BuildNodes(TreeNode treeNode, XElement element)
        {
            foreach (XNode child in element.Nodes())
            {
                switch (child.NodeType)
                {
                    case XmlNodeType.Element:
                        XElement childElement = child as XElement;
                        TreeNode childTreeNode = new TreeNode(childElement.Name.LocalName);
                        treeNode.Nodes.Add(childTreeNode);
                        BuildNodes(childTreeNode, childElement);
                        break;
                    case XmlNodeType.Text:
                        XText childText = child as XText;
                        treeNode.Nodes.Add(new TreeNode(childText.Value));
                        break;
                }
            }
        }

        private void addXmlNodes(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;

            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (int i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    addXmlNodes(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.InnerText.ToString();
            }
        }

        private void softwareTree_MouseDown(object sender, MouseEventArgs e)
        {
            UserInterfaceController.rightClickMenu(softwareTreeToolStripMenu, e);
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            softwareTree.CollapseAll();
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            softwareTree.ExpandAll();
        }

 
        private void deleteNodeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            softwareTree.SelectedNode.Remove();
        }

        private void Xml2TreeNode(XElement xNode, TreeNode treeNode)
        {
            if (xNode.HasElements) //if node has children
            {
                TreeNode tNode = null;
                int i = 0;
                foreach (XElement subNode in xNode.Elements())
                {
                    if (subNode.Descendants().Count() > 0)
                    {//handle non-leaf node
                        TreeNode tn = treeNode.Nodes.Add(subNode.Name.ToString().Trim());
                        ////tn.Nodes.Add(new TreeNode(subNode.FirstNode.ToString().Trim())); //adds extra element-value to node
                        tn.Tag = treeNode.Nodes[i].Tag = subNode.Attributes().ToList(); //---->these values are retrived in TreeNode2Xml function
                        tNode = tn; //add child nodes
                    }
                    else
                    {//handle leaf node
                        TreeNode tn = treeNode.Nodes.Add(subNode.Name.ToString().Trim()); //show name of a leaf node element
                        tn.Nodes.Add(new TreeNode(subNode.Value.ToString().Trim())); //show value of above element as a child of its name
                        tn.Tag = treeNode.Nodes[i].Tag = subNode.Attributes().ToList(); //---->these values are retrived in TreeNode2Xml function
                        tNode = treeNode.Nodes[i++]; //add sibling node
                    }

                    Xml2TreeNode(subNode, tNode); //recursively add child nodes
                }
            }
        }


        private void parseNode(TreeNode tn)
        {
            List<String> x = new List<String>();
            IEnumerator ie = tn.Nodes.GetEnumerator();

            string parentnode = "";

            parentnode = tn.Text;

            while (ie.MoveNext())
            {
                TreeNode ctn = (TreeNode)ie.Current;
                
                if (ctn.GetNodeCount(true) == 0)
                {
                    x.Add(ctn.Text);
                }
                else
                {
                    x.Add("<" + ctn.Text + ">\n");
                }
                if (ctn.GetNodeCount(true) > 0)
                {
                    parseNode(ctn);
                }
            }

            x.Add("</" + parentnode + ">\n");
            x.Add("");
            scintilla1.Text = string.Join(string.Empty, x.ToArray());
        }


        private void viewRAWXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            parseNode(softwareTree.SelectedNode);
        }

        private void scintilla1_Click(object sender, EventArgs e)
        {

        }

        private void scintilla1_CharAdded(object sender, CharAddedEventArgs e)
        {
          
            // Find the word start
            var currentPos = scintilla1.CurrentPosition;
            var wordStartPos = scintilla1.WordStartPosition(currentPos, true);

            // Display the autocompletion list
            var lenEntered = currentPos - wordStartPos;
            if (lenEntered > 0)
            {
                if (!scintilla1.AutoCActive)
                    scintilla1.AutoCShow(lenEntered, "<Name></Name>");
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            autocompleteMenu1.TargetControlWrapper = new ScintillaWrapper(scintilla1);
            ScintillaSnippet.BuildAutocompleteMenu(autocompleteMenu1);
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionHistory.startAction();
            ActionHistory.setStatus("Deleting Node");
            ActionHistory.endAction();
            softwareTree.Nodes.Clear();
        }

        private void expandHighlightedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            softwareTree.SelectedNode.Expand();
        }

        private void collapseHighlightedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            softwareTree.SelectedNode.Collapse();
        }

        private void editNodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedNode = softwareTree.SelectedNode;
            getBeforeEditedLabel(ref nodeEditLabelHistory);
            if(selectedNode != null && selectedNode.Parent != null)
            {
                softwareTree.SelectedNode = selectedNode;
                softwareTree.LabelEdit = true;
                if (!selectedNode.IsEditing)
                {
                    selectedNode.BeginEdit();
                }
            }
            else
            {
                MessageBox.Show("Editing Parent node is not possible");
            }
        }

        private string getBeforeEditedLabel()
        {
            return softwareTree.SelectedNode.Text;
        }

        private string getBeforeEditedLabel(ref string referencedVariable)
        {
            return referencedVariable = softwareTree.SelectedNode.Text;
        }

        private void softwareTree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            ActionHistory.endAction();
            if (e.Label != null)
            {
                softwareTree.SelectedNode.Text = e.Label;
            }
            else
            {
                e.CancelEdit = true;
                e.Node.Text = getBeforeEditedLabel();
                MessageBox.Show("Invalid tree node label");
                
            }
        }

        private void statusWrapper()
        {
            
        }

        private void nodeEditTimer_Tick(object sender, EventArgs e)
        {
            // if(softwareTree.node)
            // statusInformation.Text = softwareTree.SelectedNode.Text;

        }

        private void softwareTree_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            ActionHistory.startAction();
            ActionHistory.setStatus("Tree Editing");

        }
    }

}
