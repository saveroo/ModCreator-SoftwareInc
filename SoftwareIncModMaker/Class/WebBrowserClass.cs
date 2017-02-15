namespace SoftwareIncModMaker.Class
{
    using System.IO;
    using System.Reflection;
    using System.Windows.Forms;

    /// <summary>
    ///     The web browser class.
    /// </summary>
    public class WebBrowserClass
    {
        public void ForumBrowser(Form parent)
        {
        }

        /// <summary>
        ///     The wiki browser.
        /// </summary>
        /// <param name="webBrowser">
        ///     The wb.
        /// </param>
        public void WikiBrowser(WebBrowser webBrowser)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "SoftwareIncModMaker.Resources.web.html";

            using (var stream = assembly.GetManifestResourceStream(resourceName))
            using (var reader = new StreamReader(stream))
            {
                var result = reader.ReadToEnd();
                webBrowser.DocumentText = result;
            }
        }
    }
}