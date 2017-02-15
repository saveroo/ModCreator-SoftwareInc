namespace SoftwareIncModMaker
{
    using System;
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;

    using SoftwareIncModMaker.Class;

    public partial class WikiBrowser : Form
    {
        public WikiBrowser()
        {
            this.InitializeComponent();
            var newBrowser = new WebBrowserClass();
            newBrowser.WikiBrowser(this.webBrowser1);
        }

        private void ToolStripButton1Click(object sender, EventArgs e)
        {
            this.webBrowser1.Document.Window.ScrollTo(0, 0);
        }

        private void ToolStripButton2Click(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "SoftwareIncModMaker.web.html";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                var result = reader.ReadToEnd();
                this.webBrowser1.DocumentText = result;
            }
        }

        private void ToolStripTextBox1KeyDown(object sender, KeyEventArgs e)
        {
            this.webBrowser1.DocumentText = "web.html";
        }

        private void WebBrowser1DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void WikiBrowserLoad(object sender, EventArgs e)
        {
        }

        private void WikiLinkComboBoxClick(object sender, EventArgs e)
        {
        }
    }
}