using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace SoftwareIncModMaker
{
    public static class UserInterfaceController
    {
        static void main()
        {

        }

        public static async void showChildForm(Form Here, Form Child)
        {
            await Task.Run(() => WorkerClass.Start()).ConfigureAwait(true);
            Form childForm = Child;
            childForm.MdiParent = Here;
            childForm.Show();
        }

        public static void DisposeAllButThis(Form form, Form[] whichForm)
        {
            foreach (Form frm in whichForm)
            {
                if (frm.GetType() != form.GetType()
                    && frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }

        public static void rightClickMenu(ContextMenuStrip formName, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                formName.Show(Form.MousePosition);
            }
        }
    }
}
