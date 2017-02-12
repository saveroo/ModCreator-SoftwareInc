using System;
using System.Drawing;
using System.Windows.Forms;


namespace SoftwareIncModMaker
{
    class ActionMemo
    {
        public static RichTextBox Component;

        public static void addLines(String s)
        {

            if (Component.Lines.Length > 0)
            {
                Component.AppendText(String.Format("{1}: {0}{2}", s, DateTime.Today, Environment.NewLine));
            }
            else
            {
                Component.Text = String.Format("{1}: {0}{2}", s, DateTime.Today, Environment.NewLine);
            }

        }
        public static void addLines(String s, Boolean dataToCheck)
        {
            if (dataToCheck == true)
            {
               addLines(s);
            }
        }
        public static void addLines(String s, Boolean dataToCheck, Color col)
        {
            if (dataToCheck == true)
            {
                Component.SelectionColor = col;
                addLines(s);

            }
        }
        public static void addLines(Object s1, Object s2, Object s3)
        {
            
            if (Component.Lines.Length > 0)
            {
                Component.AppendText(String.Format("{0}: {1}{2}", s1, s2, s3));
            }
            else
            {
                Component.Text = s1.ToString();
            }
        }

    }
}
