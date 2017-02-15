using System.Windows.Forms;

namespace SoftwareIncModMaker.Class
{
    using System.IO;
    using System.Reflection;

    /// <summary>
    /// The web browser class.
    /// </summary>
    public class WebBrowserClass
    {
        /// <summary>
        /// The wiki browser.
        /// </summary>
        /// <param name="webBrowser">
        /// The wb.
        /// </param>
        public void WikiBrowser(WebBrowser webBrowser)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "SoftwareIncModMaker.Resources.web.html";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                webBrowser.DocumentText = result;
            }
        }

        public void ForumBrowser(Form parent)
        {

        }
    }
}
