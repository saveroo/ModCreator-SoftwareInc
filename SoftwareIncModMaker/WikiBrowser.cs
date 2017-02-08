using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace SoftwareIncModMaker
{
    public partial class WikiBrowser : Form
    {
        public WikiBrowser()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            webBrowser1.DocumentText = "web.html";
        }

        private void WikiBrowser_Load(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "SoftwareIncModMaker.web.html";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                webBrowser1.DocumentText = result;
            }

        }

        private void WikiLinkComboBox_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.Window.ScrollTo(0, 0);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "SoftwareIncModMaker.web.html";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                webBrowser1.DocumentText = result;
            }
        }
    }
}
