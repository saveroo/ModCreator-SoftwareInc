using System;
using System.Windows.Forms;

namespace SoftwareIncModMaker
{
    public partial class ParentForm : Form
    {

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
        }

        private void treeviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInterfaceController.showChildForm(this, new EditorForm());
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
    }
}
