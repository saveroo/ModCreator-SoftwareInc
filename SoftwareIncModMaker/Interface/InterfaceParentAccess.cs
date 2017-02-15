namespace SoftwareIncModMaker
{
    using System.Windows.Forms;

    public interface IMdiParentAccess
    {
        StatusStrip ActionHistoryAccess();

        ToolStripStatusLabel StatusCurrent();

        ToolStripStatusLabel StatusInformation();

        ToolStripStatusLabel StatusLast();
    }
}