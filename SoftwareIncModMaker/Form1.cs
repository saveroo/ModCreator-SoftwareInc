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

namespace SoftwareIncModMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Draw the tab 
            iterateTab();
            
        }

        private void iterateTab()
        {
            foreach (TabPage tab in tabControl1.TabPages)
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(tab.Text);

                //event handler
                menuItem.Click += new EventHandler(deleteItem_Click);
                deleteTabToolStripMenuItem.DropDownItems.Add(menuItem);
            }
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItemIndex = sender as ToolStripMenuItem;
            deleteTabToolStripMenuItem.DropDownItems.RemoveByKey(menuItemIndex.Text);
            tabControl1.TabPages.RemoveByKey(menuItemIndex.Text);
        }

        private int getMenuStripIndex(object sender)
        {
            ToolStripMenuItem deleteTabMember = sender as ToolStripMenuItem;
            if(deleteTabMember != null)
            {
                int index = ContextMenuStrip.Items.IndexOf(deleteTabMember);
                return index;
            }
            return 0;
            
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
    }
}
