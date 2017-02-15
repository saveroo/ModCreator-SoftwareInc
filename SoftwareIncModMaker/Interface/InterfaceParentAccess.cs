namespace SoftwareIncModMaker
{
    using System.Windows.Forms;

    public interface IMdiParentAccess
    {
        StatusStrip ActionHistoryAccess();

        ToolStripStatusLabel statusCurrent();

        ToolStripStatusLabel statusInformation();

        ToolStripStatusLabel statusLast();
    }
}