using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareIncModMaker
{
    public interface IMdiParentAccess
    {
        StatusStrip ActionHistoryAccess();
        ToolStripStatusLabel statusCurrent();
        ToolStripStatusLabel statusLast();
        ToolStripStatusLabel statusInformation();
    }
}
