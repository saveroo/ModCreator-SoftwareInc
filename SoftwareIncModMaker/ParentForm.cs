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

            UserInterfaceController.showChildForm(this, new Form2());
        }

        private void treeviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new Form3());
        }
    }
}
