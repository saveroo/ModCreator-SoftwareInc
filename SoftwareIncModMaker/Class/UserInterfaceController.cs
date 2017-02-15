namespace SoftwareIncModMaker
{
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public static class UserInterfaceController
    {
        public static void DisposeAllButThis(Form form, Form[] whichForm)
        {
            foreach (var frm in whichForm)
                if (frm.GetType() != form.GetType() && frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
        }

        public static void RightClickMenu(ContextMenuStrip formName, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) formName.Show(Control.MousePosition);
        }

        public static async void ShowChildForm(Form here, Form child)
        {
            await Task.Run(() => WorkerClass.Start()).ConfigureAwait(true);
            var childForm = child;
            childForm.MdiParent = here;
            childForm.Show();
        }

        private static void Main()
        {
        }
    }
}