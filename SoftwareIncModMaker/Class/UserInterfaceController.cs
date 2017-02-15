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

        public static void rightClickMenu(ContextMenuStrip formName, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) formName.Show(Control.MousePosition);
        }

        public static async void showChildForm(Form Here, Form Child)
        {
            await Task.Run(() => WorkerClass.Start()).ConfigureAwait(true);
            var childForm = Child;
            childForm.MdiParent = Here;
            childForm.Show();
        }

        private static void main()
        {
        }
    }
}